using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFChamilo6.Frms
{
    public partial class frmCompletaItem : Form
    {

        public static Int32 actualRow;
        public static Int32[] LineasSeleccionadas = new Int32[250];

        public frmCompletaItem()
        {
            InitializeComponent();
        }

        private void frmCompletaItem_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString();            
            // TODO: This line of code loads data into the 'chamiloDataSet.track_e_course_access' table. You can move, or remove it, as needed.
            this.track_e_course_accessTableAdapter.Fill(this.chamiloDataSet.track_e_course_access);            
            // TODO: This line of code loads data into the 'chamiloDataSet.c_lp_item_view_total' table. You can move, or remove it, as needed.
            this.c_lp_item_view_totalTableAdapter.Fill(this.chamiloDataSet.c_lp_item_view_total);
            this.c_lp_item_view_totalBindingSource.Filter = "c_id = " + frmMdi.gblCurso.ToString() + " and user_id = " + frmMdi.gblUsuario.ToString();
            // TODO: This line of code loads data into the 'chamiloDataSet.track_e_exercises' table. You can move, or remove it, as needed.
            this.track_e_exercisesTableAdapter.Fill(this.chamiloDataSet.track_e_exercises);
            this.track_e_exercisesBindingSource.Filter = "c_id = " + frmMdi.gblCurso.ToString() + " and exe_user_id = " + frmMdi.gblUsuario.ToString();
        }

        private void btnGuardaAuto_Click(object sender, EventArgs e)
        {
            GuardaSelección();
            System.Random r = new System.Random();
            double FechaUnix = DateTimeToUnixTimestamp(Convert.ToDateTime(txtFecha.Text));
            double TiempoSegundos = 0;

            
            FechaUnix = FechaUnix + r.Next(1, Convert.ToInt32(txtRandom.Text));

            if (txtSegAuto.Text.Trim() == "")
            {
                MessageBox.Show("Debe introducir un valor numerico valido en el campo Segundos Auto");
            }
            else
            {
                
                Cursor.Current = Cursors.WaitCursor;

                DataGridViewSelectedRowCollection Seleccionados = c_lp_item_view_totalDataGridView.SelectedRows;

                foreach (DataGridViewRow item in Seleccionados)
                {

                    try
                    {
                        TiempoSegundos = (Convert.ToDouble(txtSegAuto.Text) + r.Next(1, Convert.ToInt32(txtRandom.Text)));
                        FechaUnix = FechaUnix + TiempoSegundos;
                        c_lp_item_view_totalTableAdapter.UpdateQuery(Convert.ToInt32( item.Cells[0].Value), Convert.ToInt32( FechaUnix), Convert.ToInt32(TiempoSegundos));
                        //HAY QUE REVISAR PORQUÉ NO ESTÁ FUNCIONANDO ESTO.. O QUE ES LO QUE ESTA HACIENDO
                    }
                    catch {}
                }  // FINAL DEL FOR


                this.c_lp_item_view_totalTableAdapter.Fill(this.chamiloDataSet.c_lp_item_view_total);
                this.c_lp_item_view_totalBindingSource.Filter = "c_id = " + frmMdi.gblCurso.ToString() + " and user_id = " + frmMdi.gblUsuario.ToString();

                //track_e_course_accessTableAdapter.InsertQuery(frmMdi.gblUsuario, Convert.ToDateTime(txtFecha.Text), UnixTimeStampToDateTime(FechaUnix + r.Next(1, 60)), r.Next(1, 247), Convert.ToInt32("0"), null, frmMdi.gblCurso, txtIp.Text.ToString());
                track_e_course_accessTableAdapter.InsertQuery(frmMdi.gblUsuario, Convert.ToDateTime(txtFecha.Text), UnixTimeStampToDateTime(FechaUnix + r.Next(1,60)), r.Next(1, 247), Convert.ToInt32("0"), frmMdi.gblCurso, txtIp.Text.ToString());
                track_e_course_accessTableAdapter.Fill(chamiloDataSet.track_e_course_access);

                ColocaSeleccion();

                // Set cursor as default arrow
                Cursor.Current = Cursors.Default;

                MessageBox.Show("Datos Guardados Correctamente!");                
            }

        }

        //************************ Funciones y Procedimientos ********************** //

        private DateTime ConvierteSegHora(int segundos)
        {
            int num, hor, min, seg;
            //TimeSpan Resp = TimeSpan.Zero;
            DateTime resp;
            num = segundos;
            hor = (num / 3600);
            min = ((num - hor * 3600) / 60);
            seg = num - (hor * 3600 + min * 60);
            resp = Convert.ToDateTime(hor.ToString() + ":" + min.ToString() + ":" + seg.ToString());
            return resp;
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static double DateTimeToUnixTimestamp(DateTime dateTime)
        {
            return (TimeZoneInfo.ConvertTimeToUtc(dateTime) -
                   new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)).TotalSeconds;
        }

        private void GuardaSelección()
        {
            InicializaArray();
            Int32 aux = 0;
            DataGridViewSelectedRowCollection Seleccionados = c_lp_item_view_totalDataGridView.SelectedRows;
            foreach (DataGridViewRow item in Seleccionados)
            {
                LineasSeleccionadas[aux] = item.Index;
                aux++;
            }
            actualRow = LineasSeleccionadas[aux-1]+aux-1;
        }

        private void ColocaSeleccion()
        {
            c_lp_item_view_totalDataGridView.CurrentCell = c_lp_item_view_totalDataGridView[0, actualRow];
            txtLastIid.Text = c_lp_item_view_totalDataGridView[0, actualRow].Value.ToString();
            txtLastDate.Text = txtFecha.Text;

            for (int i = 0; i<50;i++)
            {
                if(LineasSeleccionadas[i] >= 0)
                {
                    c_lp_item_view_totalDataGridView[0, LineasSeleccionadas[i]].Selected = true;
                }
            }
        }

        private void InicializaArray()
        {
            for (int i = 0; i < 50; i++)
            {
                LineasSeleccionadas[i] = -1;
            }
        }


        private string BuscaValorGrid(DataGridView miDataGrid, string valorAbuscar, int columnaAbuscar, int columnaAdevolver)
        {
            string Resp = "";
            foreach (DataGridViewRow Row in miDataGrid.Rows)
            {
                int strFila = Row.Index;
                string Valor = Convert.ToString(Row.Cells[columnaAbuscar].Value);

                if (Valor == valorAbuscar)
                {
                    //MessageBox.Show("El item es " + miDataGrid.Rows[strFila].Cells[columnaAbuscar].Value.ToString() + "\n Y el valor a devolver es: " + miDataGrid.Rows[strFila].Cells[columnaAdevolver].Value.ToString());
                    Resp = (miDataGrid.Rows[strFila].Cells[columnaAdevolver].Value.ToString());
                    //miDataGrid.Rows[strFila].DefaultCellStyle.BackColor = Color.Red;
                }
            }
            return (Resp);
        }

        //************************ Fin Funciones y Procedimientos ********************** //

        private void button1_Click(object sender, EventArgs e)
        {
            string Start_date = "";
            string Start_date_referencia = "";
            double Start_dateDouble = 0;
            string Exe_date = "";
            string Exe_duration = "";
            double Exe_durationDouble = 0;
            string User_ip = "";

            // Set cursor like sandClock 
            Cursor.Current = Cursors.WaitCursor;


            foreach (DataGridViewRow Row2 in track_e_exercisesDataGridView.Rows)
            {


                Start_date = "";
                Start_date_referencia = "";
                Start_dateDouble = 0;
                Exe_date = "";
                Exe_duration = "";
                Exe_durationDouble = 0;
                User_ip = "";

                if (Row2.Cells[0].Value != null)
                {
                    Start_date = BuscaValorGrid(c_lp_item_view_totalDataGridView, Row2.Cells[5].Value.ToString(), 0, 6); //Start_date / Start_Time
                    Start_dateDouble = Convert.ToDouble(Start_date);
                    Start_date_referencia = UnixTimeStampToDateTime(Start_dateDouble).ToString();
                    Exe_duration = BuscaValorGrid(c_lp_item_view_totalDataGridView, Row2.Cells[5].Value.ToString(), 0, 7); //Exe_Duration / Total_Time
                    Exe_durationDouble = Convert.ToDouble(Exe_duration);
                    Exe_date = UnixTimeStampToDateTime(Start_dateDouble + Exe_durationDouble).ToString(); //Exe_date
                    User_ip = txtIp.Text.ToString(); //IP

                    //Row2.Cells[6].Value = User_ip;
                    //Row2.Cells[7].Value = Start_date_referencia;
                    //Row2.Cells[8].Value = Exe_date;
                    //Row2.Cells[15].Value = Exe_duration;

                    track_e_exercisesTableAdapter.UpdateQuery(frmMdi.gblUsuario, frmMdi.gblCurso, Convert.ToInt32(Row2.Cells[5].Value), User_ip, Convert.ToDateTime(Start_date_referencia), Convert.ToDateTime(Exe_date), Convert.ToInt32(Exe_durationDouble));
                    track_e_exercisesTableAdapter.Fill(this.chamiloDataSet.track_e_exercises);
                    this.Refresh();
                }

            }

            Cursor.Current = Cursors.Default;
            //            MessageBox.Show("El item es " + track_e_exercisesDataGridView.SelectedCells[5].Value.ToString() + "\n Y el valor a devolver es: " + Respuesta);
            MessageBox.Show("Proceso Completado con Exito");
        }

       
    }
}

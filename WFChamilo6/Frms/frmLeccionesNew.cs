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
    public partial class frmLeccionesNew : Form
    {
        public frmLeccionesNew()
        {
            InitializeComponent();
        }

        private void frmLeccionesNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chamiloDataSet.track_e_course_access' table. You can move, or remove it, as needed.
            //this.track_e_course_accessTableAdapter.Fill(this.chamiloDataSet.track_e_course_access);
            // TODO: This line of code loads data into the 'chamiloDataSet.c_lp_item_view' table. You can move, or remove it, as needed.
            this.c_lp_item_viewTableAdapter.Fill(this.chamiloDataSet.c_lp_item_view);
            // TODO: This line of code loads data into the 'chamiloDataSet.LeccionesCursoUsr' table. You can move, or remove it, as needed.
            this.leccionesCursoUsrTableAdapter.Fill(this.chamiloDataSet.LeccionesCursoUsr);


            this.leccionesCursoUsrBindingSource.Filter = "c_id = " + frmMdi.gblCurso + " and user_id = " + frmMdi.gblUsuario;
            txtIdUsuario.Text = frmMdi.gblUsuario.ToString();
            txtFirstName.Text = frmMdi.gblFirstName.ToString();
            txtLastName.Text = frmMdi.gblLastName.ToString();

            //track_e_course_accessBindingSource.Filter = "user_id = " + txtIdUsuario.Text.ToString() + " and c_id = " + frmMdi.gblCurso;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            c_lp_item_viewTableAdapter.UpdateQuery(Convert.ToInt32(txtItemId.Text), txtStatus.Text.ToString(), Convert.ToInt32(txtTiempo.Text));
            c_lp_item_viewTableAdapter.Fill(this.chamiloDataSet.c_lp_item_view);

            leccionesCursoUsrTableAdapter.UpdateQueryPorcentaje(Convert.ToInt32(txtIdLeccion.Text), Convert.ToInt32(CalculaPorcentaje()));
            leccionesCursoUsrTableAdapter.Fill(this.chamiloDataSet.LeccionesCursoUsr);

            leccionesCursoUsrBindingSource.MoveFirst();
            c_lp_item_viewBindingSource.Filter = "id = 0";

            MessageBox.Show("Datos Guardados Correctamente!");
        }

        private void txtItemId_TextChanged(object sender, EventArgs e)
        {
            if (c_lp_item_viewDataGridView.SelectedCells.Count != 0)
            {
                if (c_lp_item_viewDataGridView.SelectedCells[0].Value != null)
                {
                    txtHoras.Text = ConvierteSegHora(Convert.ToInt32(c_lp_item_viewDataGridView.SelectedCells[2].Value)).ToString();
                    txtTiempo.Text = c_lp_item_viewDataGridView.SelectedCells[2].Value.ToString();
                    txtStatus.Text = c_lp_item_viewDataGridView.SelectedCells[3].Value.ToString();
                    TxtFechaHora.Text = UnixTimeStampToDateTime(Convert.ToDouble(c_lp_item_viewDataGridView.SelectedCells[6].Value)).ToString();
                    txtActividad.Text = c_lp_item_viewDataGridView.SelectedCells[5].Value.ToString();
                    if (txtStatus.Text == "completed")
                    {
                        chkCompletado.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        chkCompletado.CheckState = CheckState.Unchecked;
                    }
                }
            }
        }

        private void chkCompletado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCompletado.CheckState == CheckState.Checked)
            {
                if (Convert.ToInt32(txtTiempo.Text) == 0 || txtTiempo.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("No Puede Marcar como completado sin colocar el Tiempo", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    chkCompletado.CheckState = CheckState.Unchecked;
                }
                else
                {
                    txtStatus.Text = "completed";
                }

            }
            else
            {
                txtStatus.Text = "not attempted";
            }
        }

        private void txtIdLeccion_TextChanged(object sender, EventArgs e)
        {
            if (leccionesCursoUsrDataGridView.SelectedCells.Count != 0)
            {
                if (leccionesCursoUsrDataGridView.SelectedCells[0].Value != null)
                {
                    c_lp_item_viewBindingSource.Filter = "lp_view_id = " + leccionesCursoUsrDataGridView.SelectedCells[0].Value.ToString();
                    txtTiempoLec.Text = ConvierteSegHora(CalculaTiempo()).ToString();
                }
            }
            else
            {
                c_lp_item_viewTableAdapter.Dispose();
                c_lp_item_viewTableAdapter.Fill(this.chamiloDataSet.c_lp_item_view);
            }
        }

        private Decimal CalculaPorcentaje()
        {
            decimal result = 0;
            int cuenta = 0;
            foreach (DataGridViewRow dgrx in c_lp_item_viewDataGridView.Rows)
            {
                try
                {
                    if (dgrx.Cells[3].Value.ToString() == "completed")
                    {
                        cuenta++;
                    }
                }
                catch (Exception ex)
                {
                }
            }

            if (cuenta != 0)
            {
                result = Convert.ToDecimal(Decimal.Round(((cuenta * 100) / c_lp_item_viewDataGridView.RowCount), 0));
            }
            return result;
        }

        private TimeSpan ConvierteSegHora(int segundos)
        {
            int num, hor, min, seg;
            TimeSpan Resp = TimeSpan.Zero;
            //DateTime resp ;
            num = segundos;
            hor = (num / 3600);
            min = ((num - hor * 3600) / 60);
            seg = num - (hor * 3600 + min * 60);
            try
            {
                Resp = TimeSpan.Parse(hor.ToString() + ":" + min.ToString() + ":" + seg.ToString());
            }
            catch
            {
                Resp = TimeSpan.Parse("0:00:00");
            }

            return Resp;
        }

        private int CalculaTiempo()
        {
            int segundos = 0;
            foreach (DataGridViewRow dgrx in c_lp_item_viewDataGridView.Rows)
            {
                try
                {
                    if (dgrx.Cells[2].Value != null)
                    {
                        segundos = segundos + Convert.ToInt32(dgrx.Cells[2].Value);
                    }
                }
                catch (Exception ex)
                {
                }
            }

            return segundos;
        }

        private void GuardaAutomatico()
        {
            int CeldaActual = leccionesCursoUsrDataGridView.CurrentCell.RowIndex;

            System.Random r = new System.Random();
            foreach (DataGridViewRow dgry in c_lp_item_viewDataGridView.Rows)
            {
                try
                {
                    if (dgry.Cells[2].Value != null)
                    {
                        //MessageBox.Show( (Convert.ToInt32(txtSegAuto.Text) + r.Next(1,800)).ToString() );
                        c_lp_item_viewTableAdapter.UpdateQuery(Convert.ToInt32(dgry.Cells[0].Value), "completed", (Convert.ToInt32(txtSegAuto.Text) + r.Next(1, 180)));

                        txtItemIId.Text = dgry.Cells[0].Value.ToString();
                        txtLeccionId.Text = txtIdLeccion.Text;
                        this.Refresh();
                        c_lp_item_viewTableAdapter.Fill(this.chamiloDataSet.c_lp_item_view);
                    }
                }
                catch (Exception ex)
                {
                }
            }
            leccionesCursoUsrTableAdapter.UpdateQueryPorcentaje(Convert.ToInt32(txtIdLeccion.Text), Convert.ToInt32(CalculaPorcentaje()));
            leccionesCursoUsrTableAdapter.Fill(this.chamiloDataSet.LeccionesCursoUsr);

            leccionesCursoUsrDataGridView.CurrentCell = leccionesCursoUsrDataGridView[0, CeldaActual];

            //leccionesCursoUsrBindingSource.MoveFirst();
            c_lp_item_viewBindingSource.Filter = "id = 0";
        }


        private void SiguienteModulo()
        {
            leccionesCursoUsrBindingSource.MoveNext();
            // ****************** Codigo Recilcado ******************
            if (leccionesCursoUsrDataGridView.SelectedCells.Count != 0)
            {
                if (leccionesCursoUsrDataGridView.SelectedCells[0].Value != null)
                {
                    c_lp_item_viewBindingSource.Filter = "lp_view_id = " + leccionesCursoUsrDataGridView.SelectedCells[0].Value.ToString();
                    txtTiempoLec.Text = ConvierteSegHora(CalculaTiempo()).ToString();
                }
            }
        }


        private void btnGuardaAuto_Click(object sender, EventArgs e)
        {
            // Set cursor like sandClock 
            Cursor.Current = Cursors.WaitCursor;
            grpProcesando.Visible = true;

            if (txtSegAuto.Text.Trim() == "")
            {
                MessageBox.Show("Debe introducir un valor numerico valido en el campo Segundos Auto");
            }
            else
            {
                leccionesCursoUsrBindingSource.MoveFirst();

                foreach (DataGridViewRow row in leccionesCursoUsrDataGridView.Rows)
                {
                    GuardaAutomatico();
                    SiguienteModulo();
                    this.Refresh();
                }

                grpProcesando.Visible = false;

                Cursor.Current = Cursors.Default;

                MessageBox.Show("Datos Guardados Correctamente!");
            }

        }

        private void BtnCreaLeccion_Click(object sender, EventArgs e)
        {
            int cursoActual = Convert.ToInt32(leccionesCursoUsrDataGridView.SelectedCells[1].Value);
            int leccionActual = Convert.ToInt32(leccionesCursoUsrDataGridView.SelectedCells[7].Value);
            //this.c_lpTableAdapter.FillBy(this.chamiloDataSet.c_lp, frmMdi.gblCurso);
            this.c_lpTableAdapter.FillByNotIn(this.chamiloDataSet.c_lp,Convert.ToInt32(txtIdUsuario.Text),frmMdi.gblCurso);
            this.c_lp_itemTableAdapter1.FillBy(this.chamiloDataSet.c_lp_item, leccionActual, cursoActual);

            listBox1.Items.Clear();

            foreach (DataRow row in this.chamiloDataSet.c_lp)
            {
                listBox1.Items.Add(row[0].ToString());
            }

            DataRow miRow = chamiloDataSet.c_lp.Rows[0];

            int lastItem = Convert.ToInt32(this.c_lp_itemTableAdapter1.ScalarQueryMaxItem(Convert.ToInt32( miRow[0]), cursoActual));

            Carga_C_LP_View(Convert.ToInt32(txtIdUsuario.Text), cursoActual, Convert.ToInt32(miRow[0]), lastItem);

            MessageBox.Show(this.chamiloDataSet.c_lp.Count().ToString() + " " + this.chamiloDataSet.c_lp_item.Count().ToString());

        }

        private void Carga_C_LP_View(int usuario, int curso, int leccion, int last_item)
        {
            //Carga un Registro en c_lp_view para que parezca que el usuario a entrado en la lección
            int MaxId = Convert.ToInt32(this.c_lp_viewTableAdapter1.ScalarQueryID());
            this.c_lp_viewTableAdapter1.InsertQuery(curso, (MaxId+1), leccion, usuario, 1, last_item, 100, 0);
        }

        private void Carga_C_LP_Item_View(int curso, int id_lp_item,  int id_lp_view, double startime, int totaltime)
        {
            //Carga los items vistos en c_lp_item_view con los tiempos correspondientes asignados en Startime
            

        }

    }
}

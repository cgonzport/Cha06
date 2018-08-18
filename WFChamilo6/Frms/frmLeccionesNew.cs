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
            if (leccionesCursoUsrDataGridView.Rows.Count != 0)
            {
                //if (leccionesCursoUsrDataGridView.SelectedCells.Count != 0)
                //{
                if (leccionesCursoUsrDataGridView.SelectedCells[0].Value != null)
                {
                    c_lp_item_viewBindingSource.Filter = "lp_view_id = " + leccionesCursoUsrDataGridView.SelectedCells[0].Value.ToString();
                    txtTiempoLec.Text = ConvierteSegHora(CalculaTiempo()).ToString();
                }
                //}
            }
            else
            {
                c_lp_item_viewBindingSource.Filter = "id = 0";
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

            leccionesCursoUsrTableAdapter.UpdateQueryPorcentaje(Convert.ToInt32(CalculaPorcentaje()), Convert.ToInt32(txtIdLeccion.Text));

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
                    //this.c_lp_viewTableAdapter1.UpdateQueryPorcentaje(100,26);
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
            CreaLeccion();
            MessageBox.Show("Ésto termino muy bien!");
        }

        private void CreaLeccion()
        {
            if (leccionesCursoUsrDataGridView.Rows.Count == 0)
            {
                // tiene que crearlas TODAS (en base a c_lp crear los registros en c_lp_view
                MessageBox.Show("Esto Está Vacio por aqui");
                //tengo que recorrer todo c_lp y uno a uno ir creando los c_lp_view
                this.c_lpTableAdapter.FillBy(chamiloDataSet.c_lp, frmMdi.gblCurso);

                foreach (DataRow row in this.chamiloDataSet.c_lp)
                {
                    listBox1.Items.Add(row[0].ToString());
                    Carga_C_LP_View(Convert.ToInt32(txtIdUsuario.Text), frmMdi.gblCurso, Convert.ToInt32(row[0]));
                }

            }
            else if (leccionesCursoUsrDataGridView.Rows.Count < c_lpTableAdapter.GetDataBy(frmMdi.gblCurso).Rows.Count) //comprueba la si la cantidad de lecciones en c_lp_view es igual a la de c_lp
            {
                // Quiere decir que faltan lecciones a las que entrar (que pueden ser en orden o no)
                this.c_lpTableAdapter.FillBy(chamiloDataSet.c_lp, frmMdi.gblCurso);

                foreach (DataRow row in this.chamiloDataSet.c_lp)
                {
                    listBox1.Items.Add(row[0].ToString());

                    if (this.c_lp_viewTableAdapter1.GetDataByCUserLec(frmMdi.gblCurso, Convert.ToInt32(txtIdUsuario.Text), Convert.ToInt32(row[0])).Rows.Count == 0)
                    {
                        Carga_C_LP_View(Convert.ToInt32(txtIdUsuario.Text), frmMdi.gblCurso, Convert.ToInt32(row[0]));
                    }
                }


                MessageBox.Show("Aquí Falta gente");
            }
            else
            {
                // Quiere decir que ya entró en todas las lecciones y no hay que crear nada
                MessageBox.Show("Esto está a tope");
            }
        }

        private void CreaItems(int leccion_c_lp, int leccion_c_lp_view)
        {
            System.Random r = new System.Random();
            // comprobamos que no estén creados los items para este curso
            if (this.c_lp_item_view_origTableAdapter1.GetDataBy2(leccion_c_lp_view).Rows.Count == 0)
            {
                //si los items NO estan creados (que es lo logico) hacer lo siguiente:
                //Buscar los Items en la Tabla c_lp_items para la lección en curso (leccion_c_lp)
                this.c_lp_itemTableAdapter1.FillBy(chamiloDataSet.c_lp_item, leccion_c_lp, frmMdi.gblCurso);
                foreach (DataRow row in this.chamiloDataSet.c_lp_item)
                {
                    //Recorrer la tabla c_lp_items e ir cargando c_lp_item_view con los datos correspondientes
                    Carga_C_LP_Item_View(frmMdi.gblCurso, Convert.ToInt32(row[0]), leccion_c_lp_view, DateTimeToUnixTimestamp(DateTime.Now), (245 + r.Next(1, 180)));
                }

            }
        }

        private void Carga_C_LP_View(int usuario, int curso, int leccion)
        {
            //Carga un Registro en c_lp_view para que parezca que el usuario a entrado en la lección
            int lastItem = 0;
            lastItem = Convert.ToInt32(this.c_lp_itemTableAdapter1.ScalarQueryMaxItem(leccion, curso));
            int MaxId = Convert.ToInt32(this.c_lp_viewTableAdapter1.ScalarQueryID());
            this.c_lp_viewTableAdapter1.InsertQuery(curso, (MaxId + 1), leccion, usuario, 1, lastItem, 100, 0);
            CreaItems(leccion, (MaxId + 1));
        }

        private void Carga_C_LP_Item_View(int curso, int id_lp_item, int id_lp_view, double startime, int totaltime)
        {
            //Carga los items vistos en c_lp_item_view con los tiempos correspondientes asignados en Startime
            int MaxId = Convert.ToInt32(this.c_lp_item_view_origTableAdapter1.ScalarQuery());
            //            this.c_lp_viewTableAdapter1.InsertQuery(curso, (MaxId + 1), leccion, usuario, 1, lastItem, 100, 0);
            this.c_lp_item_view_origTableAdapter1.InsertQuery(curso, (MaxId + 1), id_lp_item, id_lp_view, 1, Convert.ToInt32(startime), totaltime, 0, "completed", "", "", "none", "100");

        }

    }
}

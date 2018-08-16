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
    public partial class frmLecciones : Form
    {
        public frmLecciones()
        {
            InitializeComponent();
        }

        private void frmLecciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chamiloDataSet.c_lp_item_view' table. You can move, or remove it, as needed.
            this.c_lp_item_viewTableAdapter.Fill(this.chamiloDataSet.c_lp_item_view);
            // TODO: This line of code loads data into the 'chamiloDataSet.LeccionesCursoUsr' table. You can move, or remove it, as needed.
            this.leccionesCursoUsrTableAdapter.Fill(this.chamiloDataSet.LeccionesCursoUsr);
            //this.leccionesCursoUsrBindingSource.Filter = "user_id = " + frmMdi.gblUsuario;
            this.leccionesCursoUsrBindingSource.Filter = "c_id = " + frmMdi.gblCurso + " and user_id = " + frmMdi.gblUsuario;
            txtIdUsuario.Text = frmMdi.gblUsuario.ToString();
            txtFirstName.Text = frmMdi.gblFirstName.ToString();
            txtLastName.Text = frmMdi.gblLastName.ToString();
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
                if(c_lp_item_viewDataGridView.SelectedCells[0].Value != null)
                {
                    txtHoras.Text = ConvierteSegHora(Convert.ToInt32(c_lp_item_viewDataGridView.SelectedCells[2].Value)).ToLongTimeString();
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
                    txtTiempoLec.Text = ConvierteSegHora(CalculaTiempo()).ToLongTimeString();
                }
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
                    if(dgrx.Cells[3].Value.ToString() == "completed")
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

        private DateTime ConvierteSegHora(int segundos)
        {
            int num, hor, min, seg;
            //TimeSpan Resp = TimeSpan.Zero;
            DateTime resp ;
            num = segundos;
            hor = (num / 3600);
            min = ((num - hor * 3600) / 60);
            seg = num - (hor * 3600 + min * 60);
            resp = Convert.ToDateTime(hor.ToString()+":"+min.ToString()+":"+seg.ToString());
            return resp;
        }

        private int CalculaTiempo()
        {
            int segundos= 0;
            foreach (DataGridViewRow dgrx in c_lp_item_viewDataGridView.Rows)
            {
                try
                {
                    if (dgrx.Cells[2].Value!= null)
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

        private void btnGuardaAuto_Click(object sender, EventArgs e)
        {
            if(txtSegAuto.Text.Trim() == "")
            {
                MessageBox.Show("Debe introducir un valor numerico valido en el campo Segundos Auto");
            }else
            {
                System.Random r = new System.Random();
                foreach (DataGridViewRow dgry in c_lp_item_viewDataGridView.Rows)
                {
                    try
                    {
                        if (dgry.Cells[2].Value != null)
                        {
                            //MessageBox.Show( (Convert.ToInt32(txtSegAuto.Text) + r.Next(1,800)).ToString() );
                            c_lp_item_viewTableAdapter.UpdateQuery(Convert.ToInt32(dgry.Cells[0].Value), "completed", (Convert.ToInt32(txtSegAuto.Text) + r.Next(1, 800)));
                            c_lp_item_viewTableAdapter.Fill(this.chamiloDataSet.c_lp_item_view);
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                leccionesCursoUsrTableAdapter.UpdateQueryPorcentaje(Convert.ToInt32(txtIdLeccion.Text), Convert.ToInt32(CalculaPorcentaje()));
                leccionesCursoUsrTableAdapter.Fill(this.chamiloDataSet.LeccionesCursoUsr);

                leccionesCursoUsrBindingSource.MoveFirst();
                c_lp_item_viewBindingSource.Filter = "id = 0";

                MessageBox.Show("Datos Guardados Correctamente!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double MiDouble;
            DateTime MiDateTime;
            MiDouble = Math.Round(DateTimeToUnixTimestamp(DateTime.Now), 0);
            MiDateTime = UnixTimeStampToDateTime(MiDouble);
            MessageBox.Show("Fecha Unix: " + MiDouble.ToString() +  "\n" + "Fecha: " + MiDateTime.ToString());
            //MessageBox.Show("Fecha: " + MiDateTime.ToString());

        }
    }
}

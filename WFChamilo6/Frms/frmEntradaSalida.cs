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
    public partial class frmEntradaSalida : Form
    {
        public frmEntradaSalida()
        {
            InitializeComponent();
        }

        private void track_e_loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.track_e_loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chamiloDataSet);
            MessageBox.Show(this, "Datos Guardados Satisfactoriamente","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmEntradaSalida_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chamiloDataSet.track_e_login' table. You can move, or remove it, as needed.
            this.track_e_loginTableAdapter.Fill(this.chamiloDataSet.track_e_login);
            this.track_e_loginBindingSource.Filter = "login_user_id = '" + frmMdi.gblUsuario.ToString() + "'";

            txtTiempoTotal.Text = ConvierteSegHoraStr(Convert.ToInt64(this.track_e_loginTableAdapter.ScalarQueryTotalTimeSec(frmMdi.gblUsuario)));           

        }
        private string ConvierteSegHoraStr(long segundos)
        {
            long num, hor, min, seg;
            string Resp = "0:00:00";
            //DateTime resp ;
            num = segundos;
            hor = (num / 3600);
            min = ((num - hor * 3600) / 60);
            seg = num - (hor * 3600 + min * 60);
            try
            {
                Resp = String.Format("{0,2:D2}", hor) + ":" + String.Format("{0,2:D2}", min) + ":" + String.Format("{0,2:D2}", seg);
            }
            catch
            {
                Resp = "0:00:00";
            }

            return Resp;
        }


    }
}

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

        }

        private void frmEntradaSalida_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chamiloDataSet.track_e_login' table. You can move, or remove it, as needed.
            this.track_e_loginTableAdapter.Fill(this.chamiloDataSet.track_e_login);
            this.track_e_loginBindingSource.Filter = "login_user_id = '" + frmMdi.gblUsuario.ToString() + "'";
        }


    }
}

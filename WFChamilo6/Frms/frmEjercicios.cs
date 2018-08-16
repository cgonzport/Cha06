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
    public partial class frmEjercicios : Form
    {
        public frmEjercicios()
        {
            InitializeComponent();
        }

        private void track_e_exercisesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.track_e_exercisesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chamiloDataSet);

        }

        private void frmEjercicios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chamiloDataSet.track_e_exercises' table. You can move, or remove it, as needed.
            this.track_e_exercisesTableAdapter.Fill(this.chamiloDataSet.track_e_exercises);
            this.track_e_exercisesBindingSource.Filter = "c_id = " + frmMdi.gblCurso.ToString() + " and exe_user_id = " + frmMdi.gblUsuario.ToString();
        }
    }
}

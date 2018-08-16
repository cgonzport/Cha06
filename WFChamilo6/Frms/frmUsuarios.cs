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
    public partial class frmUsuarios : Form
    {
        string filtroEstatus = "";

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chamiloDataSet);

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chamiloDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.chamiloDataSet.user);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void optTodos_CheckedChanged(object sender, EventArgs e)
        {
            filtroEstatus = "";
            ActualizaGrid();
        }


        private void optActivos_CheckedChanged(object sender, EventArgs e)
        {
            filtroEstatus = "active = true";
            ActualizaGrid();
        }

        private void optInactivos_CheckedChanged(object sender, EventArgs e)
        {
            filtroEstatus = "active = false";
            ActualizaGrid();
        }

        private void ActualizaGrid()
        {
            if (cboFiltro.Text != "")
            {
                if (filtroEstatus == "")
                {
                    userBindingSource.Filter = cboFiltro.Text + " like '%" + txtFiltro.Text.ToString() + "%'";
                }
                else
                {
                    userBindingSource.Filter = cboFiltro.Text + " like '%" + txtFiltro.Text.ToString() + "%' and " + filtroEstatus;
                }
                
            }
            else
            {
                if (filtroEstatus != "")
                {
                    userBindingSource.Filter = filtroEstatus;
                }
            }
            //LimpiaDatos();
        }

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboFiltro.SelectedIndex == 0)
            {
                LimpiaDatos();
            }
        }

        private void LimpiaDatos()
        {
            //if (userBindingSource.Count == 0)
            //{
                userBindingSource.Filter = "";
                optTodos.Checked = true;
                txtFiltro.Text = "";
                cboFiltro.SelectedIndex = 0;
                //MessageBox.Show("Está Vacio");
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFChamilo6
{
    public partial class frmMdi : Form
    {
        Frms.frmUsuarios frmUsuario;
        Frms.frmGeneral frmGeneral;
        
        public static int gblUsuario = 0;
        public static int gblCurso = 0;
        public static string gblFirstName = "";
        public static string gblLastName = "";
        public static DateTime gbDateTime;

        public frmMdi()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(frmUsuario==null)
            //{
                frmUsuario = new Frms.frmUsuarios();
                frmUsuario.MdiParent = this;
                frmUsuario.Show();
            //}
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (frmGeneral == null)
            //{
                frmGeneral = new Frms.frmGeneral();
                frmGeneral.MdiParent = this;
                frmGeneral.Show();
            //}
        }
    }
}

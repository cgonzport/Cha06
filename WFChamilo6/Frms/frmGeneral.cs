using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace WFChamilo6.Frms
{
    public partial class frmGeneral : Form
    {
        Frms.frmLeccionesNew frmLeccionesNew;
        Frms.frmLecciones frmLecciones;
        Frms.frmEntradaSalida frmInOut;
        Frms.frmCompletaItem frmCompletaItem;
        Frms.frmEjercicios frmEjercicios;
        Frms.frmMensajes frmMensajes;

        public frmGeneral()
        {
            InitializeComponent();
        }

        private void frmGeneral_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chamiloDataSet.track_e_course_access' table. You can move, or remove it, as needed.
            this.track_e_course_accessTableAdapter.Fill(this.chamiloDataSet.track_e_course_access);
            // TODO: This line of code loads data into the 'chamiloDataSet.CursoAlumno' table. You can move, or remove it, as needed.
            this.cursoAlumnoTableAdapter.Fill(this.chamiloDataSet.CursoAlumno);
            // TODO: This line of code loads data into the 'chamiloDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.chamiloDataSet.user);        
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
          //  try
            //{
                cursoAlumnoBindingSource.Filter = "user_id = " + txtIdUsuario.Text;
                track_e_course_accessBindingSource.RemoveFilter();
                track_e_course_accessBindingSource.Filter = "user_id = 0";
                track_e_course_accessDataGridView.Refresh();
                //track_e_course_accessDataGridView.Rows.Clear();
            //}
            //catch (Exception exep)
            //{

            //}
        }

        private void cursoAlumnoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            track_e_course_accessBindingSource.Filter = "user_id = " + cursoAlumnoDataGridView.SelectedCells[1].Value.ToString() + " and c_id = " + cursoAlumnoDataGridView.SelectedCells[2].Value.ToString();
            TimeSpan sum = TimeSpan.Zero;
            foreach (DataGridViewRow x in track_e_course_accessDataGridView.Rows)
            {
                try
                {
                    //sum = sum.Add(Convert.ToDateTime(x.Cells[4].Value.ToString()) - Convert.ToDateTime(x.Cells[3].Value.ToString()));
                    sum = sum.Add(Convert.ToDateTime(x.Cells[4].Value) - Convert.ToDateTime(x.Cells[3].Value));
                }
                catch(Exception ex)
                {

                }
                
            }
            txtSumaHoras.Text = sum.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.track_e_course_accessBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chamiloDataSet);
            MessageBox.Show("Datos Guardados Correctamente!");
        }

        private void btnModifLecciones_Click(object sender, EventArgs e)
        {
            frmMdi.gblCurso = Convert.ToInt32(cursoAlumnoDataGridView.SelectedCells[2].Value);
            frmMdi.gblUsuario = Convert.ToInt32(txtIdUsuario.Text);
            frmMdi.gblFirstName = txtNombre.Text.ToString();
            frmMdi.gblLastName = txtApellido.Text.ToString();

            //DialogResult dialogResult = MessageBox.Show("¿Desea Modificar las Lecciones para el usuario " + 
            //    txtNombre.Text.ToString() + " " + txtApellido.Text.ToString() +
            //    " en el curso " + cursoAlumnoDataGridView.SelectedCells[3].Value.ToString(),
            //    "Modificación de Leccciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
                frmLecciones = new Frms.frmLecciones();
                frmLecciones.MdiParent = this.MdiParent;
                frmLecciones.Show();
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    //do something else
            //}
        }

        private void BtnLeccionesNew_Click(object sender, EventArgs e)
        {
            frmMdi.gblCurso = Convert.ToInt32(cursoAlumnoDataGridView.SelectedCells[2].Value);
            frmMdi.gblUsuario = Convert.ToInt32(txtIdUsuario.Text);
            frmMdi.gblFirstName = txtNombre.Text.ToString();
            frmMdi.gblLastName = txtApellido.Text.ToString();

            //DialogResult dialogResult = MessageBox.Show("¿Desea Modificar las Lecciones para el usuario " + 
            //    txtNombre.Text.ToString() + " " + txtApellido.Text.ToString() +
            //    " en el curso " + cursoAlumnoDataGridView.SelectedCells[3].Value.ToString(),
            //    "Modificación de Leccciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            frmLeccionesNew = new Frms.frmLeccionesNew();
            frmLeccionesNew.MdiParent = this.MdiParent;
            frmLeccionesNew.Show();
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    //do something else
            //}
        }

        private void btnInOut_Click(object sender, EventArgs e)
        {
            frmMdi.gblCurso = Convert.ToInt32(cursoAlumnoDataGridView.SelectedCells[2].Value);
            frmMdi.gblUsuario = Convert.ToInt32(txtIdUsuario.Text);
            frmMdi.gblFirstName = txtNombre.Text.ToString();
            frmMdi.gblLastName = txtApellido.Text.ToString();
            frmInOut = new Frms.frmEntradaSalida();
            frmInOut.MdiParent = this.MdiParent;
            frmInOut.Show();
        }

        private void btnCompleta_Click(object sender, EventArgs e)
        {
            frmMdi.gblCurso = Convert.ToInt32(cursoAlumnoDataGridView.SelectedCells[2].Value);
            frmMdi.gblUsuario = Convert.ToInt32(txtIdUsuario.Text);
            frmMdi.gblFirstName = txtNombre.Text.ToString();
            frmMdi.gblLastName = txtApellido.Text.ToString();
            frmCompletaItem = new Frms.frmCompletaItem();
            frmCompletaItem.MdiParent = this.MdiParent;
            frmCompletaItem.Show();
        }

        private void track_e_course_accessDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show(track_e_course_accessDataGridView.SelectedCells[3].Value.ToString());
            frmMdi.gbDateTime = (DateTime)track_e_course_accessDataGridView.SelectedCells[3].Value;
        }

        private void btnEjercicios_Click(object sender, EventArgs e)
        {
            frmMdi.gblCurso = Convert.ToInt32(cursoAlumnoDataGridView.SelectedCells[2].Value);
            frmMdi.gblUsuario = Convert.ToInt32(txtIdUsuario.Text);
            frmMdi.gblFirstName = txtNombre.Text.ToString();
            frmMdi.gblLastName = txtApellido.Text.ToString();
            frmEjercicios = new frmEjercicios();
            frmEjercicios.MdiParent = this.MdiParent;
            frmEjercicios.Show();
        }

        private void btnMensajes_Click(object sender, EventArgs e)
        {
            frmMdi.gblCurso = Convert.ToInt32(cursoAlumnoDataGridView.SelectedCells[2].Value);
            frmMdi.gblUsuario = Convert.ToInt32(txtIdUsuario.Text);
            frmMdi.gblFirstName = txtNombre.Text.ToString();
            frmMdi.gblLastName = txtApellido.Text.ToString();
            frmMensajes = new frmMensajes();
            frmMensajes.MdiParent = this.MdiParent;
            frmMensajes.Show();

        }
    }
}

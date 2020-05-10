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
    public partial class frmMensajes : Form
    {

        public static Int32 actualRow;
        public static Int32[] LineasSeleccionadas = new Int32[250];


        public frmMensajes()
        {
            
            InitializeComponent();
        }


        private void frmMensajes_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'chamiloDataSet.message' Puede moverla o quitarla según sea necesario.
            this.messageTableAdapter.Fill(this.chamiloDataSet.message);
            // TODO: esta línea de código carga datos en la tabla 'chamiloDataSet.UserMessage' Puede moverla o quitarla según sea necesario.
            this.userMessageTableAdapter.Fill(this.chamiloDataSet.UserMessage);            

            //-------------------------------------------

            this.userMessageBindingSource.Filter = "id_Alumno = " + frmMdi.gblUsuario;
            this.messageBindingSource.Filter = "user_receiver_id = " + frmMdi.gblUsuario;
            
            txtIdUsuario.Text = frmMdi.gblUsuario.ToString();
            txtFirstName.Text = frmMdi.gblFirstName.ToString();
            txtLastName.Text = frmMdi.gblLastName.ToString();
            //progressBar1.Value = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea Modificar todos los Registros Seleccionados?", "PREGUNTA", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;

                DataGridViewSelectedRowCollection Seleccionados = userMessageDataGridView.SelectedRows;
                try
                {
                    foreach (DataGridViewRow item in Seleccionados)
                    {
                        messageTableAdapter.UpdateQuery(Convert.ToDateTime(txtNuevaFecha.Text.ToString()), Convert.ToInt32(item.Cells[0].Value));
                    }  // FINAL DEL FOR

                    this.messageTableAdapter.Fill(this.chamiloDataSet.message);
                    this.userMessageTableAdapter.Fill(this.chamiloDataSet.UserMessage);
                    this.userMessageBindingSource.Filter = "id_Alumno = " + frmMdi.gblUsuario;
                    this.messageBindingSource.Filter = "user_receiver_id = " + frmMdi.gblUsuario;
                    MessageBox.Show("GUARDADO", "Datos Guardados Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Hubo un error al guardar. Posiblemente la fecha/hora sea Incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void txtIdMensaje_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.messageBindingSource.Filter = "id = " + userMessageDataGridView.SelectedCells[0].Value.ToString();
            }
            catch (Exception ex) { }
        }


        private void GuardaSelección()
        {
            InicializaArray();
            Int32 aux = 0;
            DataGridViewSelectedRowCollection Seleccionados = userMessageDataGridView.SelectedRows;
            foreach (DataGridViewRow item in Seleccionados)
            {
                LineasSeleccionadas[aux] = item.Index;
                aux++;
            }
            actualRow = LineasSeleccionadas[aux - 1] + aux - 1;
        }

        private void ColocaSeleccion()
        {
            userMessageDataGridView.CurrentCell = userMessageDataGridView[0, actualRow];
            //txtLastIid.Text = userMessageDataGridView[0, actualRow].Value.ToString();
            //txtLastDate.Text = txtFecha.Text;

            for (int i = 0; i < 50; i++)
            {
                if (LineasSeleccionadas[i] >= 0)
                {
                    userMessageDataGridView[0, LineasSeleccionadas[i]].Selected = true;
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


    }
}

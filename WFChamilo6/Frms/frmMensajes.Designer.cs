namespace WFChamilo6.Frms
{
    partial class frmMensajes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userMessageDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtIdMensaje = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNuevaFecha = new System.Windows.Forms.TextBox();
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chamiloDataSet = new WFChamilo6.chamiloDataSet();
            this.userMessageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMessageTableAdapter = new WFChamilo6.chamiloDataSetTableAdapters.UserMessageTableAdapter();
            this.tableAdapterManager = new WFChamilo6.chamiloDataSetTableAdapters.TableAdapterManager();
            this.messageTableAdapter = new WFChamilo6.chamiloDataSetTableAdapters.messageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userMessageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamiloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMessageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userMessageDataGridView
            // 
            this.userMessageDataGridView.AllowUserToAddRows = false;
            this.userMessageDataGridView.AllowUserToDeleteRows = false;
            this.userMessageDataGridView.AllowUserToResizeRows = false;
            this.userMessageDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userMessageDataGridView.AutoGenerateColumns = false;
            this.userMessageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userMessageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn15});
            this.userMessageDataGridView.DataSource = this.userMessageBindingSource;
            this.userMessageDataGridView.Location = new System.Drawing.Point(31, 58);
            this.userMessageDataGridView.Name = "userMessageDataGridView";
            this.userMessageDataGridView.ReadOnly = true;
            this.userMessageDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userMessageDataGridView.Size = new System.Drawing.Size(1149, 307);
            this.userMessageDataGridView.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(31, 28);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(54, 20);
            this.txtIdUsuario.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(254, 28);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(155, 20);
            this.txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(101, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(137, 20);
            this.txtFirstName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mensaje";
            // 
            // txtTitulo
            // 
            this.txtTitulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userMessageBindingSource, "title", true));
            this.txtTitulo.Location = new System.Drawing.Point(31, 455);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(534, 20);
            this.txtTitulo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Titulo";
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userMessageBindingSource, "content", true));
            this.richTextBox1.Location = new System.Drawing.Point(31, 503);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(534, 136);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(991, 390);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(189, 52);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Modificar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdMensaje
            // 
            this.txtIdMensaje.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userMessageBindingSource, "id", true));
            this.txtIdMensaje.Location = new System.Drawing.Point(424, 28);
            this.txtIdMensaje.Name = "txtIdMensaje";
            this.txtIdMensaje.Size = new System.Drawing.Size(112, 20);
            this.txtIdMensaje.TabIndex = 21;
            this.txtIdMensaje.Visible = false;
            this.txtIdMensaje.TextChanged += new System.EventHandler(this.txtIdMensaje_TextChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userMessageBindingSource, "send_date", true));
            this.txtFecha.Location = new System.Drawing.Point(31, 412);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(240, 20);
            this.txtFecha.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fecha Actual";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nueva Fecha";
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.Location = new System.Drawing.Point(296, 412);
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(240, 20);
            this.txtNuevaFecha.TabIndex = 24;
            // 
            // messageBindingSource
            // 
            this.messageBindingSource.DataMember = "message";
            this.messageBindingSource.DataSource = this.chamiloDataSet;
            // 
            // chamiloDataSet
            // 
            this.chamiloDataSet.DataSetName = "chamiloDataSet";
            this.chamiloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userMessageBindingSource
            // 
            this.userMessageBindingSource.DataMember = "UserMessage";
            this.userMessageBindingSource.DataSource = this.chamiloDataSet;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn7.HeaderText = "id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_Profesor";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_Profesor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NombreProfesor";
            this.dataGridViewTextBoxColumn5.HeaderText = "NombreProfesor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ApellidoProfesor";
            this.dataGridViewTextBoxColumn6.HeaderText = "ApellidoProfesor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "msg_status";
            this.dataGridViewCheckBoxColumn1.HeaderText = "msg_status";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "send_date";
            this.dataGridViewTextBoxColumn10.HeaderText = "send_date";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn11.HeaderText = "title";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 350;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "update_date";
            this.dataGridViewTextBoxColumn15.HeaderText = "update_date";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // userMessageTableAdapter
            // 
            this.userMessageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.c_lp_item_view_origTableAdapter = null;
            this.tableAdapterManager.c_lp_itemTableAdapter = null;
            this.tableAdapterManager.c_lp_viewTableAdapter = null;
            this.tableAdapterManager.c_lpTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.course_rel_userTableAdapter = null;
            this.tableAdapterManager.courseTableAdapter = null;
            this.tableAdapterManager.messageTableAdapter = null;
            this.tableAdapterManager.track_e_course_accessTableAdapter = null;
            this.tableAdapterManager.track_e_exercisesTableAdapter = null;
            this.tableAdapterManager.track_e_loginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WFChamilo6.chamiloDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // messageTableAdapter
            // 
            this.messageTableAdapter.ClearBeforeFill = true;
            // 
            // frmMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 787);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtIdMensaje);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.userMessageDataGridView);
            this.Name = "frmMensajes";
            this.Text = "Mensajes";
            this.Load += new System.EventHandler(this.frmMensajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userMessageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamiloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMessageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private chamiloDataSet chamiloDataSet;
        private System.Windows.Forms.BindingSource userMessageBindingSource;
        private chamiloDataSetTableAdapters.UserMessageTableAdapter userMessageTableAdapter;
        private chamiloDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView userMessageDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource messageBindingSource;
        private chamiloDataSetTableAdapters.messageTableAdapter messageTableAdapter;
        private System.Windows.Forms.TextBox txtIdMensaje;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNuevaFecha;
    }
}
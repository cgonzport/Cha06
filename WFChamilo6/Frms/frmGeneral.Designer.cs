namespace WFChamilo6.Frms
{
    partial class frmGeneral
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
            this.chamiloDataSet = new WFChamilo6.chamiloDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new WFChamilo6.chamiloDataSetTableAdapters.userTableAdapter();
            this.cursoAlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoAlumnoTableAdapter = new WFChamilo6.chamiloDataSetTableAdapters.CursoAlumnoTableAdapter();
            this.tableAdapterManager = new WFChamilo6.chamiloDataSetTableAdapters.TableAdapterManager();
            this.track_e_course_accessTableAdapter = new WFChamilo6.chamiloDataSetTableAdapters.track_e_course_accessTableAdapter();
            this.cursoAlumnoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboUserName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.track_e_course_accessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.track_e_course_accessDataGridView = new System.Windows.Forms.DataGridView();
            this.course_access_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSumaHoras = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModifLecciones = new System.Windows.Forms.Button();
            this.BtnLeccionesNew = new System.Windows.Forms.Button();
            this.btnInOut = new System.Windows.Forms.Button();
            this.btnCompleta = new System.Windows.Forms.Button();
            this.btnEjercicios = new System.Windows.Forms.Button();
            this.btnMensajes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chamiloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoAlumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoAlumnoDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_e_course_accessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_e_course_accessDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chamiloDataSet
            // 
            this.chamiloDataSet.DataSetName = "chamiloDataSet";
            this.chamiloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.chamiloDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // cursoAlumnoBindingSource
            // 
            this.cursoAlumnoBindingSource.DataMember = "CursoAlumno";
            this.cursoAlumnoBindingSource.DataSource = this.chamiloDataSet;
            // 
            // cursoAlumnoTableAdapter
            // 
            this.cursoAlumnoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.c_lp_item_view_origTableAdapter = null;
            this.tableAdapterManager.c_lp_itemTableAdapter = null;
            this.tableAdapterManager.c_lp_viewTableAdapter = null;
            this.tableAdapterManager.c_lpTableAdapter = null;
            this.tableAdapterManager.course_rel_userTableAdapter = null;
            this.tableAdapterManager.courseTableAdapter = null;
            this.tableAdapterManager.messageTableAdapter = null;
            this.tableAdapterManager.track_e_course_accessTableAdapter = this.track_e_course_accessTableAdapter;
            this.tableAdapterManager.track_e_exercisesTableAdapter = null;
            this.tableAdapterManager.track_e_loginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WFChamilo6.chamiloDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = this.userTableAdapter;
            // 
            // track_e_course_accessTableAdapter
            // 
            this.track_e_course_accessTableAdapter.ClearBeforeFill = true;
            // 
            // cursoAlumnoDataGridView
            // 
            this.cursoAlumnoDataGridView.AllowUserToAddRows = false;
            this.cursoAlumnoDataGridView.AllowUserToDeleteRows = false;
            this.cursoAlumnoDataGridView.AllowUserToResizeRows = false;
            this.cursoAlumnoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cursoAlumnoDataGridView.AutoGenerateColumns = false;
            this.cursoAlumnoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursoAlumnoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41});
            this.cursoAlumnoDataGridView.DataSource = this.cursoAlumnoBindingSource;
            this.cursoAlumnoDataGridView.Location = new System.Drawing.Point(12, 106);
            this.cursoAlumnoDataGridView.MultiSelect = false;
            this.cursoAlumnoDataGridView.Name = "cursoAlumnoDataGridView";
            this.cursoAlumnoDataGridView.ReadOnly = true;
            this.cursoAlumnoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cursoAlumnoDataGridView.Size = new System.Drawing.Size(884, 247);
            this.cursoAlumnoDataGridView.TabIndex = 5;
            this.cursoAlumnoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cursoAlumnoDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn32.HeaderText = "id";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Width = 60;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn33.HeaderText = "user_id";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Width = 60;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "c_id";
            this.dataGridViewTextBoxColumn34.HeaderText = "c_id";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Width = 60;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn40.HeaderText = "title";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            this.dataGridViewTextBoxColumn40.Width = 180;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "code";
            this.dataGridViewTextBoxColumn41.HeaderText = "code";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            this.dataGridViewTextBoxColumn41.Width = 180;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdUsuario);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.cboUserName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 60);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el Usuario";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "user_id", true));
            this.txtIdUsuario.Location = new System.Drawing.Point(548, 23);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(46, 20);
            this.txtIdUsuario.TabIndex = 10;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "lastname", true));
            this.txtApellido.Location = new System.Drawing.Point(339, 23);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(199, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "firstname", true));
            this.txtNombre.Location = new System.Drawing.Point(151, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(178, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // cboUserName
            // 
            this.cboUserName.DataSource = this.userBindingSource;
            this.cboUserName.DisplayMember = "username";
            this.cboUserName.FormattingEnabled = true;
            this.cboUserName.Location = new System.Drawing.Point(11, 23);
            this.cboUserName.Name = "cboUserName";
            this.cboUserName.Size = new System.Drawing.Size(130, 21);
            this.cboUserName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selecciona el Curso del usuario";
            // 
            // track_e_course_accessBindingSource
            // 
            this.track_e_course_accessBindingSource.DataMember = "track_e_course_access";
            this.track_e_course_accessBindingSource.DataSource = this.chamiloDataSet;
            // 
            // track_e_course_accessDataGridView
            // 
            this.track_e_course_accessDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.track_e_course_accessDataGridView.AutoGenerateColumns = false;
            this.track_e_course_accessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.track_e_course_accessDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.course_access_id,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8});
            this.track_e_course_accessDataGridView.DataSource = this.track_e_course_accessBindingSource;
            this.track_e_course_accessDataGridView.Location = new System.Drawing.Point(12, 378);
            this.track_e_course_accessDataGridView.Name = "track_e_course_accessDataGridView";
            this.track_e_course_accessDataGridView.Size = new System.Drawing.Size(884, 335);
            this.track_e_course_accessDataGridView.TabIndex = 8;
            this.track_e_course_accessDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.track_e_course_accessDataGridView_RowHeaderMouseClick);
            // 
            // course_access_id
            // 
            this.course_access_id.DataPropertyName = "course_access_id";
            this.course_access_id.HeaderText = "course_access_id";
            this.course_access_id.Name = "course_access_id";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "c_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "c_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "user_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "login_course_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "login_course_date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "logout_course_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "logout_course_date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 155;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "user_ip";
            this.dataGridViewTextBoxColumn8.HeaderText = "user_ip";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // txtSumaHoras
            // 
            this.txtSumaHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSumaHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaHoras.Location = new System.Drawing.Point(922, 424);
            this.txtSumaHoras.Name = "txtSumaHoras";
            this.txtSumaHoras.ReadOnly = true;
            this.txtSumaHoras.Size = new System.Drawing.Size(143, 26);
            this.txtSumaHoras.TabIndex = 9;
            this.txtSumaHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(922, 475);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 36);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar Datos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(919, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tiempo Total Usuario - Curso";
            // 
            // btnModifLecciones
            // 
            this.btnModifLecciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifLecciones.Location = new System.Drawing.Point(922, 57);
            this.btnModifLecciones.Name = "btnModifLecciones";
            this.btnModifLecciones.Size = new System.Drawing.Size(121, 36);
            this.btnModifLecciones.TabIndex = 12;
            this.btnModifLecciones.Text = "Lecciones Old";
            this.btnModifLecciones.UseVisualStyleBackColor = true;
            this.btnModifLecciones.Visible = false;
            this.btnModifLecciones.Click += new System.EventHandler(this.btnModifLecciones_Click);
            // 
            // BtnLeccionesNew
            // 
            this.BtnLeccionesNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLeccionesNew.Location = new System.Drawing.Point(922, 104);
            this.BtnLeccionesNew.Name = "BtnLeccionesNew";
            this.BtnLeccionesNew.Size = new System.Drawing.Size(121, 36);
            this.BtnLeccionesNew.TabIndex = 13;
            this.BtnLeccionesNew.Text = "Lecciones";
            this.BtnLeccionesNew.UseVisualStyleBackColor = true;
            this.BtnLeccionesNew.Click += new System.EventHandler(this.BtnLeccionesNew_Click);
            // 
            // btnInOut
            // 
            this.btnInOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInOut.Location = new System.Drawing.Point(922, 151);
            this.btnInOut.Name = "btnInOut";
            this.btnInOut.Size = new System.Drawing.Size(121, 36);
            this.btnInOut.TabIndex = 14;
            this.btnInOut.Text = "Entrada-Salida";
            this.btnInOut.UseVisualStyleBackColor = true;
            this.btnInOut.Click += new System.EventHandler(this.btnInOut_Click);
            // 
            // btnCompleta
            // 
            this.btnCompleta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompleta.Location = new System.Drawing.Point(922, 198);
            this.btnCompleta.Name = "btnCompleta";
            this.btnCompleta.Size = new System.Drawing.Size(121, 36);
            this.btnCompleta.TabIndex = 15;
            this.btnCompleta.Text = "Completa Items";
            this.btnCompleta.UseVisualStyleBackColor = true;
            this.btnCompleta.Click += new System.EventHandler(this.btnCompleta_Click);
            // 
            // btnEjercicios
            // 
            this.btnEjercicios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEjercicios.Location = new System.Drawing.Point(922, 245);
            this.btnEjercicios.Name = "btnEjercicios";
            this.btnEjercicios.Size = new System.Drawing.Size(121, 36);
            this.btnEjercicios.TabIndex = 16;
            this.btnEjercicios.Text = "Ejercicios";
            this.btnEjercicios.UseVisualStyleBackColor = true;
            this.btnEjercicios.Click += new System.EventHandler(this.btnEjercicios_Click);
            // 
            // btnMensajes
            // 
            this.btnMensajes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMensajes.Location = new System.Drawing.Point(922, 292);
            this.btnMensajes.Name = "btnMensajes";
            this.btnMensajes.Size = new System.Drawing.Size(121, 36);
            this.btnMensajes.TabIndex = 17;
            this.btnMensajes.Text = "Mensajes";
            this.btnMensajes.UseVisualStyleBackColor = true;
            this.btnMensajes.Click += new System.EventHandler(this.btnMensajes_Click);
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 728);
            this.Controls.Add(this.btnMensajes);
            this.Controls.Add(this.btnEjercicios);
            this.Controls.Add(this.btnCompleta);
            this.Controls.Add(this.btnInOut);
            this.Controls.Add(this.BtnLeccionesNew);
            this.Controls.Add(this.btnModifLecciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtSumaHoras);
            this.Controls.Add(this.track_e_course_accessDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cursoAlumnoDataGridView);
            this.Name = "frmGeneral";
            this.Text = "Edición General";
            this.Load += new System.EventHandler(this.frmGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chamiloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoAlumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoAlumnoDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_e_course_accessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_e_course_accessDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private chamiloDataSet chamiloDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private chamiloDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource cursoAlumnoBindingSource;
        private chamiloDataSetTableAdapters.CursoAlumnoTableAdapter cursoAlumnoTableAdapter;
        private chamiloDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cursoAlumnoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource track_e_course_accessBindingSource;
        private chamiloDataSetTableAdapters.track_e_course_accessTableAdapter track_e_course_accessTableAdapter;
        private System.Windows.Forms.DataGridView track_e_course_accessDataGridView;
        private System.Windows.Forms.TextBox txtSumaHoras;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModifLecciones;
        private System.Windows.Forms.Button BtnLeccionesNew;
        private System.Windows.Forms.Button btnInOut;
        private System.Windows.Forms.Button btnCompleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_access_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnEjercicios;
        private System.Windows.Forms.Button btnMensajes;
    }
}
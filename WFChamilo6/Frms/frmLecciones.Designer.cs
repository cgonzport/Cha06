﻿namespace WFChamilo6.Frms
{
    partial class frmLecciones
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
            this.leccionesCursoUsrDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leccionesCursoUsrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chamiloDataSet = new WFChamilo6.chamiloDataSet();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.c_lp_item_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_lp_item_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdLeccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLeccion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtFechaHora = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.chkCompletado = new System.Windows.Forms.CheckBox();
            this.Actividad = new System.Windows.Forms.Label();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTiempoLec = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuardaAuto = new System.Windows.Forms.Button();
            this.txtSegAuto = new System.Windows.Forms.TextBox();
            this.leccionesCursoUsrTableAdapter = new WFChamilo6.chamiloDataSetTableAdapters.LeccionesCursoUsrTableAdapter();
            this.tableAdapterManager = new WFChamilo6.chamiloDataSetTableAdapters.TableAdapterManager();
            this.c_lp_item_viewTableAdapter = new WFChamilo6.chamiloDataSetTableAdapters.c_lp_item_viewTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leccionesCursoUsrDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leccionesCursoUsrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamiloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_lp_item_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_lp_item_viewBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leccionesCursoUsrDataGridView
            // 
            this.leccionesCursoUsrDataGridView.AllowUserToAddRows = false;
            this.leccionesCursoUsrDataGridView.AllowUserToDeleteRows = false;
            this.leccionesCursoUsrDataGridView.AutoGenerateColumns = false;
            this.leccionesCursoUsrDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leccionesCursoUsrDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7});
            this.leccionesCursoUsrDataGridView.DataSource = this.leccionesCursoUsrBindingSource;
            this.leccionesCursoUsrDataGridView.Location = new System.Drawing.Point(12, 66);
            this.leccionesCursoUsrDataGridView.MultiSelect = false;
            this.leccionesCursoUsrDataGridView.Name = "leccionesCursoUsrDataGridView";
            this.leccionesCursoUsrDataGridView.ReadOnly = true;
            this.leccionesCursoUsrDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.leccionesCursoUsrDataGridView.Size = new System.Drawing.Size(605, 226);
            this.leccionesCursoUsrDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "iid";
            this.dataGridViewTextBoxColumn1.HeaderText = "iid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "c_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "c_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn3.HeaderText = "title";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 140;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "user_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn6.HeaderText = "username";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn4.HeaderText = "name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "progress";
            this.dataGridViewTextBoxColumn7.HeaderText = "progress";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // leccionesCursoUsrBindingSource
            // 
            this.leccionesCursoUsrBindingSource.DataMember = "LeccionesCursoUsr";
            this.leccionesCursoUsrBindingSource.DataSource = this.chamiloDataSet;
            // 
            // chamiloDataSet
            // 
            this.chamiloDataSet.DataSetName = "chamiloDataSet";
            this.chamiloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(82, 31);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(137, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(235, 31);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(155, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(12, 31);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(54, 20);
            this.txtIdUsuario.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido";
            // 
            // c_lp_item_viewDataGridView
            // 
            this.c_lp_item_viewDataGridView.AllowUserToAddRows = false;
            this.c_lp_item_viewDataGridView.AllowUserToDeleteRows = false;
            this.c_lp_item_viewDataGridView.AllowUserToResizeRows = false;
            this.c_lp_item_viewDataGridView.AutoGenerateColumns = false;
            this.c_lp_item_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.c_lp_item_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.start_time});
            this.c_lp_item_viewDataGridView.DataSource = this.c_lp_item_viewBindingSource;
            this.c_lp_item_viewDataGridView.Location = new System.Drawing.Point(12, 316);
            this.c_lp_item_viewDataGridView.MultiSelect = false;
            this.c_lp_item_viewDataGridView.Name = "c_lp_item_viewDataGridView";
            this.c_lp_item_viewDataGridView.ReadOnly = true;
            this.c_lp_item_viewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.c_lp_item_viewDataGridView.Size = new System.Drawing.Size(657, 289);
            this.c_lp_item_viewDataGridView.TabIndex = 18;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "lp_view_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "lp_view_id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "total_time";
            this.dataGridViewTextBoxColumn9.HeaderText = "total_time";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 75;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn10.HeaderText = "status";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "lp_item_id";
            this.dataGridViewTextBoxColumn12.HeaderText = "lp_item_id";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 60;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn13.HeaderText = "title";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 180;
            // 
            // start_time
            // 
            this.start_time.DataPropertyName = "start_time";
            this.start_time.HeaderText = "start_time";
            this.start_time.Name = "start_time";
            this.start_time.ReadOnly = true;
            // 
            // c_lp_item_viewBindingSource
            // 
            this.c_lp_item_viewBindingSource.DataMember = "c_lp_item_view";
            this.c_lp_item_viewBindingSource.DataSource = this.chamiloDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "IdLeccion";
            // 
            // txtIdLeccion
            // 
            this.txtIdLeccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leccionesCursoUsrBindingSource, "iid", true));
            this.txtIdLeccion.Location = new System.Drawing.Point(406, 31);
            this.txtIdLeccion.Name = "txtIdLeccion";
            this.txtIdLeccion.ReadOnly = true;
            this.txtIdLeccion.Size = new System.Drawing.Size(40, 20);
            this.txtIdLeccion.TabIndex = 20;
            this.txtIdLeccion.TextChanged += new System.EventHandler(this.txtIdLeccion_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Leccion";
            // 
            // txtLeccion
            // 
            this.txtLeccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leccionesCursoUsrBindingSource, "name", true));
            this.txtLeccion.Location = new System.Drawing.Point(462, 31);
            this.txtLeccion.Name = "txtLeccion";
            this.txtLeccion.ReadOnly = true;
            this.txtLeccion.Size = new System.Drawing.Size(155, 20);
            this.txtLeccion.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtFechaHora);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtHoras);
            this.groupBox1.Controls.Add(this.chkCompletado);
            this.groupBox1.Controls.Add(this.Actividad);
            this.groupBox1.Controls.Add(this.txtActividad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTiempo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtItemId);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(675, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 213);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificacion Individual";
            // 
            // TxtFechaHora
            // 
            this.TxtFechaHora.Location = new System.Drawing.Point(69, 126);
            this.TxtFechaHora.Name = "TxtFechaHora";
            this.TxtFechaHora.ReadOnly = true;
            this.TxtFechaHora.Size = new System.Drawing.Size(231, 20);
            this.TxtFechaHora.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Fecha";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(158, 44);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.ReadOnly = true;
            this.txtHoras.Size = new System.Drawing.Size(77, 20);
            this.txtHoras.TabIndex = 31;
            // 
            // chkCompletado
            // 
            this.chkCompletado.AutoSize = true;
            this.chkCompletado.Location = new System.Drawing.Point(241, 73);
            this.chkCompletado.Name = "chkCompletado";
            this.chkCompletado.Size = new System.Drawing.Size(82, 17);
            this.chkCompletado.TabIndex = 29;
            this.chkCompletado.Text = "Completado";
            this.chkCompletado.UseVisualStyleBackColor = true;
            this.chkCompletado.CheckedChanged += new System.EventHandler(this.chkCompletado_CheckedChanged);
            // 
            // Actividad
            // 
            this.Actividad.AutoSize = true;
            this.Actividad.Location = new System.Drawing.Point(15, 100);
            this.Actividad.Name = "Actividad";
            this.Actividad.Size = new System.Drawing.Size(51, 13);
            this.Actividad.TabIndex = 28;
            this.Actividad.Text = "Actividad";
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(69, 96);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.ReadOnly = true;
            this.txtActividad.Size = new System.Drawing.Size(231, 20);
            this.txtActividad.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Estatus";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(69, 70);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(166, 20);
            this.txtStatus.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tiempo";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(69, 44);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(83, 20);
            this.txtTiempo.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "ID";
            // 
            // txtItemId
            // 
            this.txtItemId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.c_lp_item_viewBindingSource, "id", true));
            this.txtItemId.Location = new System.Drawing.Point(69, 18);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.ReadOnly = true;
            this.txtItemId.Size = new System.Drawing.Size(63, 20);
            this.txtItemId.TabIndex = 21;
            this.txtItemId.TextChanged += new System.EventHandler(this.txtItemId_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(69, 177);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(231, 30);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTiempoLec
            // 
            this.txtTiempoLec.Location = new System.Drawing.Point(632, 31);
            this.txtTiempoLec.Name = "txtTiempoLec";
            this.txtTiempoLec.ReadOnly = true;
            this.txtTiempoLec.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoLec.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(629, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Tiempo Lección";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnGuardaAuto);
            this.groupBox2.Controls.Add(this.txtSegAuto);
            this.groupBox2.Location = new System.Drawing.Point(675, 535);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 70);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificacion Automática";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Segundos Auto";
            // 
            // btnGuardaAuto
            // 
            this.btnGuardaAuto.Location = new System.Drawing.Point(184, 43);
            this.btnGuardaAuto.Name = "btnGuardaAuto";
            this.btnGuardaAuto.Size = new System.Drawing.Size(109, 20);
            this.btnGuardaAuto.TabIndex = 37;
            this.btnGuardaAuto.Text = "Completa Todos";
            this.btnGuardaAuto.UseVisualStyleBackColor = true;
            this.btnGuardaAuto.Click += new System.EventHandler(this.btnGuardaAuto_Click);
            // 
            // txtSegAuto
            // 
            this.txtSegAuto.Location = new System.Drawing.Point(25, 44);
            this.txtSegAuto.Name = "txtSegAuto";
            this.txtSegAuto.Size = new System.Drawing.Size(100, 20);
            this.txtSegAuto.TabIndex = 36;
            // 
            // leccionesCursoUsrTableAdapter
            // 
            this.leccionesCursoUsrTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.c_lp_viewTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.course_rel_userTableAdapter = null;
            this.tableAdapterManager.courseTableAdapter = null;
            this.tableAdapterManager.track_e_course_accessTableAdapter = null;
            this.tableAdapterManager.track_e_loginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WFChamilo6.chamiloDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // c_lp_item_viewTableAdapter
            // 
            this.c_lp_item_viewTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 44);
            this.button1.TabIndex = 37;
            this.button1.Text = "Ejemplo Conversion Tiempos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 621);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTiempoLec);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLeccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdLeccion);
            this.Controls.Add(this.c_lp_item_viewDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.leccionesCursoUsrDataGridView);
            this.Name = "frmLecciones";
            this.Text = "frmLecciones";
            this.Load += new System.EventHandler(this.frmLecciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leccionesCursoUsrDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leccionesCursoUsrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamiloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_lp_item_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_lp_item_viewBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private chamiloDataSet chamiloDataSet;
        private System.Windows.Forms.BindingSource leccionesCursoUsrBindingSource;
        private chamiloDataSetTableAdapters.LeccionesCursoUsrTableAdapter leccionesCursoUsrTableAdapter;
        private chamiloDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView leccionesCursoUsrDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource c_lp_item_viewBindingSource;
        private chamiloDataSetTableAdapters.c_lp_item_viewTableAdapter c_lp_item_viewTableAdapter;
        private System.Windows.Forms.DataGridView c_lp_item_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdLeccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLeccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCompletado;
        private System.Windows.Forms.Label Actividad;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtTiempoLec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardaAuto;
        private System.Windows.Forms.TextBox txtSegAuto;
        private System.Windows.Forms.TextBox TxtFechaHora;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
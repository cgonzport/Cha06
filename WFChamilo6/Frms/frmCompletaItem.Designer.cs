namespace WFChamilo6.Frms
{
    partial class frmCompletaItem
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
            this.c_lp_item_view_totalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_lp_item_view_totalTableAdapter = new WFChamilo6.chamiloDataSetTableAdapters.c_lp_item_view_totalTableAdapter();
            this.tableAdapterManager = new WFChamilo6.chamiloDataSetTableAdapters.TableAdapterManager();
            this.c_lp_item_view_totalDataGridView = new System.Windows.Forms.DataGridView();
            this.iid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuardaAuto = new System.Windows.Forms.Button();
            this.txtSegAuto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRandom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.track_e_course_accessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.track_e_course_accessTableAdapter = new WFChamilo6.chamiloDataSetTableAdapters.track_e_course_accessTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastIid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastDate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActEjercicios = new System.Windows.Forms.Button();
            this.track_e_exercisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.track_e_exercisesTableAdapter = new WFChamilo6.chamiloDataSetTableAdapters.track_e_exercisesTableAdapter();
            this.track_e_exercisesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chamiloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_lp_item_view_totalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_lp_item_view_totalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_e_course_accessBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_e_exercisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_e_exercisesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chamiloDataSet
            // 
            this.chamiloDataSet.DataSetName = "chamiloDataSet";
            this.chamiloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c_lp_item_view_totalBindingSource
            // 
            this.c_lp_item_view_totalBindingSource.DataMember = "c_lp_item_view_total";
            this.c_lp_item_view_totalBindingSource.DataSource = this.chamiloDataSet;
            // 
            // c_lp_item_view_totalTableAdapter
            // 
            this.c_lp_item_view_totalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.c_lp_viewTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.course_rel_userTableAdapter = null;
            this.tableAdapterManager.courseTableAdapter = null;
            this.tableAdapterManager.track_e_course_accessTableAdapter = null;
            this.tableAdapterManager.track_e_exercisesTableAdapter = null;
            this.tableAdapterManager.track_e_loginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WFChamilo6.chamiloDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // c_lp_item_view_totalDataGridView
            // 
            this.c_lp_item_view_totalDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_lp_item_view_totalDataGridView.AutoGenerateColumns = false;
            this.c_lp_item_view_totalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.c_lp_item_view_totalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iid,
            this.c_id,
            this.user_id,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.c_lp_item_view_totalDataGridView.DataSource = this.c_lp_item_view_totalBindingSource;
            this.c_lp_item_view_totalDataGridView.Location = new System.Drawing.Point(12, 44);
            this.c_lp_item_view_totalDataGridView.Name = "c_lp_item_view_totalDataGridView";
            this.c_lp_item_view_totalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.c_lp_item_view_totalDataGridView.Size = new System.Drawing.Size(864, 807);
            this.c_lp_item_view_totalDataGridView.TabIndex = 1;
            // 
            // iid
            // 
            this.iid.DataPropertyName = "iid";
            this.iid.HeaderText = "iid";
            this.iid.Name = "iid";
            this.iid.Width = 40;
            // 
            // c_id
            // 
            this.c_id.DataPropertyName = "c_id";
            this.c_id.HeaderText = "c_id";
            this.c_id.Name = "c_id";
            this.c_id.Visible = false;
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "user_id";
            this.user_id.Name = "user_id";
            this.user_id.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "lp_item_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "lp_item_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "lp_view_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "lp_view_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn3.HeaderText = "status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "start_time";
            this.dataGridViewTextBoxColumn4.HeaderText = "start_time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "total_time";
            this.dataGridViewTextBoxColumn5.HeaderText = "total_time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn6.HeaderText = "name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 400;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn7.HeaderText = "title";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 400;
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.Location = new System.Drawing.Point(906, 60);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(143, 20);
            this.txtFecha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(906, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Hora";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(906, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Segundos Auto";
            // 
            // btnGuardaAuto
            // 
            this.btnGuardaAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardaAuto.Location = new System.Drawing.Point(906, 350);
            this.btnGuardaAuto.Name = "btnGuardaAuto";
            this.btnGuardaAuto.Size = new System.Drawing.Size(116, 35);
            this.btnGuardaAuto.TabIndex = 40;
            this.btnGuardaAuto.Text = "Completa Selección";
            this.btnGuardaAuto.UseVisualStyleBackColor = true;
            this.btnGuardaAuto.Click += new System.EventHandler(this.btnGuardaAuto_Click);
            // 
            // txtSegAuto
            // 
            this.txtSegAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSegAuto.Location = new System.Drawing.Point(906, 111);
            this.txtSegAuto.Name = "txtSegAuto";
            this.txtSegAuto.Size = new System.Drawing.Size(80, 20);
            this.txtSegAuto.TabIndex = 39;
            this.txtSegAuto.Text = "120";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(906, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ramdom";
            // 
            // txtRandom
            // 
            this.txtRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRandom.Location = new System.Drawing.Point(906, 162);
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.Size = new System.Drawing.Size(80, 20);
            this.txtRandom.TabIndex = 44;
            this.txtRandom.Text = "60";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(906, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "IP";
            // 
            // txtIp
            // 
            this.txtIp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIp.Location = new System.Drawing.Point(906, 213);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(80, 20);
            this.txtIp.TabIndex = 46;
            this.txtIp.Text = "255.255.255.0";
            // 
            // track_e_course_accessBindingSource
            // 
            this.track_e_course_accessBindingSource.DataMember = "track_e_course_access";
            this.track_e_course_accessBindingSource.DataSource = this.chamiloDataSet;
            // 
            // track_e_course_accessTableAdapter
            // 
            this.track_e_course_accessTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(906, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Último iid Seleccionado";
            // 
            // txtLastIid
            // 
            this.txtLastIid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastIid.Location = new System.Drawing.Point(906, 264);
            this.txtLastIid.Name = "txtLastIid";
            this.txtLastIid.ReadOnly = true;
            this.txtLastIid.Size = new System.Drawing.Size(62, 20);
            this.txtLastIid.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(906, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Última Fecha/Hora Usada";
            // 
            // txtLastDate
            // 
            this.txtLastDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastDate.Location = new System.Drawing.Point(906, 315);
            this.txtLastDate.Name = "txtLastDate";
            this.txtLastDate.ReadOnly = true;
            this.txtLastDate.Size = new System.Drawing.Size(143, 20);
            this.txtLastDate.TabIndex = 52;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.track_e_exercisesDataGridView);
            this.groupBox1.Controls.Add(this.btnActEjercicios);
            this.groupBox1.Location = new System.Drawing.Point(897, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 205);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ejercicios";
            // 
            // btnActEjercicios
            // 
            this.btnActEjercicios.Location = new System.Drawing.Point(256, 39);
            this.btnActEjercicios.Name = "btnActEjercicios";
            this.btnActEjercicios.Size = new System.Drawing.Size(99, 38);
            this.btnActEjercicios.TabIndex = 1;
            this.btnActEjercicios.Text = "Act. Ejercicios";
            this.btnActEjercicios.UseVisualStyleBackColor = true;
            this.btnActEjercicios.Click += new System.EventHandler(this.button1_Click);
            // 
            // track_e_exercisesBindingSource
            // 
            this.track_e_exercisesBindingSource.DataMember = "track_e_exercises";
            this.track_e_exercisesBindingSource.DataSource = this.chamiloDataSet;
            // 
            // track_e_exercisesTableAdapter
            // 
            this.track_e_exercisesTableAdapter.ClearBeforeFill = true;
            // 
            // track_e_exercisesDataGridView
            // 
            this.track_e_exercisesDataGridView.AutoGenerateColumns = false;
            this.track_e_exercisesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.track_e_exercisesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            this.track_e_exercisesDataGridView.DataSource = this.track_e_exercisesBindingSource;
            this.track_e_exercisesDataGridView.Location = new System.Drawing.Point(6, 39);
            this.track_e_exercisesDataGridView.Name = "track_e_exercisesDataGridView";
            this.track_e_exercisesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.track_e_exercisesDataGridView.Size = new System.Drawing.Size(244, 148);
            this.track_e_exercisesDataGridView.TabIndex = 53;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "exe_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "exe_id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "exe_user_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "exe_user_id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "c_id";
            this.dataGridViewTextBoxColumn10.HeaderText = "c_id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "orig_lp_id";
            this.dataGridViewTextBoxColumn11.HeaderText = "orig_lp_id";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "orig_lp_item_id";
            this.dataGridViewTextBoxColumn12.HeaderText = "orig_lp_item_id";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "orig_lp_item_view_id";
            this.dataGridViewTextBoxColumn13.HeaderText = "orig_lp_item_view_id";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "user_ip";
            this.dataGridViewTextBoxColumn14.HeaderText = "user_ip";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "start_date";
            this.dataGridViewTextBoxColumn15.HeaderText = "start_date";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "exe_date";
            this.dataGridViewTextBoxColumn16.HeaderText = "exe_date";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "exe_exo_id";
            this.dataGridViewTextBoxColumn17.HeaderText = "exe_exo_id";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "exe_result";
            this.dataGridViewTextBoxColumn18.HeaderText = "exe_result";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "exe_weighting";
            this.dataGridViewTextBoxColumn19.HeaderText = "exe_weighting";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn20.HeaderText = "status";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "data_tracking";
            this.dataGridViewTextBoxColumn21.HeaderText = "data_tracking";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "session_id";
            this.dataGridViewTextBoxColumn22.HeaderText = "session_id";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "exe_duration";
            this.dataGridViewTextBoxColumn23.HeaderText = "exe_duration";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // frmCompletaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 868);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLastDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastIid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRandom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGuardaAuto);
            this.Controls.Add(this.txtSegAuto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.c_lp_item_view_totalDataGridView);
            this.Name = "frmCompletaItem";
            this.Text = "frmCompletaItem";
            this.Load += new System.EventHandler(this.frmCompletaItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chamiloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_lp_item_view_totalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_lp_item_view_totalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_e_course_accessBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.track_e_exercisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_e_exercisesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private chamiloDataSet chamiloDataSet;
        private System.Windows.Forms.BindingSource c_lp_item_view_totalBindingSource;
        private chamiloDataSetTableAdapters.c_lp_item_view_totalTableAdapter c_lp_item_view_totalTableAdapter;
        private chamiloDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView c_lp_item_view_totalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iid;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardaAuto;
        private System.Windows.Forms.TextBox txtSegAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRandom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.BindingSource track_e_course_accessBindingSource;
        private chamiloDataSetTableAdapters.track_e_course_accessTableAdapter track_e_course_accessTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastIid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource track_e_exercisesBindingSource;
        private chamiloDataSetTableAdapters.track_e_exercisesTableAdapter track_e_exercisesTableAdapter;
        private System.Windows.Forms.DataGridView track_e_exercisesDataGridView;
        private System.Windows.Forms.Button btnActEjercicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
    }
}
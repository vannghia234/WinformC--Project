namespace formLogin
{
    partial class formTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAcounts = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFix = new CustomControls.RJControls.RJButton();
            this.btnSave = new CustomControls.RJControls.RJButton();
            this.btnRefresh = new CustomControls.RJControls.RJButton();
            this.btn_Delete = new CustomControls.RJControls.RJButton();
            this.btn_Add = new CustomControls.RJControls.RJButton();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlNhap = new System.Windows.Forms.Panel();
            this.ckbPass = new System.Windows.Forms.CheckBox();
            this.cmbMaLoai = new System.Windows.Forms.ComboBox();
            this.lOAITAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLY_BEAUTY_HEALTHDataSet3 = new formLogin.QUANLY_BEAUTY_HEALTHDataSet3();
            this.lbShowText = new System.Windows.Forms.Label();
            this.lb_DiaChi_KH = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lb_Ten_KH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Ma_KH = new System.Windows.Forms.Label();
            this.lb_DienThoai_KH = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_AccountsID = new System.Windows.Forms.TextBox();
            this.txt_AccountName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.btn_Search = new CustomControls.RJControls.RJButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.qUANLY_BEAUTY_HEALTHDataSet1 = new formLogin.QUANLY_BEAUTY_HEALTHDataSet1();
            this.tAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOANTableAdapter = new formLogin.QUANLY_BEAUTY_HEALTHDataSet1TableAdapters.TAIKHOANTableAdapter();
            this.qUANLY_BEAUTY_HEALTHDataSet2 = new formLogin.QUANLY_BEAUTY_HEALTHDataSet2();
            this.tAIKHOANBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOANTableAdapter1 = new formLogin.QUANLY_BEAUTY_HEALTHDataSet2TableAdapters.TAIKHOANTableAdapter();
            this.lOAITAIKHOANTableAdapter = new formLogin.QUANLY_BEAUTY_HEALTHDataSet3TableAdapters.LOAITAIKHOANTableAdapter();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcounts)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAITAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_BEAUTY_HEALTHDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_BEAUTY_HEALTHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_BEAUTY_HEALTHDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAcounts
            // 
            this.dgvAcounts.AllowUserToAddRows = false;
            this.dgvAcounts.AllowUserToDeleteRows = false;
            this.dgvAcounts.AllowUserToResizeColumns = false;
            this.dgvAcounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.dgvAcounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAcounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAcounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvAcounts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAcounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAcounts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvAcounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAcounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAcounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAcounts.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAcounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.dgvAcounts.Location = new System.Drawing.Point(13, 100);
            this.dgvAcounts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAcounts.Name = "dgvAcounts";
            this.dgvAcounts.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAcounts.RowHeadersVisible = false;
            this.dgvAcounts.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAcounts.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAcounts.RowTemplate.Height = 24;
            this.dgvAcounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcounts.Size = new System.Drawing.Size(865, 740);
            this.dgvAcounts.TabIndex = 42;
            this.dgvAcounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcounts_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btnFix);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btn_Delete);
            this.panel3.Controls.Add(this.btn_Add);
            this.panel3.Location = new System.Drawing.Point(897, 526);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(601, 364);
            this.panel3.TabIndex = 41;
            // 
            // btnFix
            // 
            this.btnFix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.btnFix.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.btnFix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFix.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFix.BorderRadius = 19;
            this.btnFix.BorderSize = 0;
            this.btnFix.Enabled = false;
            this.btnFix.FlatAppearance.BorderSize = 0;
            this.btnFix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.btnFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFix.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.ForeColor = System.Drawing.Color.White;
            this.btnFix.Image = global::formLogin.Properties.Resources.icons8_uninstalling_updates_30;
            this.btnFix.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFix.Location = new System.Drawing.Point(49, 184);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(191, 45);
            this.btnFix.TabIndex = 56;
            this.btnFix.Text = "Update";
            this.btnFix.TextColor = System.Drawing.Color.White;
            this.btnFix.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFix.UseVisualStyleBackColor = false;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 19;
            this.btnSave.BorderSize = 0;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::formLogin.Properties.Resources.icons8_save_301;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(201, 122);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 45);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.btnRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRefresh.BorderRadius = 19;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::formLogin.Properties.Resources.icons8_refresh_322;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(359, 184);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(191, 45);
            this.btnRefresh.TabIndex = 55;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.btn_Delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Delete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Delete.BorderRadius = 19;
            this.btn_Delete.BorderSize = 0;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Image = global::formLogin.Properties.Resources.icons8_delete_30;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.Location = new System.Drawing.Point(49, 67);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(191, 45);
            this.btn_Delete.TabIndex = 53;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextColor = System.Drawing.Color.White;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.btn_Add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Add.BorderRadius = 19;
            this.btn_Add.BorderSize = 0;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = global::formLogin.Properties.Resources.icons8_add_302;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.Location = new System.Drawing.Point(359, 67);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(191, 45);
            this.btn_Add.TabIndex = 52;
            this.btn_Add.Tag = "";
            this.btn_Add.Text = "Add";
            this.btn_Add.TextColor = System.Drawing.Color.White;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl1.Controls.Add(this.panel5);
            this.pnl1.Controls.Add(this.pnlNhap);
            this.pnl1.Location = new System.Drawing.Point(897, 35);
            this.pnl1.Margin = new System.Windows.Forms.Padding(4);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(601, 471);
            this.pnl1.TabIndex = 40;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.panel5.Controls.Add(this.iconPictureBox2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(601, 37);
            this.panel5.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tài Khoản";
            // 
            // pnlNhap
            // 
            this.pnlNhap.AccessibleName = "";
            this.pnlNhap.BackColor = System.Drawing.Color.White;
            this.pnlNhap.Controls.Add(this.ckbPass);
            this.pnlNhap.Controls.Add(this.cmbMaLoai);
            this.pnlNhap.Controls.Add(this.lbShowText);
            this.pnlNhap.Controls.Add(this.lb_DiaChi_KH);
            this.pnlNhap.Controls.Add(this.txtEmail);
            this.pnlNhap.Controls.Add(this.lb_Ten_KH);
            this.pnlNhap.Controls.Add(this.label1);
            this.pnlNhap.Controls.Add(this.lb_Ma_KH);
            this.pnlNhap.Controls.Add(this.lb_DienThoai_KH);
            this.pnlNhap.Controls.Add(this.txt_Password);
            this.pnlNhap.Controls.Add(this.txt_AccountsID);
            this.pnlNhap.Controls.Add(this.txt_AccountName);
            this.pnlNhap.Location = new System.Drawing.Point(19, 58);
            this.pnlNhap.Name = "pnlNhap";
            this.pnlNhap.Size = new System.Drawing.Size(569, 382);
            this.pnlNhap.TabIndex = 44;
            this.pnlNhap.Click += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // ckbPass
            // 
            this.ckbPass.AutoSize = true;
            this.ckbPass.Location = new System.Drawing.Point(225, 121);
            this.ckbPass.Name = "ckbPass";
            this.ckbPass.Size = new System.Drawing.Size(18, 17);
            this.ckbPass.TabIndex = 25;
            this.ckbPass.UseVisualStyleBackColor = true;
            this.ckbPass.CheckedChanged += new System.EventHandler(this.ckbPass_CheckedChanged);
            // 
            // cmbMaLoai
            // 
            this.cmbMaLoai.DataSource = this.lOAITAIKHOANBindingSource;
            this.cmbMaLoai.DisplayMember = "MALOAI";
            this.cmbMaLoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaLoai.FormattingEnabled = true;
            this.cmbMaLoai.Location = new System.Drawing.Point(225, 280);
            this.cmbMaLoai.Name = "cmbMaLoai";
            this.cmbMaLoai.Size = new System.Drawing.Size(288, 31);
            this.cmbMaLoai.TabIndex = 24;
            // 
            // lOAITAIKHOANBindingSource
            // 
            this.lOAITAIKHOANBindingSource.DataMember = "LOAITAIKHOAN";
            this.lOAITAIKHOANBindingSource.DataSource = this.qUANLY_BEAUTY_HEALTHDataSet3;
            // 
            // qUANLY_BEAUTY_HEALTHDataSet3
            // 
            this.qUANLY_BEAUTY_HEALTHDataSet3.DataSetName = "QUANLY_BEAUTY_HEALTHDataSet3";
            this.qUANLY_BEAUTY_HEALTHDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbShowText
            // 
            this.lbShowText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbShowText.AutoSize = true;
            this.lbShowText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowText.Location = new System.Drawing.Point(305, 113);
            this.lbShowText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShowText.Name = "lbShowText";
            this.lbShowText.Size = new System.Drawing.Size(0, 23);
            this.lbShowText.TabIndex = 23;
            // 
            // lb_DiaChi_KH
            // 
            this.lb_DiaChi_KH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_DiaChi_KH.AutoSize = true;
            this.lb_DiaChi_KH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi_KH.Location = new System.Drawing.Point(66, 217);
            this.lb_DiaChi_KH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DiaChi_KH.Name = "lb_DiaChi_KH";
            this.lb_DiaChi_KH.Size = new System.Drawing.Size(115, 23);
            this.lb_DiaChi_KH.TabIndex = 14;
            this.lb_DiaChi_KH.Text = "Tên Tài Khoản";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(225, 152);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 30);
            this.txtEmail.TabIndex = 22;
            // 
            // lb_Ten_KH
            // 
            this.lb_Ten_KH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Ten_KH.AutoSize = true;
            this.lb_Ten_KH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ten_KH.Location = new System.Drawing.Point(66, 84);
            this.lb_Ten_KH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Ten_KH.Name = "lb_Ten_KH";
            this.lb_Ten_KH.Size = new System.Drawing.Size(84, 23);
            this.lb_Ten_KH.TabIndex = 13;
            this.lb_Ten_KH.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Email";
            // 
            // lb_Ma_KH
            // 
            this.lb_Ma_KH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Ma_KH.AutoSize = true;
            this.lb_Ma_KH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ma_KH.Location = new System.Drawing.Point(66, 19);
            this.lb_Ma_KH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Ma_KH.Name = "lb_Ma_KH";
            this.lb_Ma_KH.Size = new System.Drawing.Size(84, 23);
            this.lb_Ma_KH.TabIndex = 12;
            this.lb_Ma_KH.Text = "Tài Khoản";
            // 
            // lb_DienThoai_KH
            // 
            this.lb_DienThoai_KH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_DienThoai_KH.AutoSize = true;
            this.lb_DienThoai_KH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DienThoai_KH.Location = new System.Drawing.Point(66, 288);
            this.lb_DienThoai_KH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DienThoai_KH.Name = "lb_DienThoai_KH";
            this.lb_DienThoai_KH.Size = new System.Drawing.Size(70, 23);
            this.lb_DienThoai_KH.TabIndex = 15;
            this.lb_DienThoai_KH.Text = "Mã Loại";
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(225, 84);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(288, 30);
            this.txt_Password.TabIndex = 16;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // txt_AccountsID
            // 
            this.txt_AccountsID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_AccountsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AccountsID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccountsID.Location = new System.Drawing.Point(225, 19);
            this.txt_AccountsID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AccountsID.Name = "txt_AccountsID";
            this.txt_AccountsID.Size = new System.Drawing.Size(288, 30);
            this.txt_AccountsID.TabIndex = 19;
            // 
            // txt_AccountName
            // 
            this.txt_AccountName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_AccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AccountName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccountName.Location = new System.Drawing.Point(225, 217);
            this.txt_AccountName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AccountName.Name = "txt_AccountName";
            this.txt_AccountName.Size = new System.Drawing.Size(288, 30);
            this.txt_AccountName.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.panel4.Location = new System.Drawing.Point(897, 503);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(601, 26);
            this.panel4.TabIndex = 43;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.rjButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 19;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.rjButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Image = global::formLogin.Properties.Resources.icons8_refresh_30;
            this.rjButton2.Location = new System.Drawing.Point(7, 32);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(53, 37);
            this.rjButton2.TabIndex = 48;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.AutoSize = true;
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.btn_Search.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.btn_Search.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Search.BorderRadius = 19;
            this.btn_Search.BorderSize = 0;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(721, 32);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(156, 34);
            this.btn_Search.TabIndex = 47;
            this.btn_Search.Text = "Search Products";
            this.btn_Search.TextColor = System.Drawing.Color.White;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.Black;
            this.txt_Search.Location = new System.Drawing.Point(271, 35);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(444, 34);
            this.txt_Search.TabIndex = 46;
            // 
            // qUANLY_BEAUTY_HEALTHDataSet1
            // 
            this.qUANLY_BEAUTY_HEALTHDataSet1.DataSetName = "QUANLY_BEAUTY_HEALTHDataSet1";
            this.qUANLY_BEAUTY_HEALTHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAIKHOANBindingSource
            // 
            this.tAIKHOANBindingSource.DataMember = "TAIKHOAN";
            this.tAIKHOANBindingSource.DataSource = this.qUANLY_BEAUTY_HEALTHDataSet1;
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // qUANLY_BEAUTY_HEALTHDataSet2
            // 
            this.qUANLY_BEAUTY_HEALTHDataSet2.DataSetName = "QUANLY_BEAUTY_HEALTHDataSet2";
            this.qUANLY_BEAUTY_HEALTHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAIKHOANBindingSource1
            // 
            this.tAIKHOANBindingSource1.DataMember = "TAIKHOAN";
            this.tAIKHOANBindingSource1.DataSource = this.qUANLY_BEAUTY_HEALTHDataSet2;
            // 
            // tAIKHOANTableAdapter1
            // 
            this.tAIKHOANTableAdapter1.ClearBeforeFill = true;
            // 
            // lOAITAIKHOANTableAdapter
            // 
            this.lOAITAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 38;
            this.iconPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(47, 38);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox2.TabIndex = 20;
            this.iconPictureBox2.TabStop = false;
            // 
            // formTaiKhoan
            // 
            this.AcceptButton = this.btn_Search;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1497, 896);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvAcounts);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTaiKhoan";
            this.Load += new System.EventHandler(this.formTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcounts)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlNhap.ResumeLayout(false);
            this.pnlNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAITAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_BEAUTY_HEALTHDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_BEAUTY_HEALTHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_BEAUTY_HEALTHDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAcounts;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lb_DiaChi_KH;
        private System.Windows.Forms.TextBox txt_AccountsID;
        private System.Windows.Forms.TextBox txt_AccountName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lb_DienThoai_KH;
        private System.Windows.Forms.Label lb_Ma_KH;
        private System.Windows.Forms.Label lb_Ten_KH;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbShowText;
        private CustomControls.RJControls.RJButton btnFix;
        private CustomControls.RJControls.RJButton btnRefresh;
        private CustomControls.RJControls.RJButton btnSave;
        private CustomControls.RJControls.RJButton btn_Add;
        private CustomControls.RJControls.RJButton btn_Delete;
        private System.Windows.Forms.Panel pnlNhap;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cmbMaLoai;
        private formLogin.QUANLY_BEAUTY_HEALTHDataSet1 qUANLY_BEAUTY_HEALTHDataSet1;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
        private formLogin.QUANLY_BEAUTY_HEALTHDataSet1TableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private formLogin.QUANLY_BEAUTY_HEALTHDataSet2 qUANLY_BEAUTY_HEALTHDataSet2;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource1;
        private formLogin.QUANLY_BEAUTY_HEALTHDataSet2TableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter1;
        private formLogin.QUANLY_BEAUTY_HEALTHDataSet3 qUANLY_BEAUTY_HEALTHDataSet3;
        private System.Windows.Forms.BindingSource lOAITAIKHOANBindingSource;
        private formLogin.QUANLY_BEAUTY_HEALTHDataSet3TableAdapters.LOAITAIKHOANTableAdapter lOAITAIKHOANTableAdapter;
        private System.Windows.Forms.CheckBox ckbPass;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}
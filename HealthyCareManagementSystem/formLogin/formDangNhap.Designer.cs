namespace formLogin
{
    partial class formDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.lbl_QuenPass = new System.Windows.Forms.Label();
            this.iconPic_Hide = new FontAwesome.Sharp.IconPictureBox();
            this.iconPic_Exit = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_ErrorPass = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.cb_SavePassword = new System.Windows.Forms.CheckBox();
            this.cb_ShowPass = new System.Windows.Forms.CheckBox();
            this.btn_Login = new CustomControls.RJControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 618);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUẢN LÝ BÁN HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHẦN MỀM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(930, 618);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.txt_Password);
            this.panel2.Controls.Add(this.txt_Account);
            this.panel2.Controls.Add(this.lbl_QuenPass);
            this.panel2.Controls.Add(this.iconPic_Hide);
            this.panel2.Controls.Add(this.iconPic_Exit);
            this.panel2.Controls.Add(this.lbl_ErrorPass);
            this.panel2.Controls.Add(this.lbl_Error);
            this.panel2.Controls.Add(this.cb_SavePassword);
            this.panel2.Controls.Add(this.cb_ShowPass);
            this.panel2.Controls.Add(this.btn_Login);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(887, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 618);
            this.panel2.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_Password.Location = new System.Drawing.Point(39, 275);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(414, 34);
            this.txt_Password.TabIndex = 47;
            this.txt_Password.Text = "Mật khẩu";
            this.txt_Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbpassword_MouseClick);
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // txt_Account
            // 
            this.txt_Account.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Account.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_Account.Location = new System.Drawing.Point(39, 206);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(414, 34);
            this.txt_Account.TabIndex = 46;
            this.txt_Account.Text = "Tài khoản";
            this.txt_Account.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbAccount_MouseClick);
            this.txt_Account.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAccount_KeyDown);
            // 
            // lbl_QuenPass
            // 
            this.lbl_QuenPass.AutoSize = true;
            this.lbl_QuenPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuenPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.lbl_QuenPass.Location = new System.Drawing.Point(317, 464);
            this.lbl_QuenPass.Name = "lbl_QuenPass";
            this.lbl_QuenPass.Size = new System.Drawing.Size(143, 20);
            this.lbl_QuenPass.TabIndex = 45;
            this.lbl_QuenPass.Text = "QUÊN MẬT KHẨU?";
            this.lbl_QuenPass.Click += new System.EventHandler(this.lbl_QuenPass_Click);
            // 
            // iconPic_Hide
            // 
            this.iconPic_Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.iconPic_Hide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPic_Hide.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPic_Hide.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPic_Hide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPic_Hide.Location = new System.Drawing.Point(452, 3);
            this.iconPic_Hide.Name = "iconPic_Hide";
            this.iconPic_Hide.Size = new System.Drawing.Size(32, 32);
            this.iconPic_Hide.TabIndex = 44;
            this.iconPic_Hide.TabStop = false;
            this.iconPic_Hide.Click += new System.EventHandler(this.iconPic_Hide_Click);
            // 
            // iconPic_Exit
            // 
            this.iconPic_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.iconPic_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPic_Exit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconPic_Exit.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPic_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPic_Exit.Location = new System.Drawing.Point(490, 3);
            this.iconPic_Exit.Name = "iconPic_Exit";
            this.iconPic_Exit.Size = new System.Drawing.Size(32, 32);
            this.iconPic_Exit.TabIndex = 43;
            this.iconPic_Exit.TabStop = false;
            this.iconPic_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // lbl_ErrorPass
            // 
            this.lbl_ErrorPass.AutoSize = true;
            this.lbl_ErrorPass.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbl_ErrorPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.lbl_ErrorPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorPass.Location = new System.Drawing.Point(35, 312);
            this.lbl_ErrorPass.Name = "lbl_ErrorPass";
            this.lbl_ErrorPass.Size = new System.Drawing.Size(0, 19);
            this.lbl_ErrorPass.TabIndex = 40;
            this.lbl_ErrorPass.Visible = false;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.lbl_Error.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbl_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.lbl_Error.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Error.Location = new System.Drawing.Point(35, 243);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 19);
            this.lbl_Error.TabIndex = 42;
            this.lbl_Error.Visible = false;
            // 
            // cb_SavePassword
            // 
            this.cb_SavePassword.AutoSize = true;
            this.cb_SavePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cb_SavePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.cb_SavePassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_SavePassword.Location = new System.Drawing.Point(329, 340);
            this.cb_SavePassword.Name = "cb_SavePassword";
            this.cb_SavePassword.Size = new System.Drawing.Size(130, 24);
            this.cb_SavePassword.TabIndex = 38;
            this.cb_SavePassword.Text = "Lưu đăng nhập";
            this.cb_SavePassword.UseVisualStyleBackColor = true;
            this.cb_SavePassword.CheckedChanged += new System.EventHandler(this.cb_SavePassword_CheckedChanged);
            // 
            // cb_ShowPass
            // 
            this.cb_ShowPass.AutoSize = true;
            this.cb_ShowPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ShowPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.cb_ShowPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_ShowPass.Location = new System.Drawing.Point(38, 340);
            this.cb_ShowPass.Name = "cb_ShowPass";
            this.cb_ShowPass.Size = new System.Drawing.Size(148, 24);
            this.cb_ShowPass.TabIndex = 37;
            this.cb_ShowPass.Text = "Hiển thị mật khẩu";
            this.cb_ShowPass.UseVisualStyleBackColor = true;
            this.cb_ShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.btn_Login.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.btn_Login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.btn_Login.BorderRadius = 25;
            this.btn_Login.BorderSize = 0;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(39, 382);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(421, 66);
            this.btn_Login.TabIndex = 32;
            this.btn_Login.Text = "ĐĂNG NHẬP";
            this.btn_Login.TextColor = System.Drawing.Color.White;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(32, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "TRỞ LẠI VỚI HEALTHY CARE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(31, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "CHÀO MỪNG";
            // 
            // formDangNhap
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1412, 618);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formDangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.formDangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton btn_Login;
        private System.Windows.Forms.CheckBox cb_SavePassword;
        private System.Windows.Forms.CheckBox cb_ShowPass;
        private System.Windows.Forms.Label lbl_ErrorPass;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Label lbl_QuenPass;
        private FontAwesome.Sharp.IconPictureBox iconPic_Hide;
        private FontAwesome.Sharp.IconPictureBox iconPic_Exit;
        private System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.TextBox txt_Password;
    }
}
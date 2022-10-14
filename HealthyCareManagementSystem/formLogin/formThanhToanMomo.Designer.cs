namespace formLogin
{
    partial class formThanhToanMomo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Money = new System.Windows.Forms.TextBox();
            this.bt_Payment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iconPic_Hide = new FontAwesome.Sharp.IconPictureBox();
            this.iconPic_Exit = new FontAwesome.Sharp.IconPictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(599, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 311);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(86, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Số tiền";
            // 
            // tb_Money
            // 
            this.tb_Money.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Money.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Money.Location = new System.Drawing.Point(236, 269);
            this.tb_Money.Name = "tb_Money";
            this.tb_Money.Size = new System.Drawing.Size(315, 34);
            this.tb_Money.TabIndex = 17;
            // 
            // bt_Payment
            // 
            this.bt_Payment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Payment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Payment.ForeColor = System.Drawing.Color.White;
            this.bt_Payment.Location = new System.Drawing.Point(410, 353);
            this.bt_Payment.Name = "bt_Payment";
            this.bt_Payment.Size = new System.Drawing.Size(141, 60);
            this.bt_Payment.TabIndex = 14;
            this.bt_Payment.Text = "Pay";
            this.bt_Payment.UseVisualStyleBackColor = true;
            this.bt_Payment.Click += new System.EventHandler(this.bt_Payment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên người nhận";
            // 
            // tb_Name
            // 
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(236, 205);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.ReadOnly = true;
            this.tb_Name.Size = new System.Drawing.Size(315, 34);
            this.tb_Name.TabIndex = 12;
            this.tb_Name.Text = "NGUYỄN VĂN NGHĨA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "SDT";
            // 
            // tb_SDT
            // 
            this.tb_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SDT.Enabled = false;
            this.tb_SDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SDT.Location = new System.Drawing.Point(236, 145);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.ReadOnly = true;
            this.tb_SDT.Size = new System.Drawing.Size(315, 34);
            this.tb_SDT.TabIndex = 10;
            this.tb_SDT.Text = "0378381905";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(244, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(426, 38);
            this.label4.TabIndex = 20;
            this.label4.Text = "SCAN QR CODE BELOW TO PAY";
            // 
            // iconPic_Hide
            // 
            this.iconPic_Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(112)))));
            this.iconPic_Hide.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPic_Hide.IconColor = System.Drawing.Color.White;
            this.iconPic_Hide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPic_Hide.Location = new System.Drawing.Point(887, -1);
            this.iconPic_Hide.Name = "iconPic_Hide";
            this.iconPic_Hide.Size = new System.Drawing.Size(32, 32);
            this.iconPic_Hide.TabIndex = 48;
            this.iconPic_Hide.TabStop = false;
            this.iconPic_Hide.Click += new System.EventHandler(this.iconPic_Hide_Click);
            // 
            // iconPic_Exit
            // 
            this.iconPic_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(112)))));
            this.iconPic_Exit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconPic_Exit.IconColor = System.Drawing.Color.White;
            this.iconPic_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPic_Exit.Location = new System.Drawing.Point(925, -1);
            this.iconPic_Exit.Name = "iconPic_Exit";
            this.iconPic_Exit.Size = new System.Drawing.Size(32, 32);
            this.iconPic_Exit.TabIndex = 47;
            this.iconPic_Exit.TabStop = false;
            this.iconPic_Exit.Click += new System.EventHandler(this.iconPic_Exit_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(236, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 60);
            this.button1.TabIndex = 49;
            this.button1.Text = "Confirm Payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formThanhToanMomo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(958, 602);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iconPic_Hide);
            this.Controls.Add(this.iconPic_Exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Money);
            this.Controls.Add(this.bt_Payment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_SDT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formThanhToanMomo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán Momo";
            this.Load += new System.EventHandler(this.formThanhToanMomo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Money;
        private System.Windows.Forms.Button bt_Payment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPic_Hide;
        private FontAwesome.Sharp.IconPictureBox iconPic_Exit;
        private System.Windows.Forms.Button button1;
    }
}
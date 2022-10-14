namespace formLogin
{
    partial class formLoaiThanhToan
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPic_Hide = new FontAwesome.Sharp.IconPictureBox();
            this.iconPic_Exit = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::formLogin.Properties.Resources.MoMo_Logo2;
            this.pictureBox2.Location = new System.Drawing.Point(401, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::formLogin.Properties.Resources.cash_payment_icon_5;
            this.pictureBox1.Location = new System.Drawing.Point(189, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "VUI LÒNG LỰA CHỌN HÌNH THỨC THANH TOÁN";
            // 
            // iconPic_Hide
            // 
            this.iconPic_Hide.BackColor = System.Drawing.Color.Gainsboro;
            this.iconPic_Hide.ForeColor = System.Drawing.Color.Black;
            this.iconPic_Hide.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPic_Hide.IconColor = System.Drawing.Color.Black;
            this.iconPic_Hide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPic_Hide.Location = new System.Drawing.Point(726, 2);
            this.iconPic_Hide.Name = "iconPic_Hide";
            this.iconPic_Hide.Size = new System.Drawing.Size(32, 32);
            this.iconPic_Hide.TabIndex = 46;
            this.iconPic_Hide.TabStop = false;
            this.iconPic_Hide.Click += new System.EventHandler(this.iconPic_Hide_Click);
            // 
            // iconPic_Exit
            // 
            this.iconPic_Exit.BackColor = System.Drawing.Color.Gainsboro;
            this.iconPic_Exit.ForeColor = System.Drawing.Color.Black;
            this.iconPic_Exit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconPic_Exit.IconColor = System.Drawing.Color.Black;
            this.iconPic_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPic_Exit.Location = new System.Drawing.Point(764, 2);
            this.iconPic_Exit.Name = "iconPic_Exit";
            this.iconPic_Exit.Size = new System.Drawing.Size(32, 32);
            this.iconPic_Exit.TabIndex = 45;
            this.iconPic_Exit.TabStop = false;
            this.iconPic_Exit.Click += new System.EventHandler(this.iconPic_Exit_Click);
            // 
            // formLoaiThanhToan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconPic_Hide);
            this.Controls.Add(this.iconPic_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLoaiThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formLoaiThanhToan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPic_Hide;
        private FontAwesome.Sharp.IconPictureBox iconPic_Exit;
    }
}
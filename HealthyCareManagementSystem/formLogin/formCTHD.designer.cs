using System.Windows.Forms;

namespace formLogin
{
    partial class formCTHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgv_Product = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconBtnExit = new FontAwesome.Sharp.IconPictureBox();
            this.lblKH = new System.Windows.Forms.Label();
            this.lblNV = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblHD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Product)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Product
            // 
            this.dtgv_Product.AllowUserToAddRows = false;
            this.dtgv_Product.AllowUserToDeleteRows = false;
            this.dtgv_Product.AllowUserToResizeColumns = false;
            this.dtgv_Product.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.dtgv_Product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Product.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_Product.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgv_Product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Product.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgv_Product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_Product.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_Product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.dtgv_Product.Location = new System.Drawing.Point(12, 218);
            this.dtgv_Product.Name = "dtgv_Product";
            this.dtgv_Product.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Product.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_Product.RowHeadersVisible = false;
            this.dtgv_Product.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgv_Product.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv_Product.RowTemplate.Height = 24;
            this.dtgv_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Product.Size = new System.Drawing.Size(808, 293);
            this.dtgv_Product.TabIndex = 3;
            this.dtgv_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Product_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.panel6.Controls.Add(this.iconBtnExit);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(832, 48);
            this.panel6.TabIndex = 29;
            // 
            // iconBtnExit
            // 
            this.iconBtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.iconBtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBtnExit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.iconBtnExit.IconColor = System.Drawing.Color.White;
            this.iconBtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnExit.IconSize = 48;
            this.iconBtnExit.Location = new System.Drawing.Point(776, 0);
            this.iconBtnExit.Name = "iconBtnExit";
            this.iconBtnExit.Size = new System.Drawing.Size(56, 48);
            this.iconBtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBtnExit.TabIndex = 5;
            this.iconBtnExit.TabStop = false;
            this.iconBtnExit.Click += new System.EventHandler(this.iconBtnExit_Click);
            // 
            // lblKH
            // 
            this.lblKH.AutoSize = true;
            this.lblKH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKH.Location = new System.Drawing.Point(38, 97);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(151, 25);
            this.lblKH.TabIndex = 30;
            this.lblKH.Text = "Tên khách hàng:";
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNV.Location = new System.Drawing.Point(38, 145);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(136, 25);
            this.lblNV.TabIndex = 31;
            this.lblNV.Text = "Tên nhân viên:";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.Location = new System.Drawing.Point(506, 145);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(93, 25);
            this.lblNgayLap.TabIndex = 32;
            this.lblNgayLap.Text = "Ngày lập:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(569, 514);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(108, 28);
            this.lblTongTien.TabIndex = 33;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // lblHD
            // 
            this.lblHD.AutoSize = true;
            this.lblHD.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHD.Location = new System.Drawing.Point(506, 97);
            this.lblHD.Name = "lblHD";
            this.lblHD.Size = new System.Drawing.Size(119, 25);
            this.lblHD.TabIndex = 34;
            this.lblHD.Text = "Mã hóa đơn:";
            // 
            // formCTHD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(832, 606);
            this.Controls.Add(this.lblHD);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblNgayLap);
            this.Controls.Add(this.lblNV);
            this.Controls.Add(this.lblKH);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dtgv_Product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTHD";
            this.Load += new System.EventHandler(this.CTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Product)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBtnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Product;
        private System.Windows.Forms.Label label1;
        private DataGridViewCellEventHandler dtgv_Product_CellContentClick;
        private Panel panel6;
        private FontAwesome.Sharp.IconPictureBox iconBtnExit;
        private Label lblKH;
        private Label lblNV;
        private Label lblNgayLap;
        private Label lblTongTien;
        private Label lblHD;
    }
}
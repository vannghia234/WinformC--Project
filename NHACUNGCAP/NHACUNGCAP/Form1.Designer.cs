namespace NHACUNGCAP
{
    partial class Form1
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
            this.datagridncc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnload = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmaNcc = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenNcc = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridncc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridncc
            // 
            this.datagridncc.AllowUserToAddRows = false;
            this.datagridncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridncc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridncc.Location = new System.Drawing.Point(0, 0);
            this.datagridncc.Name = "datagridncc";
            this.datagridncc.RowHeadersVisible = false;
            this.datagridncc.RowHeadersWidth = 51;
            this.datagridncc.RowTemplate.Height = 24;
            this.datagridncc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridncc.Size = new System.Drawing.Size(1684, 354);
            this.datagridncc.TabIndex = 0;
            this.datagridncc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridncc_CellClick);
            this.datagridncc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridncc_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagridncc);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1684, 354);
            this.panel1.TabIndex = 9;
            // 
            // btnload
            // 
            this.btnload.Image = global::NHACUNGCAP.Properties.Resources.icons8_reset_24;
            this.btnload.Location = new System.Drawing.Point(81, 744);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(42, 34);
            this.btnload.TabIndex = 26;
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(705, 740);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(112, 43);
            this.btntimkiem.TabIndex = 25;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.White;
            this.txt_Search.Location = new System.Drawing.Point(168, 744);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(465, 34);
            this.txt_Search.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 834);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1763, 10);
            this.panel2.TabIndex = 10;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(867, 740);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(106, 45);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(1024, 740);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(106, 45);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(1182, 740);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(106, 44);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "MANCC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 571);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Địa chỉ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(15, 360);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(318, 34);
            this.panel6.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Cập nhật thông tin nhà cung cấp";
            // 
            // txtmaNcc
            // 
            this.txtmaNcc.Location = new System.Drawing.Point(168, 416);
            this.txtmaNcc.Name = "txtmaNcc";
            this.txtmaNcc.Size = new System.Drawing.Size(465, 22);
            this.txtmaNcc.TabIndex = 20;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(168, 571);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(465, 22);
            this.txtDiachi.TabIndex = 21;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(168, 514);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(465, 22);
            this.txtSDT.TabIndex = 22;
            // 
            // txtTenNcc
            // 
            this.txtTenNcc.Location = new System.Drawing.Point(168, 459);
            this.txtTenNcc.Name = "txtTenNcc";
            this.txtTenNcc.Size = new System.Drawing.Size(465, 22);
            this.txtTenNcc.TabIndex = 23;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(1337, 740);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(106, 49);
            this.btnthoat.TabIndex = 24;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(320, 617);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(152, 74);
            this.btnlammoi.TabIndex = 25;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1763, 844);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtTenNcc);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtmaNcc);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridncc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridncc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmaNcc;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenNcc;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnlammoi;
    }
}


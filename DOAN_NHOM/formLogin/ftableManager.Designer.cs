namespace formLogin
{
    partial class ftableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ftableManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_moveTable = new System.Windows.Forms.Button();
            this.cbb_moveTable = new System.Windows.Forms.ComboBox();
            this.nm_discount = new System.Windows.Forms.NumericUpDown();
            this.btn_discount = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nm_addItems = new System.Windows.Forms.NumericUpDown();
            this.cbb_items = new System.Windows.Forms.ComboBox();
            this.btn_addItems = new System.Windows.Forms.Button();
            this.cbb_Category = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_discount)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_addItems)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1065, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_moveTable);
            this.panel2.Controls.Add(this.cbb_moveTable);
            this.panel2.Controls.Add(this.nm_discount);
            this.panel2.Controls.Add(this.btn_discount);
            this.panel2.Controls.Add(this.btn_pay);
            this.panel2.Location = new System.Drawing.Point(533, 416);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 100);
            this.panel2.TabIndex = 2;
            // 
            // btn_moveTable
            // 
            this.btn_moveTable.AutoSize = true;
            this.btn_moveTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moveTable.Location = new System.Drawing.Point(11, 9);
            this.btn_moveTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_moveTable.Name = "btn_moveTable";
            this.btn_moveTable.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btn_moveTable.Size = new System.Drawing.Size(147, 57);
            this.btn_moveTable.TabIndex = 7;
            this.btn_moveTable.Text = "chuyển bàn";
            this.btn_moveTable.UseVisualStyleBackColor = true;
            // 
            // cbb_moveTable
            // 
            this.cbb_moveTable.FormattingEnabled = true;
            this.cbb_moveTable.Location = new System.Drawing.Point(11, 66);
            this.cbb_moveTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_moveTable.Name = "cbb_moveTable";
            this.cbb_moveTable.Size = new System.Drawing.Size(143, 24);
            this.cbb_moveTable.TabIndex = 6;
            // 
            // nm_discount
            // 
            this.nm_discount.Location = new System.Drawing.Point(299, 69);
            this.nm_discount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nm_discount.Name = "nm_discount";
            this.nm_discount.Size = new System.Drawing.Size(105, 22);
            this.nm_discount.TabIndex = 4;
            // 
            // btn_discount
            // 
            this.btn_discount.AutoSize = true;
            this.btn_discount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_discount.Location = new System.Drawing.Point(295, 9);
            this.btn_discount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btn_discount.Size = new System.Drawing.Size(125, 57);
            this.btn_discount.TabIndex = 5;
            this.btn_discount.Text = "giảm giá";
            this.btn_discount.UseVisualStyleBackColor = true;
            // 
            // btn_pay
            // 
            this.btn_pay.AutoSize = true;
            this.btn_pay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.Location = new System.Drawing.Point(409, 22);
            this.btn_pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.btn_pay.Size = new System.Drawing.Size(149, 66);
            this.btn_pay.TabIndex = 4;
            this.btn_pay.Text = "thanh toán";
            this.btn_pay.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(536, 129);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(529, 290);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nm_addItems);
            this.panel3.Controls.Add(this.cbb_items);
            this.panel3.Controls.Add(this.btn_addItems);
            this.panel3.Controls.Add(this.cbb_Category);
            this.panel3.Location = new System.Drawing.Point(533, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 81);
            this.panel3.TabIndex = 3;
            // 
            // nm_addItems
            // 
            this.nm_addItems.Location = new System.Drawing.Point(370, 30);
            this.nm_addItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nm_addItems.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_addItems.Name = "nm_addItems";
            this.nm_addItems.Size = new System.Drawing.Size(150, 22);
            this.nm_addItems.TabIndex = 3;
            this.nm_addItems.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbb_items
            // 
            this.cbb_items.FormattingEnabled = true;
            this.cbb_items.Location = new System.Drawing.Point(3, 50);
            this.cbb_items.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_items.Name = "cbb_items";
            this.cbb_items.Size = new System.Drawing.Size(201, 24);
            this.cbb_items.TabIndex = 2;
            // 
            // btn_addItems
            // 
            this.btn_addItems.AutoSize = true;
            this.btn_addItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItems.Location = new System.Drawing.Point(219, 10);
            this.btn_addItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addItems.Name = "btn_addItems";
            this.btn_addItems.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.btn_addItems.Size = new System.Drawing.Size(145, 66);
            this.btn_addItems.TabIndex = 1;
            this.btn_addItems.Text = "thêm món";
            this.btn_addItems.UseVisualStyleBackColor = true;
            // 
            // cbb_Category
            // 
            this.cbb_Category.FormattingEnabled = true;
            this.cbb_Category.Location = new System.Drawing.Point(3, 2);
            this.cbb_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_Category.Name = "cbb_Category";
            this.cbb_Category.Size = new System.Drawing.Size(201, 24);
            this.cbb_Category.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 34);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(531, 482);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // ftableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1065, 519);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ftableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ QUÁN";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_discount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_addItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbb_items;
        private System.Windows.Forms.Button btn_addItems;
        private System.Windows.Forms.ComboBox cbb_Category;
        private System.Windows.Forms.NumericUpDown nm_addItems;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_moveTable;
        private System.Windows.Forms.ComboBox cbb_moveTable;
        private System.Windows.Forms.NumericUpDown nm_discount;
        private System.Windows.Forms.Button btn_discount;
        private System.Windows.Forms.Button btn_pay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
namespace formLogin
{
    partial class thongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rjButton4 = new CustomControls.RJControls.RJButton();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(12, 316);
            this.chart1.Name = "chart1";
            series5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series5.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.Legend = "Legend1";
            series5.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series5.MarkerSize = 10;
            series5.Name = "DoanhThu";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(897, 350);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            title5.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            title5.Name = "Title1";
            title5.Text = "Doanh thu hàng tháng";
            this.chart1.Titles.Add(title5);
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(841, 219);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series6.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series6.Name = "SoHoaDon";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(641, 447);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            title6.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title6.BackColor = System.Drawing.Color.White;
            title6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            title6.Name = "Title1";
            title6.Text = "Số hóa đơn đã bán";
            this.chart2.Titles.Add(title6);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton4.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 30;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.rjButton4.FlatAppearance.BorderSize = 2;
            this.rjButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.rjButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Image = global::formLogin.Properties.Resources.icons8_chart_30__1_;
            this.rjButton4.Location = new System.Drawing.Point(1087, 65);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(257, 83);
            this.rjButton4.TabIndex = 11;
            this.rjButton4.Text = "doanh thu khách hàng";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rjButton4.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 30;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.rjButton3.FlatAppearance.BorderSize = 2;
            this.rjButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.rjButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Image = global::formLogin.Properties.Resources.icons8_chart_32__1_;
            this.rjButton3.Location = new System.Drawing.Point(753, 65);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(256, 83);
            this.rjButton3.TabIndex = 10;
            this.rjButton3.Text = "doanh thu sản phẩm";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 30;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.rjButton2.FlatAppearance.BorderSize = 2;
            this.rjButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.rjButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Image = global::formLogin.Properties.Resources.icons8_chart_32;
            this.rjButton2.Location = new System.Drawing.Point(442, 65);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(257, 83);
            this.rjButton2.TabIndex = 9;
            this.rjButton2.Text = "Doanh thu hàng tháng";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 30;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.rjButton1.FlatAppearance.BorderSize = 2;
            this.rjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.rjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = global::formLogin.Properties.Resources.icons8_chart_30;
            this.rjButton1.Location = new System.Drawing.Point(131, 65);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(257, 83);
            this.rjButton1.TabIndex = 8;
            this.rjButton1.Text = "Doanh thu trong ngày";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // thongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1512, 843);
            this.Controls.Add(this.rjButton4);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "thongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "// ";
            this.Load += new System.EventHandler(this.thongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton4;
    }
}
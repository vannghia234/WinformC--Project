namespace formLogin
{
    partial class reportView
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
            this.rp1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rp1
            // 
            this.rp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp1.DocumentMapCollapsed = true;
            this.rp1.IsDocumentMapWidthFixed = true;
            this.rp1.LocalReport.ReportEmbeddedResource = "formLogin.Report123.rdlc";
            this.rp1.Location = new System.Drawing.Point(0, 0);
            this.rp1.Name = "rp1";
            this.rp1.ServerReport.BearerToken = null;
            this.rp1.Size = new System.Drawing.Size(962, 770);
            this.rp1.TabIndex = 0;
            this.rp1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rp1.ZoomPercent = 80;
            // 
            // reportView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(962, 770);
            this.Controls.Add(this.rp1);
            this.Name = "reportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reportView";
            this.Load += new System.EventHandler(this.reportView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp1;
    }
}
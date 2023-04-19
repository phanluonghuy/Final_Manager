namespace Final_Manager.Staff
{
    partial class FormReport
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
            this.reportViewerImport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerImport
            // 
            this.reportViewerImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerImport.LocalReport.ReportEmbeddedResource = "Final_Manager.ReportImport.rdlc";
            this.reportViewerImport.Location = new System.Drawing.Point(0, 0);
            this.reportViewerImport.Name = "reportViewerImport";
            this.reportViewerImport.ServerReport.BearerToken = null;
            this.reportViewerImport.Size = new System.Drawing.Size(727, 425);
            this.reportViewerImport.TabIndex = 0;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 425);
            this.Controls.Add(this.reportViewerImport);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerImport;
    }
}
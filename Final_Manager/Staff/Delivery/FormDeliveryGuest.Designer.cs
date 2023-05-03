namespace Final_Manager.Staff.Delivery
{
    partial class FormDeliveryGuest
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
            this.DataGridViewGuest = new Zuby.ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewGuest
            // 
            this.DataGridViewGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewGuest.FilterAndSortEnabled = true;
            this.DataGridViewGuest.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DataGridViewGuest.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewGuest.Name = "DataGridViewGuest";
            this.DataGridViewGuest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridViewGuest.RowHeadersWidth = 51;
            this.DataGridViewGuest.RowTemplate.Height = 24;
            this.DataGridViewGuest.Size = new System.Drawing.Size(800, 450);
            this.DataGridViewGuest.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DataGridViewGuest.TabIndex = 0;
            // 
            // FormDeliveryGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewGuest);
            this.Name = "FormDeliveryGuest";
            this.Text = "FormDeliveryGuest";
            this.Load += new System.EventHandler(this.FormDeliveryGuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGuest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView DataGridViewGuest;
    }
}
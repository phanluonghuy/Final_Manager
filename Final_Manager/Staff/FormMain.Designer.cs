namespace Final_Manager.Staff
{
    partial class FormMain
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
            this.PanelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonImport_good = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonGoodsDelivery = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonReport = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSettings = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.Location = new System.Drawing.Point(325, 143);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(745, 472);
            this.PanelMain.TabIndex = 1;
            // 
            // ButtonImport_good
            // 
            this.ButtonImport_good.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonImport_good.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonImport_good.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonImport_good.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonImport_good.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonImport_good.ForeColor = System.Drawing.Color.White;
            this.ButtonImport_good.Location = new System.Drawing.Point(49, 195);
            this.ButtonImport_good.Name = "ButtonImport_good";
            this.ButtonImport_good.Size = new System.Drawing.Size(180, 45);
            this.ButtonImport_good.TabIndex = 2;
            this.ButtonImport_good.Text = "Goods Import ";
            this.ButtonImport_good.Click += new System.EventHandler(this.guna2ButtonImport_good_Click);
            // 
            // ButtonGoodsDelivery
            // 
            this.ButtonGoodsDelivery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonGoodsDelivery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonGoodsDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonGoodsDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonGoodsDelivery.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonGoodsDelivery.ForeColor = System.Drawing.Color.White;
            this.ButtonGoodsDelivery.Location = new System.Drawing.Point(49, 287);
            this.ButtonGoodsDelivery.Name = "ButtonGoodsDelivery";
            this.ButtonGoodsDelivery.Size = new System.Drawing.Size(180, 45);
            this.ButtonGoodsDelivery.TabIndex = 3;
            this.ButtonGoodsDelivery.Text = "Goods Delivery";
            this.ButtonGoodsDelivery.Click += new System.EventHandler(this.ButtonGoodsDelivery_Click);
            // 
            // ButtonReport
            // 
            this.ButtonReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonReport.ForeColor = System.Drawing.Color.White;
            this.ButtonReport.Location = new System.Drawing.Point(49, 386);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Size = new System.Drawing.Size(180, 45);
            this.ButtonReport.TabIndex = 4;
            this.ButtonReport.Text = "Report";
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSettings.ForeColor = System.Drawing.Color.White;
            this.ButtonSettings.Location = new System.Drawing.Point(49, 486);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(180, 45);
            this.ButtonSettings.TabIndex = 5;
            this.ButtonSettings.Text = "Settings";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Final_Manager.Properties.Resources.logo1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(303, 129);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 627);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.ButtonReport);
            this.Controls.Add(this.ButtonGoodsDelivery);
            this.Controls.Add(this.ButtonImport_good);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel PanelMain;
        private Guna.UI2.WinForms.Guna2Button ButtonImport_good;
        private Guna.UI2.WinForms.Guna2Button ButtonGoodsDelivery;
        private Guna.UI2.WinForms.Guna2Button ButtonReport;
        private Guna.UI2.WinForms.Guna2Button ButtonSettings;
    }
}
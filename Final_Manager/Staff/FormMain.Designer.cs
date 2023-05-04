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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelControl = new System.Windows.Forms.Panel();
            this.PanelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonSettings = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonImport_good = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonReport = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonGoodsDelivery = new Guna.UI2.WinForms.Guna2Button();
            this.panelControl.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.panelControl.Controls.Add(this.ButtonSettings);
            this.panelControl.Controls.Add(this.ButtonImport_good);
            this.panelControl.Controls.Add(this.ButtonReport);
            this.panelControl.Controls.Add(this.ButtonGoodsDelivery);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(150, 650);
            this.panelControl.TabIndex = 6;
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.PanelTitle.Controls.Add(this.button2);
            this.PanelTitle.Controls.Add(this.button1);
            this.PanelTitle.Controls.Add(this.label1);
            this.PanelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelTitle.Location = new System.Drawing.Point(155, 5);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(963, 61);
            this.PanelTitle.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(318, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN AREA";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(927, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(898, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BackgroundImage = global::Final_Manager.Properties.Resources.logo;
            this.PanelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMain.CustomBorderColor = System.Drawing.Color.White;
            this.PanelMain.Location = new System.Drawing.Point(156, 71);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(2);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(969, 579);
            this.PanelMain.TabIndex = 1;
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.ButtonSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSettings.ForeColor = System.Drawing.Color.White;
            this.ButtonSettings.Image = global::Final_Manager.Properties.Resources.setting;
            this.ButtonSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonSettings.Location = new System.Drawing.Point(-2, 510);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(150, 140);
            this.ButtonSettings.TabIndex = 5;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonImport_good
            // 
            this.ButtonImport_good.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.ButtonImport_good.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ButtonImport_good.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonImport_good.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonImport_good.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonImport_good.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonImport_good.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.ButtonImport_good.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonImport_good.ForeColor = System.Drawing.Color.White;
            this.ButtonImport_good.Image = global::Final_Manager.Properties.Resources.import;
            this.ButtonImport_good.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonImport_good.Location = new System.Drawing.Point(-2, 71);
            this.ButtonImport_good.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonImport_good.Name = "ButtonImport_good";
            this.ButtonImport_good.Size = new System.Drawing.Size(150, 140);
            this.ButtonImport_good.TabIndex = 2;
            this.ButtonImport_good.Text = "Import ";
            this.ButtonImport_good.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonImport_good.Click += new System.EventHandler(this.guna2ButtonImport_good_Click);
            // 
            // ButtonReport
            // 
            this.ButtonReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.ButtonReport.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReport.ForeColor = System.Drawing.Color.White;
            this.ButtonReport.Image = global::Final_Manager.Properties.Resources.report;
            this.ButtonReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonReport.Location = new System.Drawing.Point(0, 366);
            this.ButtonReport.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Size = new System.Drawing.Size(150, 140);
            this.ButtonReport.TabIndex = 4;
            this.ButtonReport.Text = "Report";
            this.ButtonReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // ButtonGoodsDelivery
            // 
            this.ButtonGoodsDelivery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonGoodsDelivery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonGoodsDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonGoodsDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonGoodsDelivery.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.ButtonGoodsDelivery.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGoodsDelivery.ForeColor = System.Drawing.Color.White;
            this.ButtonGoodsDelivery.Image = global::Final_Manager.Properties.Resources.delivery_truck;
            this.ButtonGoodsDelivery.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonGoodsDelivery.Location = new System.Drawing.Point(-2, 215);
            this.ButtonGoodsDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonGoodsDelivery.Name = "ButtonGoodsDelivery";
            this.ButtonGoodsDelivery.Size = new System.Drawing.Size(150, 140);
            this.ButtonGoodsDelivery.TabIndex = 3;
            this.ButtonGoodsDelivery.Text = "Delivery";
            this.ButtonGoodsDelivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonGoodsDelivery.Click += new System.EventHandler(this.ButtonGoodsDelivery_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 650);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelControl.ResumeLayout(false);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel PanelMain;
        private Guna.UI2.WinForms.Guna2Button ButtonImport_good;
        private Guna.UI2.WinForms.Guna2Button ButtonGoodsDelivery;
        private Guna.UI2.WinForms.Guna2Button ButtonReport;
        private Guna.UI2.WinForms.Guna2Button ButtonSettings;
        private System.Windows.Forms.Panel panelControl;
        private Guna.UI2.WinForms.Guna2Panel PanelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonLoad = new Guna.UI2.WinForms.Guna2Button();
            this.DateTimePickerTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateTimePickerFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelReport = new Guna.UI2.WinForms.Guna2Panel();
            this.DataGridViewBest = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxOutcoming = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxIncoming = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBest)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonLoad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonLoad.ForeColor = System.Drawing.Color.White;
            this.ButtonLoad.Location = new System.Drawing.Point(443, 11);
            this.ButtonLoad.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(70, 29);
            this.ButtonLoad.TabIndex = 10;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // DateTimePickerTo
            // 
            this.DateTimePickerTo.Checked = true;
            this.DateTimePickerTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerTo.Location = new System.Drawing.Point(280, 11);
            this.DateTimePickerTo.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimePickerTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerTo.Name = "DateTimePickerTo";
            this.DateTimePickerTo.Size = new System.Drawing.Size(150, 29);
            this.DateTimePickerTo.TabIndex = 9;
            this.DateTimePickerTo.Value = new System.DateTime(2023, 4, 23, 13, 32, 26, 438);
            // 
            // DateTimePickerFrom
            // 
            this.DateTimePickerFrom.Checked = true;
            this.DateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerFrom.Location = new System.Drawing.Point(81, 11);
            this.DateTimePickerFrom.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimePickerFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.Size = new System.Drawing.Size(150, 29);
            this.DateTimePickerFrom.TabIndex = 8;
            this.DateTimePickerFrom.Value = new System.DateTime(2023, 4, 23, 13, 32, 7, 365);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "To Day";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "From Date";
            // 
            // PanelReport
            // 
            this.PanelReport.Controls.Add(this.DataGridViewBest);
            this.PanelReport.Controls.Add(this.label6);
            this.PanelReport.Controls.Add(this.TextBoxTotal);
            this.PanelReport.Controls.Add(this.TextBoxOutcoming);
            this.PanelReport.Controls.Add(this.TextBoxIncoming);
            this.PanelReport.Controls.Add(this.label5);
            this.PanelReport.Controls.Add(this.label4);
            this.PanelReport.Controls.Add(this.label3);
            this.PanelReport.Location = new System.Drawing.Point(12, 53);
            this.PanelReport.Name = "PanelReport";
            this.PanelReport.Size = new System.Drawing.Size(521, 280);
            this.PanelReport.TabIndex = 11;
            // 
            // DataGridViewBest
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridViewBest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewBest.ColumnHeadersHeight = 4;
            this.DataGridViewBest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewBest.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewBest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewBest.Location = new System.Drawing.Point(27, 167);
            this.DataGridViewBest.Name = "DataGridViewBest";
            this.DataGridViewBest.RowHeadersVisible = false;
            this.DataGridViewBest.Size = new System.Drawing.Size(448, 110);
            this.DataGridViewBest.TabIndex = 7;
            this.DataGridViewBest.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewBest.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewBest.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewBest.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewBest.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewBest.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewBest.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewBest.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewBest.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewBest.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewBest.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewBest.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewBest.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewBest.ThemeStyle.ReadOnly = false;
            this.DataGridViewBest.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewBest.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewBest.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewBest.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewBest.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewBest.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewBest.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Revenue";
            // 
            // TextBoxTotal
            // 
            this.TextBoxTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTotal.DefaultText = "";
            this.TextBoxTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTotal.Location = new System.Drawing.Point(268, 111);
            this.TextBoxTotal.Name = "TextBoxTotal";
            this.TextBoxTotal.PasswordChar = '\0';
            this.TextBoxTotal.PlaceholderText = "";
            this.TextBoxTotal.SelectedText = "";
            this.TextBoxTotal.Size = new System.Drawing.Size(200, 26);
            this.TextBoxTotal.TabIndex = 5;
            // 
            // TextBoxOutcoming
            // 
            this.TextBoxOutcoming.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxOutcoming.DefaultText = "";
            this.TextBoxOutcoming.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxOutcoming.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxOutcoming.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxOutcoming.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxOutcoming.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxOutcoming.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxOutcoming.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxOutcoming.Location = new System.Drawing.Point(268, 74);
            this.TextBoxOutcoming.Name = "TextBoxOutcoming";
            this.TextBoxOutcoming.PasswordChar = '\0';
            this.TextBoxOutcoming.PlaceholderText = "";
            this.TextBoxOutcoming.SelectedText = "";
            this.TextBoxOutcoming.Size = new System.Drawing.Size(200, 21);
            this.TextBoxOutcoming.TabIndex = 4;
            // 
            // TextBoxIncoming
            // 
            this.TextBoxIncoming.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxIncoming.DefaultText = "";
            this.TextBoxIncoming.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxIncoming.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxIncoming.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxIncoming.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxIncoming.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxIncoming.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxIncoming.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxIncoming.Location = new System.Drawing.Point(268, 28);
            this.TextBoxIncoming.Name = "TextBoxIncoming";
            this.TextBoxIncoming.PasswordChar = '\0';
            this.TextBoxIncoming.PlaceholderText = "";
            this.TextBoxIncoming.SelectedText = "";
            this.TextBoxIncoming.Size = new System.Drawing.Size(200, 25);
            this.TextBoxIncoming.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Best Selling Products";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Outcoming Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Incoming Stock";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 345);
            this.Controls.Add(this.PanelReport);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.DateTimePickerTo);
            this.Controls.Add(this.DateTimePickerFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.PanelReport.ResumeLayout(false);
            this.PanelReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ButtonLoad;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel PanelReport;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewBest;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxTotal;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxOutcoming;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxIncoming;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
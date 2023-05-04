namespace Final_Manager.Staff
{
    partial class FormDelivery
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
            this.components = new System.ComponentModel.Container();
            this.tabControlAgent = new System.Windows.Forms.TabControl();
            this.tabPageGuest = new System.Windows.Forms.TabPage();
            this.DataGridViewDelivery = new Zuby.ADGV.AdvancedDataGridView();
            this.ButtonLoad = new Guna.UI2.WinForms.Guna2Button();
            this.DateTimePickerTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateTimePickerFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAgent = new System.Windows.Forms.TabPage();
            this.DataGridViewGuest = new Zuby.ADGV.AdvancedDataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.DateTimePickerToGuest = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateTimePickerFromGuest = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlAgent.SuspendLayout();
            this.tabPageGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDelivery)).BeginInit();
            this.tabPageAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAgent
            // 
            this.tabControlAgent.Controls.Add(this.tabPageGuest);
            this.tabControlAgent.Controls.Add(this.tabPageAgent);
            this.tabControlAgent.Location = new System.Drawing.Point(2, 2);
            this.tabControlAgent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlAgent.Name = "tabControlAgent";
            this.tabControlAgent.SelectedIndex = 0;
            this.tabControlAgent.Size = new System.Drawing.Size(950, 536);
            this.tabControlAgent.TabIndex = 9;
            // 
            // tabPageGuest
            // 
            this.tabPageGuest.Controls.Add(this.DataGridViewDelivery);
            this.tabPageGuest.Controls.Add(this.ButtonLoad);
            this.tabPageGuest.Controls.Add(this.DateTimePickerTo);
            this.tabPageGuest.Controls.Add(this.DateTimePickerFrom);
            this.tabPageGuest.Controls.Add(this.label2);
            this.tabPageGuest.Controls.Add(this.label1);
            this.tabPageGuest.Location = new System.Drawing.Point(4, 22);
            this.tabPageGuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageGuest.Name = "tabPageGuest";
            this.tabPageGuest.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageGuest.Size = new System.Drawing.Size(942, 510);
            this.tabPageGuest.TabIndex = 1;
            this.tabPageGuest.Text = "Agent";
            this.tabPageGuest.UseVisualStyleBackColor = true;
            // 
            // DataGridViewDelivery
            // 
            this.DataGridViewDelivery.AutoGenerateColumns = false;
            this.DataGridViewDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.agentIDDataGridViewTextBoxColumn,
            this.agentNameDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.DataGridViewDelivery.DataSource = this.ordersBindingSource;
            this.DataGridViewDelivery.FilterAndSortEnabled = true;
            this.DataGridViewDelivery.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DataGridViewDelivery.Location = new System.Drawing.Point(6, 48);
            this.DataGridViewDelivery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridViewDelivery.Name = "DataGridViewDelivery";
            this.DataGridViewDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridViewDelivery.RowHeadersWidth = 51;
            this.DataGridViewDelivery.RowTemplate.Height = 24;
            this.DataGridViewDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDelivery.Size = new System.Drawing.Size(930, 457);
            this.DataGridViewDelivery.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DataGridViewDelivery.TabIndex = 14;
            this.DataGridViewDelivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDelivery_CellContentClick);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonLoad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.ButtonLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLoad.ForeColor = System.Drawing.Color.White;
            this.ButtonLoad.Location = new System.Drawing.Point(866, 6);
            this.ButtonLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(70, 29);
            this.ButtonLoad.TabIndex = 13;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // DateTimePickerTo
            // 
            this.DateTimePickerTo.Checked = true;
            this.DateTimePickerTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.DateTimePickerTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerTo.Location = new System.Drawing.Point(394, 6);
            this.DateTimePickerTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimePickerTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerTo.Name = "DateTimePickerTo";
            this.DateTimePickerTo.Size = new System.Drawing.Size(150, 29);
            this.DateTimePickerTo.TabIndex = 12;
            this.DateTimePickerTo.Value = new System.DateTime(2023, 5, 4, 0, 0, 0, 0);
            // 
            // DateTimePickerFrom
            // 
            this.DateTimePickerFrom.BackColor = System.Drawing.Color.Transparent;
            this.DateTimePickerFrom.Checked = true;
            this.DateTimePickerFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.DateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerFrom.Location = new System.Drawing.Point(114, 6);
            this.DateTimePickerFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimePickerFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.Size = new System.Drawing.Size(150, 29);
            this.DateTimePickerFrom.TabIndex = 11;
            this.DateTimePickerFrom.Value = new System.DateTime(2023, 5, 4, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "To Day";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "From Date";
            // 
            // tabPageAgent
            // 
            this.tabPageAgent.Controls.Add(this.DataGridViewGuest);
            this.tabPageAgent.Controls.Add(this.guna2Button1);
            this.tabPageAgent.Controls.Add(this.DateTimePickerToGuest);
            this.tabPageAgent.Controls.Add(this.DateTimePickerFromGuest);
            this.tabPageAgent.Controls.Add(this.label3);
            this.tabPageAgent.Controls.Add(this.label4);
            this.tabPageAgent.Location = new System.Drawing.Point(4, 22);
            this.tabPageAgent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAgent.Name = "tabPageAgent";
            this.tabPageAgent.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAgent.Size = new System.Drawing.Size(942, 510);
            this.tabPageAgent.TabIndex = 0;
            this.tabPageAgent.Text = "Guest";
            this.tabPageAgent.UseVisualStyleBackColor = true;
            // 
            // DataGridViewGuest
            // 
            this.DataGridViewGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewGuest.FilterAndSortEnabled = true;
            this.DataGridViewGuest.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DataGridViewGuest.Location = new System.Drawing.Point(6, 48);
            this.DataGridViewGuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridViewGuest.Name = "DataGridViewGuest";
            this.DataGridViewGuest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridViewGuest.RowHeadersWidth = 51;
            this.DataGridViewGuest.RowTemplate.Height = 24;
            this.DataGridViewGuest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewGuest.Size = new System.Drawing.Size(930, 457);
            this.DataGridViewGuest.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DataGridViewGuest.TabIndex = 19;
            this.DataGridViewGuest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewGuest_CellContentClick);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(866, 6);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(70, 29);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Load";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // DateTimePickerToGuest
            // 
            this.DateTimePickerToGuest.Checked = true;
            this.DateTimePickerToGuest.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.DateTimePickerToGuest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerToGuest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerToGuest.Location = new System.Drawing.Point(394, 6);
            this.DateTimePickerToGuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimePickerToGuest.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerToGuest.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerToGuest.Name = "DateTimePickerToGuest";
            this.DateTimePickerToGuest.Size = new System.Drawing.Size(150, 29);
            this.DateTimePickerToGuest.TabIndex = 17;
            this.DateTimePickerToGuest.Value = new System.DateTime(2023, 5, 4, 0, 0, 0, 0);
            // 
            // DateTimePickerFromGuest
            // 
            this.DateTimePickerFromGuest.Checked = true;
            this.DateTimePickerFromGuest.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.DateTimePickerFromGuest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerFromGuest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerFromGuest.Location = new System.Drawing.Point(114, 6);
            this.DateTimePickerFromGuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimePickerFromGuest.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerFromGuest.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerFromGuest.Name = "DateTimePickerFromGuest";
            this.DateTimePickerFromGuest.Size = new System.Drawing.Size(150, 29);
            this.DateTimePickerFromGuest.TabIndex = 16;
            this.DateTimePickerFromGuest.Value = new System.DateTime(2023, 5, 4, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "To Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "From Date";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // agentIDDataGridViewTextBoxColumn
            // 
            this.agentIDDataGridViewTextBoxColumn.DataPropertyName = "AgentID";
            this.agentIDDataGridViewTextBoxColumn.HeaderText = "AgentID";
            this.agentIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.agentIDDataGridViewTextBoxColumn.Name = "agentIDDataGridViewTextBoxColumn";
            this.agentIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.agentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // agentNameDataGridViewTextBoxColumn
            // 
            this.agentNameDataGridViewTextBoxColumn.DataPropertyName = "AgentName";
            this.agentNameDataGridViewTextBoxColumn.HeaderText = "AgentName";
            this.agentNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.agentNameDataGridViewTextBoxColumn.Name = "agentNameDataGridViewTextBoxColumn";
            this.agentNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.agentNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.orderDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.totalAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            this.paymentMethodDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.paymentMethodDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(Final_Manager.Orders);
            // 
            // FormDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 540);
            this.Controls.Add(this.tabControlAgent);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDelivery";
            this.Text = "FormDelivery";
            this.Load += new System.EventHandler(this.FormDelivery_Load);
            this.tabControlAgent.ResumeLayout(false);
            this.tabPageGuest.ResumeLayout(false);
            this.tabPageGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDelivery)).EndInit();
            this.tabPageAgent.ResumeLayout(false);
            this.tabPageAgent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.TabControl tabControlAgent;
        private System.Windows.Forms.TabPage tabPageGuest;
        private System.Windows.Forms.TabPage tabPageAgent;
        private Zuby.ADGV.AdvancedDataGridView DataGridViewDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button ButtonLoad;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Zuby.ADGV.AdvancedDataGridView DataGridViewGuest;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerToGuest;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerFromGuest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimePickerFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateTimePickerTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ButtonLoad = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridViewDelivery = new Zuby.ADGV.AdvancedDataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "From Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "To Day";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DateTimePickerFrom
            // 
            this.DateTimePickerFrom.Checked = true;
            this.DateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerFrom.Location = new System.Drawing.Point(108, 30);
            this.DateTimePickerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePickerFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.Size = new System.Drawing.Size(200, 36);
            this.DateTimePickerFrom.TabIndex = 3;
            this.DateTimePickerFrom.Value = new System.DateTime(2023, 4, 23, 13, 32, 7, 365);
            this.DateTimePickerFrom.ValueChanged += new System.EventHandler(this.DateTimePickerFrom_ValueChanged);
            // 
            // DateTimePickerTo
            // 
            this.DateTimePickerTo.Checked = true;
            this.DateTimePickerTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerTo.Location = new System.Drawing.Point(373, 30);
            this.DateTimePickerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePickerTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerTo.Name = "DateTimePickerTo";
            this.DateTimePickerTo.Size = new System.Drawing.Size(200, 36);
            this.DateTimePickerTo.TabIndex = 4;
            this.DateTimePickerTo.Value = new System.DateTime(2023, 4, 23, 13, 32, 26, 438);
            this.DateTimePickerTo.ValueChanged += new System.EventHandler(this.DateTimePickerTo_ValueChanged);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonLoad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonLoad.ForeColor = System.Drawing.Color.White;
            this.ButtonLoad.Location = new System.Drawing.Point(591, 30);
            this.ButtonLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(93, 36);
            this.ButtonLoad.TabIndex = 5;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
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
            this.DataGridViewDelivery.Location = new System.Drawing.Point(12, 81);
            this.DataGridViewDelivery.Name = "DataGridViewDelivery";
            this.DataGridViewDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridViewDelivery.RowHeadersWidth = 51;
            this.DataGridViewDelivery.RowTemplate.Height = 24;
            this.DataGridViewDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDelivery.Size = new System.Drawing.Size(703, 316);
            this.DataGridViewDelivery.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DataGridViewDelivery.TabIndex = 8;
            this.DataGridViewDelivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDelivery_CellContentClick);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 425);
            this.Controls.Add(this.DataGridViewDelivery);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.DateTimePickerTo);
            this.Controls.Add(this.DateTimePickerFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDelivery";
            this.Text = "FormDelivery";
            this.Load += new System.EventHandler(this.FormDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerTo;
        private Guna.UI2.WinForms.Guna2Button ButtonLoad;
        private Zuby.ADGV.AdvancedDataGridView DataGridViewDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
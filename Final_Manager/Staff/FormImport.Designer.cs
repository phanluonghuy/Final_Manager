namespace Final_Manager.Staff
{
    partial class FormImport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewImport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxUnitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxQuanity = new Guna.UI2.WinForms.Guna2TextBox();
            this.DateTimePickerImport = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonRemove = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonImport = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBoxQuickAdd = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseReceiptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseReceiptsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewImport
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewImport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewImport.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewImport.ColumnHeadersHeight = 18;
            this.DataGridViewImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.receiptDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.DataGridViewImport.DataSource = this.warehouseReceiptsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewImport.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewImport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewImport.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewImport.Name = "DataGridViewImport";
            this.DataGridViewImport.RowHeadersVisible = false;
            this.DataGridViewImport.RowHeadersWidth = 51;
            this.DataGridViewImport.RowTemplate.Height = 24;
            this.DataGridViewImport.Size = new System.Drawing.Size(703, 228);
            this.DataGridViewImport.TabIndex = 0;
            this.DataGridViewImport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewImport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewImport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewImport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewImport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewImport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewImport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewImport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewImport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewImport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewImport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewImport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewImport.ThemeStyle.HeaderStyle.Height = 18;
            this.DataGridViewImport.ThemeStyle.ReadOnly = false;
            this.DataGridViewImport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewImport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewImport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewImport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewImport.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewImport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewImport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.DefaultText = "";
            this.TextBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxName.Location = new System.Drawing.Point(119, 292);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.PlaceholderText = "";
            this.TextBoxName.SelectedText = "";
            this.TextBoxName.Size = new System.Drawing.Size(229, 38);
            this.TextBoxName.TabIndex = 6;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDescription.DefaultText = "";
            this.TextBoxDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDescription.Location = new System.Drawing.Point(119, 338);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.PasswordChar = '\0';
            this.TextBoxDescription.PlaceholderText = "";
            this.TextBoxDescription.SelectedText = "";
            this.TextBoxDescription.Size = new System.Drawing.Size(229, 33);
            this.TextBoxDescription.TabIndex = 7;
            // 
            // TextBoxUnitPrice
            // 
            this.TextBoxUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUnitPrice.DefaultText = "";
            this.TextBoxUnitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUnitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUnitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUnitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUnitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUnitPrice.Location = new System.Drawing.Point(472, 258);
            this.TextBoxUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxUnitPrice.Name = "TextBoxUnitPrice";
            this.TextBoxUnitPrice.PasswordChar = '\0';
            this.TextBoxUnitPrice.PlaceholderText = "";
            this.TextBoxUnitPrice.SelectedText = "";
            this.TextBoxUnitPrice.Size = new System.Drawing.Size(229, 48);
            this.TextBoxUnitPrice.TabIndex = 8;
            // 
            // TextBoxQuanity
            // 
            this.TextBoxQuanity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxQuanity.DefaultText = "";
            this.TextBoxQuanity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxQuanity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxQuanity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxQuanity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxQuanity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxQuanity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxQuanity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxQuanity.Location = new System.Drawing.Point(472, 364);
            this.TextBoxQuanity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxQuanity.Name = "TextBoxQuanity";
            this.TextBoxQuanity.PasswordChar = '\0';
            this.TextBoxQuanity.PlaceholderText = "";
            this.TextBoxQuanity.SelectedText = "";
            this.TextBoxQuanity.Size = new System.Drawing.Size(229, 48);
            this.TextBoxQuanity.TabIndex = 9;
            // 
            // DateTimePickerImport
            // 
            this.DateTimePickerImport.Checked = true;
            this.DateTimePickerImport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerImport.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerImport.Location = new System.Drawing.Point(472, 321);
            this.DateTimePickerImport.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerImport.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerImport.Name = "DateTimePickerImport";
            this.DateTimePickerImport.Size = new System.Drawing.Size(229, 36);
            this.DateTimePickerImport.TabIndex = 10;
            this.DateTimePickerImport.Value = new System.DateTime(2023, 4, 17, 11, 53, 5, 863);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(20, 246);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(121, 45);
            this.ButtonAdd.TabIndex = 11;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRemove.ForeColor = System.Drawing.Color.White;
            this.ButtonRemove.Location = new System.Drawing.Point(156, 246);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(121, 45);
            this.ButtonRemove.TabIndex = 12;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Brand";
            // 
            // TextBoxBrand
            // 
            this.TextBoxBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxBrand.DefaultText = "";
            this.TextBoxBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxBrand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxBrand.Location = new System.Drawing.Point(119, 379);
            this.TextBoxBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxBrand.Name = "TextBoxBrand";
            this.TextBoxBrand.PasswordChar = '\0';
            this.TextBoxBrand.PlaceholderText = "";
            this.TextBoxBrand.SelectedText = "";
            this.TextBoxBrand.Size = new System.Drawing.Size(229, 40);
            this.TextBoxBrand.TabIndex = 15;
            // 
            // ButtonImport
            // 
            this.ButtonImport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonImport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonImport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonImport.ForeColor = System.Drawing.Color.White;
            this.ButtonImport.Location = new System.Drawing.Point(472, 430);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(180, 45);
            this.ButtonImport.TabIndex = 16;
            this.ButtonImport.Text = "Import";
            this.ButtonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // ComboBoxQuickAdd
            // 
            this.ComboBoxQuickAdd.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxQuickAdd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxQuickAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxQuickAdd.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxQuickAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxQuickAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxQuickAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxQuickAdd.ItemHeight = 30;
            this.ComboBoxQuickAdd.Location = new System.Drawing.Point(119, 426);
            this.ComboBoxQuickAdd.Name = "ComboBoxQuickAdd";
            this.ComboBoxQuickAdd.Size = new System.Drawing.Size(229, 36);
            this.ComboBoxQuickAdd.TabIndex = 17;
            this.ComboBoxQuickAdd.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxQuickAdd_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Quick Add";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // receiptDateDataGridViewTextBoxColumn
            // 
            this.receiptDateDataGridViewTextBoxColumn.DataPropertyName = "ReceiptDate";
            this.receiptDateDataGridViewTextBoxColumn.HeaderText = "ReceiptDate";
            this.receiptDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiptDateDataGridViewTextBoxColumn.Name = "receiptDateDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // warehouseReceiptsBindingSource
            // 
            this.warehouseReceiptsBindingSource.DataSource = typeof(Final_Manager.WarehouseReceipts);
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 487);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBoxQuickAdd);
            this.Controls.Add(this.ButtonImport);
            this.Controls.Add(this.TextBoxBrand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.DateTimePickerImport);
            this.Controls.Add(this.TextBoxQuanity);
            this.Controls.Add(this.TextBoxUnitPrice);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormImport";
            this.Text = "FormAddItems";
            this.Load += new System.EventHandler(this.FormImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseReceiptsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewImport;
        private System.Windows.Forms.BindingSource warehouseReceiptsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxName;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDescription;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUnitPrice;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxQuanity;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerImport;
        private Guna.UI2.WinForms.Guna2Button ButtonAdd;
        private Guna.UI2.WinForms.Guna2Button ButtonRemove;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button ButtonImport;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxQuickAdd;
        private System.Windows.Forms.Label label7;
    }
}
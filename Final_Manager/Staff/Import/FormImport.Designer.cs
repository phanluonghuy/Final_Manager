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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImport));
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
            this.ButtonUpload = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridViewImport = new Zuby.ADGV.AdvancedDataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxUpload = new System.Windows.Forms.PictureBox();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseReceiptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseReceiptsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(543, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(543, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
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
            this.TextBoxName.Location = new System.Drawing.Point(175, 36);
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
            this.TextBoxDescription.Location = new System.Drawing.Point(175, 94);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.PasswordChar = '\0';
            this.TextBoxDescription.PlaceholderText = "";
            this.TextBoxDescription.SelectedText = "";
            this.TextBoxDescription.Size = new System.Drawing.Size(229, 38);
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
            this.TextBoxUnitPrice.Location = new System.Drawing.Point(748, 26);
            this.TextBoxUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxUnitPrice.Name = "TextBoxUnitPrice";
            this.TextBoxUnitPrice.PasswordChar = '\0';
            this.TextBoxUnitPrice.PlaceholderText = "";
            this.TextBoxUnitPrice.SelectedText = "";
            this.TextBoxUnitPrice.Size = new System.Drawing.Size(229, 38);
            this.TextBoxUnitPrice.TabIndex = 9;
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
            this.TextBoxQuanity.Location = new System.Drawing.Point(748, 144);
            this.TextBoxQuanity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxQuanity.Name = "TextBoxQuanity";
            this.TextBoxQuanity.PasswordChar = '\0';
            this.TextBoxQuanity.PlaceholderText = "";
            this.TextBoxQuanity.SelectedText = "";
            this.TextBoxQuanity.Size = new System.Drawing.Size(229, 38);
            this.TextBoxQuanity.TabIndex = 10;
            // 
            // DateTimePickerImport
            // 
            this.DateTimePickerImport.Checked = true;
            this.DateTimePickerImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.DateTimePickerImport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerImport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerImport.Location = new System.Drawing.Point(748, 89);
            this.DateTimePickerImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePickerImport.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerImport.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerImport.Name = "DateTimePickerImport";
            this.DateTimePickerImport.Size = new System.Drawing.Size(229, 36);
            this.DateTimePickerImport.TabIndex = 11;
            this.DateTimePickerImport.Value = new System.DateTime(2023, 5, 4, 0, 0, 0, 0);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(1015, 270);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(121, 46);
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
            this.ButtonRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.ButtonRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemove.ForeColor = System.Drawing.Color.White;
            this.ButtonRemove.Location = new System.Drawing.Point(1156, 270);
            this.ButtonRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(121, 46);
            this.ButtonRemove.TabIndex = 12;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
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
            this.TextBoxBrand.Location = new System.Drawing.Point(175, 144);
            this.TextBoxBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxBrand.Name = "TextBoxBrand";
            this.TextBoxBrand.PasswordChar = '\0';
            this.TextBoxBrand.PlaceholderText = "";
            this.TextBoxBrand.SelectedText = "";
            this.TextBoxBrand.Size = new System.Drawing.Size(229, 38);
            this.TextBoxBrand.TabIndex = 8;
            // 
            // ButtonImport
            // 
            this.ButtonImport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonImport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.ButtonImport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonImport.ForeColor = System.Drawing.Color.White;
            this.ButtonImport.Location = new System.Drawing.Point(1097, 14);
            this.ButtonImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(180, 46);
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
            this.ComboBoxQuickAdd.Location = new System.Drawing.Point(131, 258);
            this.ComboBoxQuickAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxQuickAdd.Name = "ComboBoxQuickAdd";
            this.ComboBoxQuickAdd.Size = new System.Drawing.Size(229, 36);
            this.ComboBoxQuickAdd.TabIndex = 17;
            this.ComboBoxQuickAdd.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxQuickAdd_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Quick Add";
            // 
            // ButtonUpload
            // 
            this.ButtonUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonUpload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.ButtonUpload.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpload.ForeColor = System.Drawing.Color.White;
            this.ButtonUpload.Location = new System.Drawing.Point(877, 246);
            this.ButtonUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonUpload.Name = "ButtonUpload";
            this.ButtonUpload.Size = new System.Drawing.Size(100, 46);
            this.ButtonUpload.TabIndex = 20;
            this.ButtonUpload.Text = "Upload";
            this.ButtonUpload.Click += new System.EventHandler(this.ButtonUpload_Click);
            // 
            // DataGridViewImport
            // 
            this.DataGridViewImport.AutoGenerateColumns = false;
            this.DataGridViewImport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.proImageDataGridViewImageColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.receiptDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.DataGridViewImport.DataSource = this.warehouseReceiptsBindingSource;
            this.DataGridViewImport.FilterAndSortEnabled = true;
            this.DataGridViewImport.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DataGridViewImport.Location = new System.Drawing.Point(15, 320);
            this.DataGridViewImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewImport.Name = "DataGridViewImport";
            this.DataGridViewImport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridViewImport.RowHeadersWidth = 51;
            this.DataGridViewImport.RowTemplate.Height = 24;
            this.DataGridViewImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewImport.Size = new System.Drawing.Size(1263, 379);
            this.DataGridViewImport.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DataGridViewImport.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(543, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Image";
            // 
            // pictureBoxUpload
            // 
            this.pictureBoxUpload.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxUpload.Location = new System.Drawing.Point(748, 218);
            this.pictureBoxUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUpload.Name = "pictureBoxUpload";
            this.pictureBoxUpload.Size = new System.Drawing.Size(91, 73);
            this.pictureBoxUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUpload.TabIndex = 21;
            this.pictureBoxUpload.TabStop = false;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // proImageDataGridViewImageColumn
            // 
            this.proImageDataGridViewImageColumn.DataPropertyName = "ProImage";
            this.proImageDataGridViewImageColumn.HeaderText = "ProImage";
            this.proImageDataGridViewImageColumn.MinimumWidth = 22;
            this.proImageDataGridViewImageColumn.Name = "proImageDataGridViewImageColumn";
            this.proImageDataGridViewImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.proImageDataGridViewImageColumn.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.unitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // receiptDateDataGridViewTextBoxColumn
            // 
            this.receiptDateDataGridViewTextBoxColumn.DataPropertyName = "ReceiptDate";
            this.receiptDateDataGridViewTextBoxColumn.HeaderText = "ReceiptDate";
            this.receiptDateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.receiptDateDataGridViewTextBoxColumn.Name = "receiptDateDataGridViewTextBoxColumn";
            this.receiptDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.receiptDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // warehouseReceiptsBindingSource
            // 
            this.warehouseReceiptsBindingSource.DataSource = typeof(Final_Manager.WarehouseReceipts);
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 713);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DataGridViewImport);
            this.Controls.Add(this.pictureBoxUpload);
            this.Controls.Add(this.ButtonUpload);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormImport";
            this.Text = "FormAddItems";
            this.Load += new System.EventHandler(this.FormImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseReceiptsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Guna.UI2.WinForms.Guna2Button ButtonImport;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxQuickAdd;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button ButtonUpload;
        private System.Windows.Forms.BindingSource warehouseReceiptsBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxUpload;
        private Zuby.ADGV.AdvancedDataGridView DataGridViewImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn proImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}
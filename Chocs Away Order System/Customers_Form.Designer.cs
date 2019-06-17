namespace Chocs_Away_Order_System
{
    partial class Customers_Form
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
            this.customers_DataGridView = new System.Windows.Forms.DataGridView();
            this.CustomerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPostcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerHouseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.Postcode_TextBox = new System.Windows.Forms.TextBox();
            this.HouseNumber_TextBox = new System.Windows.Forms.TextBox();
            this.Filters_GroupBox = new System.Windows.Forms.GroupBox();
            this.FirstName_Label = new System.Windows.Forms.Label();
            this.Postcode_Label = new System.Windows.Forms.Label();
            this.HouseNumber_Label = new System.Windows.Forms.Label();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.LastName_Label = new System.Windows.Forms.Label();
            this.AddCustomer_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customers_DataGridView)).BeginInit();
            this.Filters_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customers_DataGridView
            // 
            this.customers_DataGridView.AllowUserToAddRows = false;
            this.customers_DataGridView.AllowUserToDeleteRows = false;
            this.customers_DataGridView.AllowUserToResizeColumns = false;
            this.customers_DataGridView.AllowUserToResizeRows = false;
            this.customers_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customers_DataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customers_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customers_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customers_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerNumber,
            this.customerName,
            this.customerPostcode,
            this.customerHouseNumber});
            this.customers_DataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.customers_DataGridView.Location = new System.Drawing.Point(0, 87);
            this.customers_DataGridView.MultiSelect = false;
            this.customers_DataGridView.Name = "customers_DataGridView";
            this.customers_DataGridView.ReadOnly = true;
            this.customers_DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customers_DataGridView.RowHeadersVisible = false;
            this.customers_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customers_DataGridView.Size = new System.Drawing.Size(438, 230);
            this.customers_DataGridView.TabIndex = 0;
            this.customers_DataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customers_DataGridView_CellMouseDoubleClick);
            // 
            // CustomerNumber
            // 
            this.CustomerNumber.FillWeight = 50F;
            this.CustomerNumber.HeaderText = "Customer No";
            this.CustomerNumber.Name = "CustomerNumber";
            this.CustomerNumber.ReadOnly = true;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // customerPostcode
            // 
            this.customerPostcode.FillWeight = 40F;
            this.customerPostcode.HeaderText = "Postcode";
            this.customerPostcode.Name = "customerPostcode";
            this.customerPostcode.ReadOnly = true;
            // 
            // customerHouseNumber
            // 
            this.customerHouseNumber.FillWeight = 50F;
            this.customerHouseNumber.HeaderText = "House Number";
            this.customerHouseNumber.Name = "customerHouseNumber";
            this.customerHouseNumber.ReadOnly = true;
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstName_TextBox.Location = new System.Drawing.Point(6, 36);
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.Size = new System.Drawing.Size(106, 20);
            this.FirstName_TextBox.TabIndex = 1;
            this.FirstName_TextBox.TextChanged += new System.EventHandler(this.Name_TextBox_TextChanged);
            // 
            // Postcode_TextBox
            // 
            this.Postcode_TextBox.Location = new System.Drawing.Point(230, 36);
            this.Postcode_TextBox.Name = "Postcode_TextBox";
            this.Postcode_TextBox.Size = new System.Drawing.Size(88, 20);
            this.Postcode_TextBox.TabIndex = 2;
            this.Postcode_TextBox.TextChanged += new System.EventHandler(this.Postcode_TextBox_TextChanged);
            // 
            // HouseNumber_TextBox
            // 
            this.HouseNumber_TextBox.Location = new System.Drawing.Point(324, 36);
            this.HouseNumber_TextBox.Name = "HouseNumber_TextBox";
            this.HouseNumber_TextBox.Size = new System.Drawing.Size(80, 20);
            this.HouseNumber_TextBox.TabIndex = 3;
            this.HouseNumber_TextBox.TextChanged += new System.EventHandler(this.HouseNumber_TextBox_TextChanged);
            // 
            // Filters_GroupBox
            // 
            this.Filters_GroupBox.Controls.Add(this.LastName_Label);
            this.Filters_GroupBox.Controls.Add(this.LastName_TextBox);
            this.Filters_GroupBox.Controls.Add(this.HouseNumber_Label);
            this.Filters_GroupBox.Controls.Add(this.Postcode_Label);
            this.Filters_GroupBox.Controls.Add(this.FirstName_Label);
            this.Filters_GroupBox.Controls.Add(this.FirstName_TextBox);
            this.Filters_GroupBox.Controls.Add(this.Postcode_TextBox);
            this.Filters_GroupBox.Controls.Add(this.HouseNumber_TextBox);
            this.Filters_GroupBox.Location = new System.Drawing.Point(12, 12);
            this.Filters_GroupBox.Name = "Filters_GroupBox";
            this.Filters_GroupBox.Size = new System.Drawing.Size(414, 69);
            this.Filters_GroupBox.TabIndex = 5;
            this.Filters_GroupBox.TabStop = false;
            this.Filters_GroupBox.Text = "Search Filters";
            // 
            // FirstName_Label
            // 
            this.FirstName_Label.AutoSize = true;
            this.FirstName_Label.Location = new System.Drawing.Point(6, 20);
            this.FirstName_Label.Name = "FirstName_Label";
            this.FirstName_Label.Size = new System.Drawing.Size(57, 13);
            this.FirstName_Label.TabIndex = 4;
            this.FirstName_Label.Text = "First Name";
            // 
            // Postcode_Label
            // 
            this.Postcode_Label.AutoSize = true;
            this.Postcode_Label.Location = new System.Drawing.Point(227, 20);
            this.Postcode_Label.Name = "Postcode_Label";
            this.Postcode_Label.Size = new System.Drawing.Size(52, 13);
            this.Postcode_Label.TabIndex = 5;
            this.Postcode_Label.Text = "Postcode";
            // 
            // HouseNumber_Label
            // 
            this.HouseNumber_Label.AutoSize = true;
            this.HouseNumber_Label.Location = new System.Drawing.Point(321, 20);
            this.HouseNumber_Label.Name = "HouseNumber_Label";
            this.HouseNumber_Label.Size = new System.Drawing.Size(58, 13);
            this.HouseNumber_Label.TabIndex = 6;
            this.HouseNumber_Label.Text = "House No.";
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Location = new System.Drawing.Point(118, 36);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(106, 20);
            this.LastName_TextBox.TabIndex = 7;
            this.LastName_TextBox.TextChanged += new System.EventHandler(this.LastName_TextBox_TextChanged);
            // 
            // LastName_Label
            // 
            this.LastName_Label.AutoSize = true;
            this.LastName_Label.Location = new System.Drawing.Point(115, 20);
            this.LastName_Label.Name = "LastName_Label";
            this.LastName_Label.Size = new System.Drawing.Size(58, 13);
            this.LastName_Label.TabIndex = 8;
            this.LastName_Label.Text = "Last Name";
            // 
            // AddCustomer_Button
            // 
            this.AddCustomer_Button.Location = new System.Drawing.Point(12, 327);
            this.AddCustomer_Button.Name = "AddCustomer_Button";
            this.AddCustomer_Button.Size = new System.Drawing.Size(414, 23);
            this.AddCustomer_Button.TabIndex = 6;
            this.AddCustomer_Button.Text = "Add Customer";
            this.AddCustomer_Button.UseVisualStyleBackColor = true;
            this.AddCustomer_Button.Click += new System.EventHandler(this.AddCustomer_Button_Click);
            // 
            // Customers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 358);
            this.Controls.Add(this.AddCustomer_Button);
            this.Controls.Add(this.Filters_GroupBox);
            this.Controls.Add(this.customers_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Customers_Form";
            this.Text = "Customers Form";
            ((System.ComponentModel.ISupportInitialize)(this.customers_DataGridView)).EndInit();
            this.Filters_GroupBox.ResumeLayout(false);
            this.Filters_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customers_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPostcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerHouseNumber;
        private System.Windows.Forms.TextBox FirstName_TextBox;
        private System.Windows.Forms.TextBox Postcode_TextBox;
        private System.Windows.Forms.TextBox HouseNumber_TextBox;
        private System.Windows.Forms.GroupBox Filters_GroupBox;
        private System.Windows.Forms.Label HouseNumber_Label;
        private System.Windows.Forms.Label Postcode_Label;
        private System.Windows.Forms.Label FirstName_Label;
        private System.Windows.Forms.Label LastName_Label;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.Button AddCustomer_Button;
    }
}


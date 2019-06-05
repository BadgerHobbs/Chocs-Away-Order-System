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
            ((System.ComponentModel.ISupportInitialize)(this.customers_DataGridView)).BeginInit();
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
            this.customers_DataGridView.Location = new System.Drawing.Point(0, 3);
            this.customers_DataGridView.MultiSelect = false;
            this.customers_DataGridView.Name = "customers_DataGridView";
            this.customers_DataGridView.ReadOnly = true;
            this.customers_DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customers_DataGridView.RowHeadersVisible = false;
            this.customers_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customers_DataGridView.Size = new System.Drawing.Size(438, 358);
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
            // Customers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 358);
            this.Controls.Add(this.customers_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Customers_Form";
            this.Text = "Customers Form";
            ((System.ComponentModel.ISupportInitialize)(this.customers_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customers_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPostcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerHouseNumber;
    }
}


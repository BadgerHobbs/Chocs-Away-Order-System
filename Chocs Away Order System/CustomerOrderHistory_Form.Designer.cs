﻿namespace Chocs_Away_Order_System
{
    partial class CustomerOrderHistory_Form
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
            this.CutomerOrders_DataGridView = new System.Windows.Forms.DataGridView();
            this.OrderItems_DataGridView = new System.Windows.Forms.DataGridView();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItems_OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItems_ProductNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItems_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CutomerOrders_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItems_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CutomerOrders_DataGridView
            // 
            this.CutomerOrders_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CutomerOrders_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CutomerOrders_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNumber,
            this.OrderDate,
            this.OrderStatus,
            this.OrderTotal});
            this.CutomerOrders_DataGridView.Location = new System.Drawing.Point(12, 12);
            this.CutomerOrders_DataGridView.Name = "CutomerOrders_DataGridView";
            this.CutomerOrders_DataGridView.RowHeadersVisible = false;
            this.CutomerOrders_DataGridView.Size = new System.Drawing.Size(776, 120);
            this.CutomerOrders_DataGridView.TabIndex = 0;
            // 
            // OrderItems_DataGridView
            // 
            this.OrderItems_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderItems_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderItems_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderItems_OrderNumber,
            this.OrderItems_ProductNumber,
            this.OrderItems_Quantity});
            this.OrderItems_DataGridView.Location = new System.Drawing.Point(12, 149);
            this.OrderItems_DataGridView.Name = "OrderItems_DataGridView";
            this.OrderItems_DataGridView.RowHeadersVisible = false;
            this.OrderItems_DataGridView.Size = new System.Drawing.Size(776, 289);
            this.OrderItems_DataGridView.TabIndex = 1;
            // 
            // OrderNumber
            // 
            this.OrderNumber.HeaderText = "Order Number";
            this.OrderNumber.Name = "OrderNumber";
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.Name = "OrderDate";
            // 
            // OrderStatus
            // 
            this.OrderStatus.HeaderText = "Order Status";
            this.OrderStatus.Name = "OrderStatus";
            // 
            // OrderTotal
            // 
            this.OrderTotal.HeaderText = "Order Total";
            this.OrderTotal.Name = "OrderTotal";
            // 
            // OrderItems_OrderNumber
            // 
            this.OrderItems_OrderNumber.HeaderText = "Order Number";
            this.OrderItems_OrderNumber.Name = "OrderItems_OrderNumber";
            // 
            // OrderItems_ProductNumber
            // 
            this.OrderItems_ProductNumber.HeaderText = "Product Number";
            this.OrderItems_ProductNumber.Name = "OrderItems_ProductNumber";
            // 
            // OrderItems_Quantity
            // 
            this.OrderItems_Quantity.HeaderText = "Quanity";
            this.OrderItems_Quantity.Name = "OrderItems_Quantity";
            // 
            // CustomerOrderHistory_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderItems_DataGridView);
            this.Controls.Add(this.CutomerOrders_DataGridView);
            this.Name = "CustomerOrderHistory_Form";
            this.Text = "CustomerOrderHistory_Form";
            ((System.ComponentModel.ISupportInitialize)(this.CutomerOrders_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItems_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CutomerOrders_DataGridView;
        private System.Windows.Forms.DataGridView OrderItems_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItems_OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItems_ProductNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItems_Quantity;
    }
}
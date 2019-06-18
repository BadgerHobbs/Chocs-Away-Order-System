namespace Chocs_Away_Order_System
{
    partial class OrderBasket_Form
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
            this.OrderSummary_Panel = new System.Windows.Forms.Panel();
            this.ProductsNumber_Label = new System.Windows.Forms.Label();
            this.Products_Label = new System.Windows.Forms.Label();
            this.Spacer2_Label = new System.Windows.Forms.Label();
            this.ItemsNumber_Label = new System.Windows.Forms.Label();
            this.Items_Label = new System.Windows.Forms.Label();
            this.Spacer3_Label = new System.Windows.Forms.Label();
            this.Checkout_Button = new System.Windows.Forms.Button();
            this.TotalCost_Label = new System.Windows.Forms.Label();
            this.Total_Label = new System.Windows.Forms.Label();
            this.Spacer1_Label = new System.Windows.Forms.Label();
            this.OrderSummary_Label = new System.Windows.Forms.Label();
            this.Item_ComboBox = new System.Windows.Forms.ComboBox();
            this.Description_TextBox = new System.Windows.Forms.TextBox();
            this.Item_Panel = new System.Windows.Forms.Panel();
            this.Quantity_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Price_TextBox = new System.Windows.Forms.TextBox();
            this.Description_Label = new System.Windows.Forms.TextBox();
            this.Quantity_Label = new System.Windows.Forms.TextBox();
            this.Item_Label = new System.Windows.Forms.TextBox();
            this.Price_Label = new System.Windows.Forms.TextBox();
            this.RemoveItem_Button = new System.Windows.Forms.Button();
            this.ClearBasket_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Basket_Panel = new System.Windows.Forms.Panel();
            this.Basket_DataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Basket_Label = new System.Windows.Forms.Label();
            this.OrderSummary_Panel.SuspendLayout();
            this.Item_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_NumericUpDown)).BeginInit();
            this.Basket_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Basket_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderSummary_Panel
            // 
            this.OrderSummary_Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OrderSummary_Panel.Controls.Add(this.ProductsNumber_Label);
            this.OrderSummary_Panel.Controls.Add(this.Products_Label);
            this.OrderSummary_Panel.Controls.Add(this.Spacer2_Label);
            this.OrderSummary_Panel.Controls.Add(this.ItemsNumber_Label);
            this.OrderSummary_Panel.Controls.Add(this.Items_Label);
            this.OrderSummary_Panel.Controls.Add(this.Spacer3_Label);
            this.OrderSummary_Panel.Controls.Add(this.Checkout_Button);
            this.OrderSummary_Panel.Controls.Add(this.TotalCost_Label);
            this.OrderSummary_Panel.Controls.Add(this.Total_Label);
            this.OrderSummary_Panel.Controls.Add(this.Spacer1_Label);
            this.OrderSummary_Panel.Controls.Add(this.OrderSummary_Label);
            this.OrderSummary_Panel.Location = new System.Drawing.Point(736, 125);
            this.OrderSummary_Panel.Name = "OrderSummary_Panel";
            this.OrderSummary_Panel.Size = new System.Drawing.Size(173, 252);
            this.OrderSummary_Panel.TabIndex = 0;
            // 
            // ProductsNumber_Label
            // 
            this.ProductsNumber_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsNumber_Label.Location = new System.Drawing.Point(100, 64);
            this.ProductsNumber_Label.Name = "ProductsNumber_Label";
            this.ProductsNumber_Label.Size = new System.Drawing.Size(66, 21);
            this.ProductsNumber_Label.TabIndex = 10;
            this.ProductsNumber_Label.Text = "0";
            this.ProductsNumber_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProductsNumber_Label.Click += new System.EventHandler(this.ProductsNumber_Label_Click);
            // 
            // Products_Label
            // 
            this.Products_Label.AutoSize = true;
            this.Products_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products_Label.Location = new System.Drawing.Point(8, 64);
            this.Products_Label.Name = "Products_Label";
            this.Products_Label.Size = new System.Drawing.Size(78, 21);
            this.Products_Label.TabIndex = 9;
            this.Products_Label.Text = "Products";
            // 
            // Spacer2_Label
            // 
            this.Spacer2_Label.AutoSize = true;
            this.Spacer2_Label.BackColor = System.Drawing.Color.Transparent;
            this.Spacer2_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spacer2_Label.Location = new System.Drawing.Point(8, 88);
            this.Spacer2_Label.Name = "Spacer2_Label";
            this.Spacer2_Label.Size = new System.Drawing.Size(158, 20);
            this.Spacer2_Label.TabIndex = 8;
            this.Spacer2_Label.Text = "- - - - - - - - - - - - - - - - -";
            // 
            // ItemsNumber_Label
            // 
            this.ItemsNumber_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsNumber_Label.Location = new System.Drawing.Point(100, 111);
            this.ItemsNumber_Label.Name = "ItemsNumber_Label";
            this.ItemsNumber_Label.Size = new System.Drawing.Size(66, 21);
            this.ItemsNumber_Label.TabIndex = 7;
            this.ItemsNumber_Label.Text = "0";
            this.ItemsNumber_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Items_Label
            // 
            this.Items_Label.AutoSize = true;
            this.Items_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items_Label.Location = new System.Drawing.Point(8, 111);
            this.Items_Label.Name = "Items_Label";
            this.Items_Label.Size = new System.Drawing.Size(53, 21);
            this.Items_Label.TabIndex = 6;
            this.Items_Label.Text = "Items";
            // 
            // Spacer3_Label
            // 
            this.Spacer3_Label.AutoSize = true;
            this.Spacer3_Label.BackColor = System.Drawing.Color.Transparent;
            this.Spacer3_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spacer3_Label.Location = new System.Drawing.Point(8, 134);
            this.Spacer3_Label.Name = "Spacer3_Label";
            this.Spacer3_Label.Size = new System.Drawing.Size(158, 20);
            this.Spacer3_Label.TabIndex = 5;
            this.Spacer3_Label.Text = "- - - - - - - - - - - - - - - - -";
            // 
            // Checkout_Button
            // 
            this.Checkout_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Checkout_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Checkout_Button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkout_Button.ForeColor = System.Drawing.Color.White;
            this.Checkout_Button.Location = new System.Drawing.Point(16, 201);
            this.Checkout_Button.Name = "Checkout_Button";
            this.Checkout_Button.Size = new System.Drawing.Size(146, 36);
            this.Checkout_Button.TabIndex = 4;
            this.Checkout_Button.Text = "Checkout";
            this.Checkout_Button.UseVisualStyleBackColor = false;
            this.Checkout_Button.Click += new System.EventHandler(this.Checkout_Button_Click);
            // 
            // TotalCost_Label
            // 
            this.TotalCost_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalCost_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCost_Label.Location = new System.Drawing.Point(92, 154);
            this.TotalCost_Label.Name = "TotalCost_Label";
            this.TotalCost_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotalCost_Label.Size = new System.Drawing.Size(74, 21);
            this.TotalCost_Label.TabIndex = 3;
            this.TotalCost_Label.Text = "£0.00";
            this.TotalCost_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalCost_Label.Click += new System.EventHandler(this.TotalCost_Label_Click);
            // 
            // Total_Label
            // 
            this.Total_Label.AutoSize = true;
            this.Total_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Label.Location = new System.Drawing.Point(8, 156);
            this.Total_Label.Name = "Total_Label";
            this.Total_Label.Size = new System.Drawing.Size(49, 21);
            this.Total_Label.TabIndex = 2;
            this.Total_Label.Text = "Total";
            // 
            // Spacer1_Label
            // 
            this.Spacer1_Label.AutoSize = true;
            this.Spacer1_Label.BackColor = System.Drawing.Color.Transparent;
            this.Spacer1_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spacer1_Label.Location = new System.Drawing.Point(8, 40);
            this.Spacer1_Label.Name = "Spacer1_Label";
            this.Spacer1_Label.Size = new System.Drawing.Size(158, 20);
            this.Spacer1_Label.TabIndex = 1;
            this.Spacer1_Label.Text = "- - - - - - - - - - - - - - - - -";
            // 
            // OrderSummary_Label
            // 
            this.OrderSummary_Label.AutoSize = true;
            this.OrderSummary_Label.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSummary_Label.Location = new System.Drawing.Point(5, 11);
            this.OrderSummary_Label.Name = "OrderSummary_Label";
            this.OrderSummary_Label.Size = new System.Drawing.Size(163, 23);
            this.OrderSummary_Label.TabIndex = 0;
            this.OrderSummary_Label.Text = "Order Summary";
            // 
            // Item_ComboBox
            // 
            this.Item_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Item_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item_ComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_ComboBox.FormattingEnabled = true;
            this.Item_ComboBox.Location = new System.Drawing.Point(11, 41);
            this.Item_ComboBox.Name = "Item_ComboBox";
            this.Item_ComboBox.Size = new System.Drawing.Size(213, 30);
            this.Item_ComboBox.TabIndex = 2;
            this.Item_ComboBox.TextChanged += new System.EventHandler(this.Item_ComboBox_TextChanged);
            // 
            // Description_TextBox
            // 
            this.Description_TextBox.BackColor = System.Drawing.Color.White;
            this.Description_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description_TextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Description_TextBox.Location = new System.Drawing.Point(341, 34);
            this.Description_TextBox.Multiline = true;
            this.Description_TextBox.Name = "Description_TextBox";
            this.Description_TextBox.ReadOnly = true;
            this.Description_TextBox.Size = new System.Drawing.Size(269, 45);
            this.Description_TextBox.TabIndex = 3;
            this.Description_TextBox.Text = "Description";
            // 
            // Item_Panel
            // 
            this.Item_Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Item_Panel.Controls.Add(this.Quantity_NumericUpDown);
            this.Item_Panel.Controls.Add(this.Add_Button);
            this.Item_Panel.Controls.Add(this.Price_TextBox);
            this.Item_Panel.Controls.Add(this.Item_ComboBox);
            this.Item_Panel.Controls.Add(this.Description_TextBox);
            this.Item_Panel.Location = new System.Drawing.Point(12, 8);
            this.Item_Panel.Name = "Item_Panel";
            this.Item_Panel.Size = new System.Drawing.Size(897, 87);
            this.Item_Panel.TabIndex = 11;
            // 
            // Quantity_NumericUpDown
            // 
            this.Quantity_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Quantity_NumericUpDown.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_NumericUpDown.Location = new System.Drawing.Point(632, 41);
            this.Quantity_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Quantity_NumericUpDown.Name = "Quantity_NumericUpDown";
            this.Quantity_NumericUpDown.Size = new System.Drawing.Size(64, 27);
            this.Quantity_NumericUpDown.TabIndex = 23;
            this.Quantity_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Quantity_NumericUpDown.ValueChanged += new System.EventHandler(this.Quantity_NumericUpDown_ValueChanged);
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Button.Location = new System.Drawing.Point(750, 18);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(116, 53);
            this.Add_Button.TabIndex = 11;
            this.Add_Button.Text = "Add Item";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Price_TextBox
            // 
            this.Price_TextBox.BackColor = System.Drawing.Color.White;
            this.Price_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price_TextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_TextBox.Location = new System.Drawing.Point(241, 44);
            this.Price_TextBox.Name = "Price_TextBox";
            this.Price_TextBox.Size = new System.Drawing.Size(84, 24);
            this.Price_TextBox.TabIndex = 4;
            this.Price_TextBox.Text = "£0.00";
            this.Price_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Price_TextBox.TextChanged += new System.EventHandler(this.Price_TextBox_TextChanged);
            // 
            // Description_Label
            // 
            this.Description_Label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Description_Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_Label.Location = new System.Drawing.Point(353, 15);
            this.Description_Label.Name = "Description_Label";
            this.Description_Label.ReadOnly = true;
            this.Description_Label.Size = new System.Drawing.Size(269, 19);
            this.Description_Label.TabIndex = 12;
            this.Description_Label.Text = "Description";
            this.Description_Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Quantity_Label
            // 
            this.Quantity_Label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Quantity_Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Quantity_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_Label.Location = new System.Drawing.Point(641, 15);
            this.Quantity_Label.Name = "Quantity_Label";
            this.Quantity_Label.ReadOnly = true;
            this.Quantity_Label.Size = new System.Drawing.Size(64, 19);
            this.Quantity_Label.TabIndex = 13;
            this.Quantity_Label.Text = "Quantity";
            this.Quantity_Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Item_Label
            // 
            this.Item_Label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Item_Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Item_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Label.Location = new System.Drawing.Point(23, 15);
            this.Item_Label.Name = "Item_Label";
            this.Item_Label.ReadOnly = true;
            this.Item_Label.Size = new System.Drawing.Size(213, 19);
            this.Item_Label.TabIndex = 14;
            this.Item_Label.Text = "Item";
            this.Item_Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Price_Label
            // 
            this.Price_Label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Price_Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_Label.Location = new System.Drawing.Point(253, 15);
            this.Price_Label.Name = "Price_Label";
            this.Price_Label.ReadOnly = true;
            this.Price_Label.Size = new System.Drawing.Size(84, 19);
            this.Price_Label.TabIndex = 15;
            this.Price_Label.Text = "Price";
            this.Price_Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RemoveItem_Button
            // 
            this.RemoveItem_Button.BackColor = System.Drawing.Color.IndianRed;
            this.RemoveItem_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveItem_Button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItem_Button.ForeColor = System.Drawing.Color.White;
            this.RemoveItem_Button.Location = new System.Drawing.Point(422, 504);
            this.RemoveItem_Button.Name = "RemoveItem_Button";
            this.RemoveItem_Button.Size = new System.Drawing.Size(139, 27);
            this.RemoveItem_Button.TabIndex = 11;
            this.RemoveItem_Button.Text = "Remove Item";
            this.RemoveItem_Button.UseVisualStyleBackColor = false;
            this.RemoveItem_Button.Click += new System.EventHandler(this.RemoveItem_Button_Click);
            // 
            // ClearBasket_Button
            // 
            this.ClearBasket_Button.BackColor = System.Drawing.Color.Firebrick;
            this.ClearBasket_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBasket_Button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBasket_Button.ForeColor = System.Drawing.Color.White;
            this.ClearBasket_Button.Location = new System.Drawing.Point(569, 505);
            this.ClearBasket_Button.Name = "ClearBasket_Button";
            this.ClearBasket_Button.Size = new System.Drawing.Size(139, 27);
            this.ClearBasket_Button.TabIndex = 18;
            this.ClearBasket_Button.Text = "Clear Basket";
            this.ClearBasket_Button.UseVisualStyleBackColor = false;
            this.ClearBasket_Button.Click += new System.EventHandler(this.ClearBasket_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.DimGray;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.ForeColor = System.Drawing.Color.White;
            this.Cancel_Button.Location = new System.Drawing.Point(736, 507);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(86, 25);
            this.Cancel_Button.TabIndex = 19;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.Location = new System.Drawing.Point(828, 507);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(81, 25);
            this.Exit_Button.TabIndex = 20;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Basket_Panel
            // 
            this.Basket_Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Basket_Panel.Controls.Add(this.Basket_DataGridView);
            this.Basket_Panel.Location = new System.Drawing.Point(12, 125);
            this.Basket_Panel.Name = "Basket_Panel";
            this.Basket_Panel.Size = new System.Drawing.Size(708, 362);
            this.Basket_Panel.TabIndex = 21;
            // 
            // Basket_DataGridView
            // 
            this.Basket_DataGridView.AllowUserToAddRows = false;
            this.Basket_DataGridView.AllowUserToDeleteRows = false;
            this.Basket_DataGridView.AllowUserToResizeColumns = false;
            this.Basket_DataGridView.AllowUserToResizeRows = false;
            this.Basket_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Basket_DataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Basket_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Basket_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Basket_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.Basket_DataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.Basket_DataGridView.Location = new System.Drawing.Point(3, 3);
            this.Basket_DataGridView.MultiSelect = false;
            this.Basket_DataGridView.Name = "Basket_DataGridView";
            this.Basket_DataGridView.ReadOnly = true;
            this.Basket_DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Basket_DataGridView.RowHeadersVisible = false;
            this.Basket_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Basket_DataGridView.Size = new System.Drawing.Size(702, 356);
            this.Basket_DataGridView.TabIndex = 22;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 50F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn3.FillWeight = 30F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn4.FillWeight = 30F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn5.FillWeight = 30F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn6.FillWeight = 150F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Basket_Label
            // 
            this.Basket_Label.AutoSize = true;
            this.Basket_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Basket_Label.Location = new System.Drawing.Point(11, 102);
            this.Basket_Label.Name = "Basket_Label";
            this.Basket_Label.Size = new System.Drawing.Size(57, 20);
            this.Basket_Label.TabIndex = 22;
            this.Basket_Label.Text = "Basket";
            // 
            // OrderBasket_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 544);
            this.Controls.Add(this.Basket_Label);
            this.Controls.Add(this.Basket_Panel);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.ClearBasket_Button);
            this.Controls.Add(this.RemoveItem_Button);
            this.Controls.Add(this.Price_Label);
            this.Controls.Add(this.Item_Label);
            this.Controls.Add(this.Quantity_Label);
            this.Controls.Add(this.Description_Label);
            this.Controls.Add(this.Item_Panel);
            this.Controls.Add(this.OrderSummary_Panel);
            this.Name = "OrderBasket_Form";
            this.Text = "OrderBasket_Form";
            this.OrderSummary_Panel.ResumeLayout(false);
            this.OrderSummary_Panel.PerformLayout();
            this.Item_Panel.ResumeLayout(false);
            this.Item_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_NumericUpDown)).EndInit();
            this.Basket_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Basket_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel OrderSummary_Panel;
        private System.Windows.Forms.Button Checkout_Button;
        private System.Windows.Forms.Label TotalCost_Label;
        private System.Windows.Forms.Label Total_Label;
        private System.Windows.Forms.Label Spacer1_Label;
        private System.Windows.Forms.Label OrderSummary_Label;
        private System.Windows.Forms.Label ProductsNumber_Label;
        private System.Windows.Forms.Label Products_Label;
        private System.Windows.Forms.Label Spacer2_Label;
        private System.Windows.Forms.Label ItemsNumber_Label;
        private System.Windows.Forms.Label Items_Label;
        private System.Windows.Forms.Label Spacer3_Label;
        private System.Windows.Forms.ComboBox Item_ComboBox;
        private System.Windows.Forms.TextBox Description_TextBox;
        private System.Windows.Forms.Panel Item_Panel;
        private System.Windows.Forms.TextBox Description_Label;
        private System.Windows.Forms.TextBox Quantity_Label;
        private System.Windows.Forms.TextBox Price_TextBox;
        private System.Windows.Forms.TextBox Item_Label;
        private System.Windows.Forms.TextBox Price_Label;
        private System.Windows.Forms.Button RemoveItem_Button;
        private System.Windows.Forms.Button ClearBasket_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Panel Basket_Panel;
        private System.Windows.Forms.DataGridView Basket_DataGridView;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.NumericUpDown Quantity_NumericUpDown;
        private System.Windows.Forms.Label Basket_Label;
    }
}
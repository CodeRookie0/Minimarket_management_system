namespace MIni_market_Managment_System
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_logout = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.textBox_billId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_seller = new System.Windows.Forms.Label();
            this.dataGridView_selllist = new System.Windows.Forms.DataGridView();
            this.button_addOrder = new System.Windows.Forms.Button();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.button_print = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.textBox_quanty = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label_quantity = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selllist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logout.ForeColor = System.Drawing.Color.Sienna;
            this.button_logout.Location = new System.Drawing.Point(-1, 585);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(187, 53);
            this.button_logout.TabIndex = 42;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            this.button_logout.MouseEnter += new System.EventHandler(this.button_logout_MouseEnter);
            this.button_logout.MouseLeave += new System.EventHandler(this.button_logout_MouseLeave);
            // 
            // label_exit
            // 
            this.label_exit.Font = new System.Drawing.Font("Segoe UI Black", 17.75F, System.Drawing.FontStyle.Bold);
            this.label_exit.ForeColor = System.Drawing.Color.Sienna;
            this.label_exit.Location = new System.Drawing.Point(1070, -2);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(31, 36);
            this.label_exit.TabIndex = 39;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.button_clear);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.textBox_billId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label_amount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label_seller);
            this.panel1.Controls.Add(this.dataGridView_selllist);
            this.panel1.Controls.Add(this.button_addOrder);
            this.panel1.Controls.Add(this.comboBox_category);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.dataGridView_product);
            this.panel1.Controls.Add(this.dataGridView_order);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button_print);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.textBox_quanty);
            this.panel1.Controls.Add(this.label_price);
            this.panel1.Controls.Add(this.textBox_price);
            this.panel1.Controls.Add(this.label_quantity);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Location = new System.Drawing.Point(187, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 601);
            this.panel1.TabIndex = 38;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BackColor = System.Drawing.Color.Sienna;
            this.label_date.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_date.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label_date.Location = new System.Drawing.Point(786, 9);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(0, 30);
            this.label_date.TabIndex = 40;
            // 
            // textBox_billId
            // 
            this.textBox_billId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_billId.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_billId.ForeColor = System.Drawing.Color.Black;
            this.textBox_billId.Location = new System.Drawing.Point(678, 324);
            this.textBox_billId.Name = "textBox_billId";
            this.textBox_billId.Size = new System.Drawing.Size(140, 28);
            this.textBox_billId.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Sienna;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label7.Location = new System.Drawing.Point(609, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 30);
            this.label7.TabIndex = 38;
            this.label7.Text = "Bill ID";
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.BackColor = System.Drawing.Color.Sienna;
            this.label_amount.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_amount.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label_amount.Location = new System.Drawing.Point(752, 250);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(34, 30);
            this.label_amount.TabIndex = 37;
            this.label_amount.Text = "0$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Sienna;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label6.Location = new System.Drawing.Point(556, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 30);
            this.label6.TabIndex = 36;
            this.label6.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Sienna;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label4.Location = new System.Drawing.Point(320, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 30);
            this.label4.TabIndex = 35;
            this.label4.Text = "Sells List";
            // 
            // label_seller
            // 
            this.label_seller.AutoSize = true;
            this.label_seller.BackColor = System.Drawing.Color.Sienna;
            this.label_seller.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_seller.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label_seller.Location = new System.Drawing.Point(12, 7);
            this.label_seller.Name = "label_seller";
            this.label_seller.Size = new System.Drawing.Size(116, 30);
            this.label_seller.TabIndex = 30;
            this.label_seller.Text = "SellerName";
            // 
            // dataGridView_selllist
            // 
            this.dataGridView_selllist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_selllist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_selllist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_selllist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_selllist.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView_selllist.Location = new System.Drawing.Point(325, 360);
            this.dataGridView_selllist.Name = "dataGridView_selllist";
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView_selllist.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView_selllist.Size = new System.Drawing.Size(562, 195);
            this.dataGridView_selllist.TabIndex = 34;
            // 
            // button_addOrder
            // 
            this.button_addOrder.FlatAppearance.BorderSize = 0;
            this.button_addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addOrder.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_addOrder.ForeColor = System.Drawing.Color.PapayaWhip;
            this.button_addOrder.Location = new System.Drawing.Point(86, 192);
            this.button_addOrder.Name = "button_addOrder";
            this.button_addOrder.Size = new System.Drawing.Size(151, 44);
            this.button_addOrder.TabIndex = 33;
            this.button_addOrder.Text = "Add Order";
            this.button_addOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_addOrder.UseVisualStyleBackColor = true;
            this.button_addOrder.Click += new System.EventHandler(this.button_addOrder_Click);
            // 
            // comboBox_category
            // 
            this.comboBox_category.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_category.ForeColor = System.Drawing.Color.Sienna;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(12, 321);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(190, 31);
            this.comboBox_category.TabIndex = 32;
            this.comboBox_category.Text = "Select Category";
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Sienna;
            this.label43.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label43.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label43.Location = new System.Drawing.Point(724, 9);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(56, 30);
            this.label43.TabIndex = 31;
            this.label43.Text = "Date:";
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_product.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_product.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_product.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView_product.Location = new System.Drawing.Point(12, 360);
            this.dataGridView_product.Name = "dataGridView_product";
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView_product.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView_product.Size = new System.Drawing.Size(275, 232);
            this.dataGridView_product.TabIndex = 29;
            this.dataGridView_product.Click += new System.EventHandler(this.dataGridView_product_Click);
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_order.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_order.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.ProdQty,
            this.Total});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_order.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView_order.Location = new System.Drawing.Point(325, 54);
            this.dataGridView_order.Name = "dataGridView_order";
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView_order.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView_order.Size = new System.Drawing.Size(562, 193);
            this.dataGridView_order.TabIndex = 27;
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.Name = "ProdId";
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.Name = "ProdName";
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "ProdPrice";
            this.ProdPrice.Name = "ProdPrice";
            // 
            // ProdQty
            // 
            this.ProdQty.HeaderText = "ProdQty";
            this.ProdQty.Name = "ProdQty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Sienna;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label5.Location = new System.Drawing.Point(411, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 39);
            this.label5.TabIndex = 26;
            this.label5.Text = "SELLING";
            // 
            // button_print
            // 
            this.button_print.FlatAppearance.BorderSize = 0;
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_print.ForeColor = System.Drawing.Color.PapayaWhip;
            this.button_print.Location = new System.Drawing.Point(788, 558);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(99, 43);
            this.button_print.TabIndex = 23;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_add
            // 
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.ForeColor = System.Drawing.Color.PapayaWhip;
            this.button_add.Location = new System.Drawing.Point(824, 312);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(63, 40);
            this.button_add.TabIndex = 22;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_refresh.ForeColor = System.Drawing.Color.PapayaWhip;
            this.button_refresh.Location = new System.Drawing.Point(208, 315);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(99, 44);
            this.button_refresh.TabIndex = 11;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // textBox_quanty
            // 
            this.textBox_quanty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_quanty.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_quanty.ForeColor = System.Drawing.Color.Black;
            this.textBox_quanty.Location = new System.Drawing.Point(117, 156);
            this.textBox_quanty.Name = "textBox_quanty";
            this.textBox_quanty.Size = new System.Drawing.Size(190, 28);
            this.textBox_quanty.TabIndex = 18;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.BackColor = System.Drawing.Color.Sienna;
            this.label_price.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_price.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label_price.Location = new System.Drawing.Point(12, 105);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(54, 30);
            this.label_price.TabIndex = 17;
            this.label_price.Text = "Price";
            // 
            // textBox_price
            // 
            this.textBox_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_price.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_price.ForeColor = System.Drawing.Color.Black;
            this.textBox_price.Location = new System.Drawing.Point(117, 105);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.Size = new System.Drawing.Size(190, 28);
            this.textBox_price.TabIndex = 16;
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.BackColor = System.Drawing.Color.Sienna;
            this.label_quantity.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_quantity.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label_quantity.Location = new System.Drawing.Point(12, 156);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(83, 30);
            this.label_quantity.TabIndex = 15;
            this.label_quantity.Text = "Quantity";
            // 
            // textBox_name
            // 
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_name.ForeColor = System.Drawing.Color.Black;
            this.textBox_name.Location = new System.Drawing.Point(117, 54);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(190, 28);
            this.textBox_name.TabIndex = 14;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Sienna;
            this.label_name.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label_name.Location = new System.Drawing.Point(12, 54);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(62, 30);
            this.label_name.TabIndex = 13;
            this.label_name.Text = "Name";
            // 
            // button_clear
            // 
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_clear.ForeColor = System.Drawing.Color.PapayaWhip;
            this.button_clear.Location = new System.Drawing.Point(325, 250);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(99, 45);
            this.button_clear.TabIndex = 41;
            this.button_clear.Text = "Clear";
            this.button_clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            this.button_clear.MouseEnter += new System.EventHandler(this.button_clear_MouseEnter);
            this.button_clear.MouseLeave += new System.EventHandler(this.button_clear_MouseLeave);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selllist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.TextBox textBox_quanty;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label_seller;
        private System.Windows.Forms.DataGridView dataGridView_product;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_selllist;
        private System.Windows.Forms.Button button_addOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox textBox_billId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Button button_clear;
    }
}
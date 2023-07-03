namespace MIni_market_Managment_System
{
    partial class SellerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_category = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_selling = new System.Windows.Forms.Button();
            this.button_product = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_passwd = new System.Windows.Forms.TextBox();
            this.dataGridView_seller = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label_age = new System.Windows.Forms.Label();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seller)).BeginInit();
            this.SuspendLayout();
            // 
            // button_category
            // 
            this.button_category.FlatAppearance.BorderSize = 0;
            this.button_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_category.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_category.ForeColor = System.Drawing.Color.Sienna;
            this.button_category.Location = new System.Drawing.Point(-1, 178);
            this.button_category.Name = "button_category";
            this.button_category.Size = new System.Drawing.Size(187, 53);
            this.button_category.TabIndex = 37;
            this.button_category.Text = "Category";
            this.button_category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_category.UseVisualStyleBackColor = true;
            this.button_category.Click += new System.EventHandler(this.button_category_Click);
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
            this.button_logout.TabIndex = 36;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            this.button_logout.MouseEnter += new System.EventHandler(this.button_logout_MouseEnter);
            this.button_logout.MouseLeave += new System.EventHandler(this.button_logout_MouseLeave);
            // 
            // button_selling
            // 
            this.button_selling.FlatAppearance.BorderSize = 0;
            this.button_selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selling.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_selling.ForeColor = System.Drawing.Color.Sienna;
            this.button_selling.Location = new System.Drawing.Point(-1, 254);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(187, 53);
            this.button_selling.TabIndex = 35;
            this.button_selling.Text = "Selling";
            this.button_selling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_selling.UseVisualStyleBackColor = true;
            this.button_selling.Click += new System.EventHandler(this.button_selling_Click);
            // 
            // button_product
            // 
            this.button_product.FlatAppearance.BorderSize = 0;
            this.button_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_product.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_product.ForeColor = System.Drawing.Color.Sienna;
            this.button_product.Location = new System.Drawing.Point(-1, 102);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(187, 53);
            this.button_product.TabIndex = 34;
            this.button_product.Text = "Product";
            this.button_product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_product.UseVisualStyleBackColor = true;
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // label_exit
            // 
            this.label_exit.Font = new System.Drawing.Font("Segoe UI Black", 17.75F, System.Drawing.FontStyle.Bold);
            this.label_exit.ForeColor = System.Drawing.Color.Sienna;
            this.label_exit.Location = new System.Drawing.Point(1070, -2);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(31, 36);
            this.label_exit.TabIndex = 33;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.textBox_passwd);
            this.panel1.Controls.Add(this.dataGridView_seller);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_phone);
            this.panel1.Controls.Add(this.label_age);
            this.panel1.Controls.Add(this.textBox_age);
            this.panel1.Controls.Add(this.label_phone);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(187, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 601);
            this.panel1.TabIndex = 32;
            // 
            // textBox_passwd
            // 
            this.textBox_passwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_passwd.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_passwd.ForeColor = System.Drawing.Color.Black;
            this.textBox_passwd.Location = new System.Drawing.Point(126, 316);
            this.textBox_passwd.Name = "textBox_passwd";
            this.textBox_passwd.Size = new System.Drawing.Size(190, 28);
            this.textBox_passwd.TabIndex = 28;
            // 
            // dataGridView_seller
            // 
            this.dataGridView_seller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_seller.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_seller.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_seller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_seller.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_seller.Location = new System.Drawing.Point(343, 106);
            this.dataGridView_seller.Name = "dataGridView_seller";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView_seller.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_seller.Size = new System.Drawing.Size(546, 483);
            this.dataGridView_seller.TabIndex = 27;
            this.dataGridView_seller.Click += new System.EventHandler(this.dataGridView_seller_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Sienna;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label5.Location = new System.Drawing.Point(344, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 39);
            this.label5.TabIndex = 26;
            this.label5.Text = "MANAGE SELLER";
            // 
            // button_delete
            // 
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_delete.ForeColor = System.Drawing.Color.PapayaWhip;
            this.button_delete.Location = new System.Drawing.Point(220, 373);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(99, 53);
            this.button_delete.TabIndex = 23;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_update.ForeColor = System.Drawing.Color.PapayaWhip;
            this.button_update.Location = new System.Drawing.Point(117, 373);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(99, 53);
            this.button_update.TabIndex = 22;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.ForeColor = System.Drawing.Color.PapayaWhip;
            this.button_add.Location = new System.Drawing.Point(14, 373);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(99, 53);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Sienna;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label4.Location = new System.Drawing.Point(21, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password";
            // 
            // textBox_phone
            // 
            this.textBox_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_phone.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_phone.ForeColor = System.Drawing.Color.Black;
            this.textBox_phone.Location = new System.Drawing.Point(126, 265);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(190, 28);
            this.textBox_phone.TabIndex = 18;
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.BackColor = System.Drawing.Color.Sienna;
            this.label_age.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_age.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label_age.Location = new System.Drawing.Point(21, 214);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(44, 30);
            this.label_age.TabIndex = 17;
            this.label_age.Text = "Age";
            // 
            // textBox_age
            // 
            this.textBox_age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_age.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_age.ForeColor = System.Drawing.Color.Black;
            this.textBox_age.Location = new System.Drawing.Point(126, 214);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(190, 28);
            this.textBox_age.TabIndex = 16;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.BackColor = System.Drawing.Color.Sienna;
            this.label_phone.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_phone.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label_phone.Location = new System.Drawing.Point(21, 265);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(94, 30);
            this.label_phone.TabIndex = 15;
            this.label_phone.Text = "Phone No";
            // 
            // textBox_name
            // 
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_name.ForeColor = System.Drawing.Color.Black;
            this.textBox_name.Location = new System.Drawing.Point(126, 163);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(190, 28);
            this.textBox_name.TabIndex = 14;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Sienna;
            this.label_name.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label_name.Location = new System.Drawing.Point(21, 163);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(62, 30);
            this.label_name.TabIndex = 13;
            this.label_name.Text = "Name";
            // 
            // textBox_id
            // 
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_id.ForeColor = System.Drawing.Color.Black;
            this.textBox_id.Location = new System.Drawing.Point(126, 112);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(190, 28);
            this.textBox_id.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label1.Location = new System.Drawing.Point(21, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.button_category);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.button_product);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_selling;
        private System.Windows.Forms.Button button_product;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_seller;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_passwd;
    }
}
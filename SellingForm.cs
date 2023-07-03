using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace MIni_market_Managment_System
{
    public partial class SellingForm : Form
    {
        DBConnect dbCon=new DBConnect();
        DGVPrinter printer = new DGVPrinter();
        public SellingForm()
        {
            InitializeComponent();
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_date.Text =DateTime.Today.ToShortDateString();
            label_seller.Text = LoginForm.sellerName;
            getTable();
            GetCategory();
            getSellTable();
        }
        private void GetCategory()
        {
            string selectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "CatName";
        }
        private void getTable()
        {
            string selectQuerry = "SELECT ProdName, ProdPrice FROM Product";
            SqlCommand command = new SqlCommand(selectQuerry, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }
        private void clear()
        {
            textBox_quanty.Text = "";
            textBox_name.Text = "";
            textBox_price.Text = "";
        }
        private void button_product_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.Show();
            this.Hide();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            form.Show();
            this.Hide();
        }

        private void button_seller_Click(object sender, EventArgs e)
        {
            SellerForm form = new SellerForm();
            form.Show();
            this.Hide();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button_logout_MouseEnter(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Red;
        }

        private void button_logout_MouseLeave(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Sienna;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Sienna;
        }

        private void dataGridView_product_Click(object sender, EventArgs e)
        {
            textBox_name.Text = dataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            textBox_price.Text = dataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
        }

        int grandTotal = 0, n = 0;

        private void getSellTable()
        {
            string selectQuerry = "SELECT * FROM Bill";
            SqlCommand command = new SqlCommand(selectQuerry, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_selllist.DataSource = table;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_billId.Text == "" || label_seller.Text == "" || label_date.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string insertQuery = "INSERT INTO Bill VALUES(" + textBox_billId.Text + ",'" + label_seller.Text + "','" + label_date.Text + "','" + grandTotal.ToString()+ "')";
                    SqlCommand command = new SqlCommand(insertQuery, dbCon.GetCon());
                    dbCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Bill Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbCon.CloseCon();
                    getSellTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title="MariaSH MiniMarket Sell List";
            printer.SubTitle = string.Format("Date:{0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintPreviewDataGridView(dataGridView_selllist);
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT ProdName,ProdPrice FROM Product WHERE ProdCat='" + comboBox_category.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(selectQuerry, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            dataGridView_order.Rows.Clear();
            dataGridView_order.Refresh();
            label_amount.Text = "0$";
        }

        private void button_clear_MouseEnter(object sender, EventArgs e)
        {
            button_clear.ForeColor = Color.Red;
        }

        private void button_clear_MouseLeave(object sender, EventArgs e)
        {
            button_clear.ForeColor = Color.PapayaWhip;
        }

        private void button_addOrder_Click(object sender, EventArgs e)
        {
            if (textBox_quanty.Text == "")
            {
                MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                int total = Convert.ToInt32(textBox_price.Text) * Convert.ToInt32(textBox_quanty.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(dataGridView_order);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = textBox_name.Text;
                addRow.Cells[2].Value = textBox_price.Text;
                addRow.Cells[3].Value = textBox_quanty.Text;
                addRow.Cells[4].Value = total;
                dataGridView_order.Rows.Add(addRow);
                grandTotal += total;
                label_amount.Text = grandTotal.ToString() + "$";
                clear();
            }
        }
    }
}

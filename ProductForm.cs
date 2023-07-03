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

namespace MIni_market_Managment_System
{
    public partial class ProductForm : Form
    {
        DBConnect dBcon=new DBConnect();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            GetCategory();
            getTable();
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
        private void GetCategory()
        {
            string selectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBcon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "CatName";
            comboBox_search.DataSource = table;
            comboBox_search.ValueMember = "CatName";
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }
        private void clear()
        {
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_price.Clear();
            textBox_quantity.Clear();
            comboBox_category.SelectedIndex = 0;
        }
        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Product";
            SqlCommand command = new SqlCommand(selectQuerry, dBcon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_id.Text == "" || textBox_name.Text == "" || textBox_price.Text == "" || textBox_quantity.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string insertQuery = "INSERT INTO Product VALUES(" + textBox_id.Text + ",'" + textBox_name.Text + "','" + textBox_price.Text + "','" + textBox_quantity.Text + "','" + comboBox_category.Text + "')";
                    SqlCommand command = new SqlCommand(insertQuery, dBcon.GetCon());
                    dBcon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBcon.CloseCon();
                    clear();
                    getTable();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_id.Text == "" || textBox_name.Text == "" || textBox_price.Text == ""||textBox_quantity.Text=="")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Product SET ProdName='" + textBox_name.Text + "', ProdPrice=" + textBox_price.Text + ",ProdQty = " + textBox_quantity.Text +",ProdCat='"+comboBox_category.Text+ "' WHERE ProdId=" + textBox_id.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBcon.GetCon());
                    dBcon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBcon.CloseCon();
                    clear();
                    getTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_id.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        string deleteQuery = "DELETE FROM Product WHERE ProdId=" + textBox_id.Text + "";
                        SqlCommand command = new SqlCommand(deleteQuery, dBcon.GetCon());
                        dBcon.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Product Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dBcon.CloseCon();
                        clear();
                        getTable();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_product_Click(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            textBox_name.Text = dataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
            textBox_price.Text = dataGridView_product.SelectedRows[0].Cells[2].Value.ToString();
            textBox_quantity.Text = dataGridView_product.SelectedRows[0].Cells[3].Value.ToString();
            comboBox_category.SelectedValue = dataGridView_product.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
            comboBox_category.SelectedIndex = 0;
            comboBox_search.SelectedIndex = 0;
        }

        private void comboBox_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT * FROM Product WHERE ProdCat='"+comboBox_search.SelectedValue.ToString()+"'";
            SqlCommand command = new SqlCommand(selectQuerry, dBcon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }

        private void button_seller_Click(object sender, EventArgs e)
        {
            SellerForm form = new SellerForm();
            form.Show();
            this.Hide();
        }

        private void button_selling_Click(object sender, EventArgs e)
        {
            SellingForm form = new SellingForm();
            form.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MIni_market_Managment_System
{
    public partial class CategoryForm : Form
    {
        DBConnect dbConnect = new DBConnect();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
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

        private void button_product_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
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

        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Category";
            SqlCommand command=new SqlCommand(selectQuerry,dbConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_category.DataSource = table;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_id.Text == "" || textBox_name.Text == "" || textBox_descript.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string insertQuery = "INSERT INTO Category VALUES (" + textBox_id.Text + ",'" + textBox_name.Text + "','" + textBox_descript.Text + "')";
                    SqlCommand command = new SqlCommand(insertQuery, dbConnect.GetCon());
                    dbConnect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbConnect.CloseCon();
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
                if (textBox_id.Text == "" || textBox_name.Text == "" || textBox_descript.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Category SET CatName='" + textBox_name.Text + "', CatDesc='" + textBox_descript.Text + "'WHERE CatId=" + textBox_id.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dbConnect.GetCon());
                    dbConnect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbConnect.CloseCon();
                    clear();
                    getTable();
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message );
            }
        }

        private void dataGridView_category_Click(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_category.SelectedRows[0].Cells[0].Value.ToString();
            textBox_name.Text = dataGridView_category.SelectedRows[0].Cells[1].Value.ToString();
            textBox_descript.Text = dataGridView_category.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void clear()
        {
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_descript.Clear();
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
                        string deleteQuery = "DELETE FROM Category WHERE CatId=" + textBox_id.Text + "";
                        SqlCommand command = new SqlCommand(deleteQuery, dbConnect.GetCon());
                        dbConnect.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Category Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbConnect.CloseCon();
                        clear();
                        getTable();
                    }
                }
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
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

        private void dataGridView_category_Click_1(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_category.SelectedRows[0].Cells[0].Value.ToString();
            textBox_name.Text = dataGridView_category.SelectedRows[0].Cells[1].Value.ToString();
            textBox_descript.Text= dataGridView_category.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}

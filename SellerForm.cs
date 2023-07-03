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
    public partial class SellerForm : Form
    {
        DBConnect dbCon = new DBConnect(); 
        public SellerForm()
        {
            InitializeComponent();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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
        private void clear()
        {
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_age.Clear();
            textBox_phone.Clear();
            textBox_passwd.Clear();
        }
        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Seller";
            SqlCommand command = new SqlCommand(selectQuerry, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_seller.DataSource = table;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_id.Text == "" || textBox_name.Text == "" || textBox_age.Text == "" || textBox_phone.Text == "" || textBox_passwd.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string insertQuery = "INSERT INTO Seller VALUES(" + textBox_id.Text + ",'" + textBox_name.Text + "','" + textBox_age.Text + "','" + textBox_phone.Text + "','" + textBox_passwd.Text + "')";
                    SqlCommand command = new SqlCommand(insertQuery, dbCon.GetCon());
                    dbCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seller Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbCon.CloseCon();
                    clear();
                    getTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_id.Text == "" || textBox_name.Text == "" || textBox_age.Text == "" || textBox_phone.Text == "" || textBox_passwd.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Seller SET SellerName='" + textBox_name.Text + "', SellerAge=" + textBox_age.Text + ",SellerPhone = " + textBox_phone.Text + ",SellerPass='" + textBox_passwd.Text + "' WHERE SellerId=" + textBox_id.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dbCon.GetCon());
                    dbCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbCon.CloseCon();
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
                        string deleteQuery = "DELETE FROM Seller WHERE SellerId=" + textBox_id.Text + "";
                        SqlCommand command = new SqlCommand(deleteQuery, dbCon.GetCon());
                        dbCon.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Seller Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbCon.CloseCon();
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

        private void dataGridView_seller_Click(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_seller.SelectedRows[0].Cells[0].Value.ToString();
            textBox_name.Text = dataGridView_seller.SelectedRows[0].Cells[1].Value.ToString();
            textBox_age.Text = dataGridView_seller.SelectedRows[0].Cells[2].Value.ToString();
            textBox_phone.Text = dataGridView_seller.SelectedRows[0].Cells[3].Value.ToString();
            textBox_passwd.Text = dataGridView_seller.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            ProductForm Form = new ProductForm();
            Form.Show();
            this.Hide();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoryForm Form = new CategoryForm();
            Form.Show();
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

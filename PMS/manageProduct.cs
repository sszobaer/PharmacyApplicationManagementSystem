using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class manageProduct : Form
    {
        Functions con;
        public manageProduct()
        {
            InitializeComponent();
            con = new Functions();
            ConfigureDataGridView();
            showProducts();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Home.stack.Push(this);
            this.Hide();
            home.ShowDialog();
        }

        private void rewuestOrderBtn_Click(object sender, EventArgs e)
        {
            requestOrder ro = new requestOrder();
            Home.stack.Push(this);
            this.Hide();
            ro.ShowDialog();
        }

        private void offersBtn_Click(object sender, EventArgs e)
        {
            offer offer = new offer();
            Home.stack.Push(this);
            this.Hide();
            offer.ShowDialog();
        }

        private void locationBtn_Click(object sender, EventArgs e)
        {
            location location = new location();
            Home.stack.Push(this);
            this.Hide();
            location.ShowDialog();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            About about = new About();
            Home.stack.Push(this);
            this.Hide();
            about.ShowDialog();
        }

        private void contactsBtn_Click(object sender, EventArgs e)
        {
            Contacts contacts = new Contacts();
            Home.stack.Push(this);
            this.Hide();
            contacts.ShowDialog();
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            Home.stack.Push(this);
            this.Hide();
            cart.ShowDialog();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            adminDashboard adminDashboard = new adminDashboard();
            Home.stack.Push(this);
            this.Hide();
            adminDashboard.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            Home.stack.Push(this);
            this.Hide();
            employee.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            Home.stack.Push(this);
            this.Hide();
            department.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            salary salary = new salary();
            Home.stack.Push(this);
            this.Hide();
            salary.ShowDialog();
        }

        private void ConfigureDataGridView()
        {
            // Set alternating row colors for readability
            productList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Set header styles
            productList.EnableHeadersVisualStyles = false;
            productList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            productList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            productList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Set grid line color
            productList.GridColor = Color.Black;

            // Set default row styles
            productList.DefaultCellStyle.BackColor = Color.White;
            productList.DefaultCellStyle.ForeColor = Color.Black;
            productList.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Set selection styles
            productList.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            productList.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fit columns to the DataGridView
            productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adjust row height to fit content
            productList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Disable column resize by the user for a consistent layout
            productList.AllowUserToResizeColumns = false;

            // Set row and column headers visibility if needed
            productList.RowHeadersVisible = false;
            productList.ColumnHeadersVisible = true;
        }


        int key = 0;
        private void productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtproductId.Text = productList.SelectedRows[0].Cells[0].Value.ToString();
            txtProductName.Text = productList.SelectedRows[0].Cells[1].Value.ToString();
            txtProductPrice.Text = productList.SelectedRows[0].Cells[2].Value.ToString();
            key = txtproductId.Text == "" ? 0 : Convert.ToInt32(productList.SelectedRows[0].Cells[0].Value.ToString());
        }
        public void ClearFields()
        {
            txtproductId.Text = "";
            txtProductName.Text = "";
            txtProductPrice.Text = "";
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            key = 0;
            try
            {
                if (txtproductId.Text == "" || txtProductName.Text =="" || txtProductPrice.Text == "")
                {
                    MessageBox.Show("Data missing!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string productName = txtProductName.Text;
                double productPrice = Convert.ToDouble(txtProductPrice.Text);
                int productId = int.Parse(txtproductId.Text);

                string Query = "INSERT INTO mProduct VALUES (@pID, @pName, @pPrice)";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@pID", productId},
                    {"@pName", productName },
                    {"@pPrice", productPrice}
                };

                con.setData(Query, parameters);
                showProducts();
                MessageBox.Show("New product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void showProducts()
        {
            string Query = "SELECT * FROM mProduct";
            productList.DataSource = con.GetData(Query);
        }
        
        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtproductId.Text == "" || txtProductName.Text == "" || txtProductPrice.Text == "")
                {
                    MessageBox.Show("Data missing!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string productName = txtProductName.Text;
                double productPrice = Convert.ToDouble(txtProductPrice.Text);
                int productId = int.Parse(txtproductId.Text);

                string Query = "UPDATE mProduct SET pName = @pName, price = @price WHERE pID = @pID";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@pID", productId },
                    {"@pName", productName},
                    {"@price", productPrice}
                };

                con.setData(Query, parameters);
                showProducts();
                MessageBox.Show("Product's info updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtproductId.Text == "" || txtProductName.Text == "" || txtProductPrice.Text == "")
                {
                    MessageBox.Show("Data missing!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int productId = int.Parse(txtproductId.Text);
                string Query = "DELETE FROM mProduct WHERE pID = @pid";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@pID", productId }
                };
                con.setData(Query, parameters);
                showProducts();
                MessageBox.Show("The Item is deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

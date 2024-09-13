using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace PMS
{
    public partial class Cart : Form
    { 
        Functions con;
        int selectedPID = 0;
        public Cart()
        {
            InitializeComponent();
            ConfigureDataGridView();
            con = new Functions();
            showData();
        }

        string currentUsername = sessionManager.Username;
        private void ConfigureDataGridView()
        {
            cartList.CellContentClick += new DataGridViewCellEventHandler(cartList_CellContentClick);

            // Set alternating row colors for readability
            cartList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Set header styles
            cartList.EnableHeadersVisualStyles = false;
            cartList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            cartList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            cartList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Set grid line color
            cartList.GridColor = Color.Black;

            // Set default row styles
            cartList.DefaultCellStyle.BackColor = Color.White;
            cartList.DefaultCellStyle.ForeColor = Color.Black;
            cartList.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Set selection styles
            cartList.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            cartList.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fit columns to the DataGridView
            cartList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adjust row height to fit content
            cartList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Disable column resize by the user for a consistent layout
            cartList.AllowUserToResizeColumns = false;

            // Set row and column headers visibility if needed
            cartList.RowHeadersVisible = false;
            cartList.ColumnHeadersVisible = true;
        }
        private void showData()
        {
            string Query = "SELECT * FROM ProductTable WHERE username = @username";
            var parameters = new Dictionary<string, object>
            {
                {"@username", currentUsername }
            };
            cartList.DataSource = con.GetData(Query, parameters);
        }
        int key = 0;
        private void cartList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Assuming the delete button is in the first column
            {
                // Get the selected product ID
                var selectedRow = cartList.Rows[e.RowIndex];
                string productID = selectedRow.Cells["pID"].Value.ToString(); // Assuming column name is "pID"

                // Store and format the product ID
                if (IsValidProductID(productID))
                {
                    selectedPID = int.Parse(productID.Replace("p-", ""));
                }
                else
                {
                    MessageBox.Show("Invalid product ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SumPrices()
        {
            double sum = 0;
            foreach (DataGridViewRow row in cartList.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    double value;
                    if (double.TryParse(row.Cells[2].Value.ToString(), out value))
                    {
                        sum += value;
                    }
                }
            }

            MessageBox.Show($"Your total bill is: {sum} bdt", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedPID == 0)
                {
                    MessageBox.Show("No item selected for deletion.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string productID = FormatProductID(selectedPID); // Format ID as 'p-XXX
                string Query = "DELETE FROM ProductTable WHERE pID = @pID";
                var parameters = new Dictionary<string, object>
                {
                    { "@pID", productID }
                };

                con.setData(Query, parameters);
                showData();
                //Debugging
                MessageBox.Show("Item deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedPID = 0; // Reset
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string FormatProductID(int id)
        {
            return $"p-{id:D3}"; // Format integer as 'p-XXX' with leading zeros if necessary
        }

        private bool IsValidProductID(string pID)
        {
            string pattern = @"^p-\d{3}$"; // Pattern for 'p-XXX' where XXX is exactly three digits
            Regex regex = new Regex(pattern);
            return regex.IsMatch(pID);
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

        private void orderBtn_Click(object sender, EventArgs e)
        {
            SumPrices();
            payment payment = new payment();
            this.Hide();
            payment.ShowDialog();
        }
    }
}

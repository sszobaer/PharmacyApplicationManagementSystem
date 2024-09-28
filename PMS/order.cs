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
    public partial class order : Form
    {
        Functions con;
        public order()
        {
            InitializeComponent();
            con = new Functions();
            ConfigureDataGridView();
            showData();
        }
        private void ConfigureDataGridView()
        {

            // Set alternating row colors for readability
            orderTable.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Set header styles
            orderTable.EnableHeadersVisualStyles = false;
            orderTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            orderTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            orderTable.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Set grid line color
            orderTable.GridColor = Color.Black;

            // Set default row styles
            orderTable.DefaultCellStyle.BackColor = Color.White;
            orderTable.DefaultCellStyle.ForeColor = Color.Black;
            orderTable.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Set selection styles
            orderTable.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            orderTable.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fit columns to the DataGridView
            orderTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adjust row height to fit content
            orderTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Disable column resize by the user for a consistent layout
            orderTable.AllowUserToResizeColumns = false;

            // Set row and column headers visibility if needed
            orderTable.RowHeadersVisible = false;
            orderTable.ColumnHeadersVisible = true;
        }
        string currentUsername = sessionManager.Username;
        private void showData()
        {
            string Query = "SELECT * FROM ProductTable WHERE username = @username";
            var parameters = new Dictionary<string, object>
            {
                {"@username", currentUsername },
                
            };
            orderTable.DataSource = con.GetData(Query, parameters);
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
    }
}

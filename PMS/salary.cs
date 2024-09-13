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
    public partial class salary : Form
    {
        Functions con;
        public salary()
        {
            InitializeComponent();
            con = new Functions();
            ConfigureDataGridView();
            showSalaries();
            GetEmployee();
        }
        private void showSalaries()
        {
            string Query = "SELECT * FROM SalaryTable";
            salList.DataSource = con.GetData(Query);
        }
        private void GetEmployee()
        {
            string Query = "SELECT * FROM EmployeeTable";
            DataTable dt = con.GetData(Query);
            empCb.DisplayMember = "empName";
            empCb.ValueMember = "empID";
            empCb.DataSource = dt;
        }
        int dailySal = 0;
        string period = "";
        private void GetSalary()
        {
            try
            {
                // Check if an employee is selected
                if (empCb.SelectedValue == null)
                {
                    MessageBox.Show("Please select an employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Retrieve daily salary of the selected employee
                string Query = "SELECT empSal FROM EmployeeTable WHERE empID = @ID";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@ID", empCb.SelectedValue.ToString()}
                };

                DataTable dt = con.GetData(Query, parameters);

                if (dt.Rows.Count > 0)
                {
                    dailySal = Convert.ToInt32(dt.Rows[0]["empSal"]);
                }
                else
                {
                    MessageBox.Show("Employee salary not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate the salary based on attendance
                if (string.IsNullOrWhiteSpace(txtAttendence.Text))
                {
                    txtAmount.Text = "Bdt" + (d * dailySal);
                }
                else if (!int.TryParse(txtAttendence.Text, out int attendance) || attendance > 31)
                {
                    MessageBox.Show("Invalid attendance value. It must be a number between 0 and 31.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    d = attendance;
                    txtAmount.Text = "Bdt" + (d * dailySal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int d = 0;
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (empCb.SelectedIndex == -1 || string.IsNullOrEmpty(txtAttendence.Text) || string.IsNullOrEmpty(periodDTP.Text))
                {
                    MessageBox.Show("Data missing!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Format period
                period = $"{periodDTP.Value.Date.Month}-{periodDTP.Value.Date.Year}";

                // Parse attendance and calculate amount
                if (!int.TryParse(txtAttendence.Text, out int Attendance) || Attendance < 0 || Attendance > 31)
                {
                    MessageBox.Show("Invalid attendance value. It must be a number between 0 and 31.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int Amount = dailySal * Attendance;

                // Prepare query and parameters
                string Query = "INSERT INTO SalaryTable (employee, attendence, period, amount, payDate) VALUES (@employee, @attendence, @period, @amount, @payDate)";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@employee", empCb.SelectedValue.ToString()},
                    {"@attendence", Attendance},
                    {"@period", period},
                    {"@amount", Amount},
                    {"@payDate", DateTime.Today}
                };

                // Execute query
                int rowsAffected = con.setData(Query, parameters);

                if (rowsAffected > 0)
                {
                    showSalaries();
                    MessageBox.Show("Salary Paid", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAttendence.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to add salary record.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int key = 0;
        private void salList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            empCb.Text = salList.SelectedRows[0].Cells[1].Value.ToString();
            txtAttendence.Text = salList.SelectedRows[0].Cells[2].Value.ToString();
            periodDTP.Text = salList.SelectedRows[0].Cells[3].Value.ToString();
            txtAmount.Text = salList.SelectedRows[0].Cells[4].Value.ToString();
            
            key = txtAttendence.Text == "" ? 0 : Convert.ToInt32(salList.SelectedRows[0].Cells[0].Value.ToString());
        }
  
        private void ConfigureDataGridView()
        {
            // Set alternating row colors for readability
            salList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Set header styles
            salList.EnableHeadersVisualStyles = false;
            salList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            salList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            salList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Set grid line color
            salList.GridColor = Color.Black;

            // Set default row styles
            salList.DefaultCellStyle.BackColor = Color.White;
            salList.DefaultCellStyle.ForeColor = Color.Black;
            salList.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Set selection styles
            salList.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            salList.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fit columns to the DataGridView
            salList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adjust row height to fit content
            salList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Disable column resize by the user
            salList.AllowUserToResizeColumns = false;

            // Set row and column headers visibility
            salList.RowHeadersVisible = false;
            salList.ColumnHeadersVisible = true;
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

        private void label18_Click(object sender, EventArgs e)
        {
            Home fm = new Home();
            Home.stack.Push(this);
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            requestOrder ro = new requestOrder();
            Home.stack.Push(this);
            this.Hide();
            ro.ShowDialog();
            this.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            offer of = new offer();
            Home.stack.Push(this);
            this.Hide();
            of.ShowDialog();
            this.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            location lc = new location();
            Home.stack.Push(this);
            this.Hide();
            lc.ShowDialog();
            this.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Contacts cn = new Contacts();
            Home.stack.Push(this);
            this.Hide();
            cn.ShowDialog();
            this.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            adminDashboard ad = new adminDashboard();
            Home.stack.Push(this);
            this.Hide();
            ad.ShowDialog();
            this.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            Home.stack.Push(this);
            this.Hide();
            employee.ShowDialog();
            this.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Department dept = new Department();
            Home.stack.Push(this);
            this.Hide();
            dept.ShowDialog();
            this.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            salary sal = new salary();
            Home.stack.Push(this);
            this.Hide();
            sal.ShowDialog();
            this.Show();
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            label18.ForeColor = Color.OrangeRed;
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label18.ForeColor = Color.Black;
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            label17.ForeColor = Color.OrangeRed;
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.ForeColor = Color.Black;
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            label16.ForeColor = Color.OrangeRed;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.ForeColor = Color.Black;
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.ForeColor = Color.OrangeRed;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.ForeColor = Color.Black;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label14.ForeColor = Color.OrangeRed;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Black;
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            label13.ForeColor = Color.OrangeRed;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.ForeColor = Color.Black;
        }

        private void empCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            if (sessionManager.IsLoggedIn)
            {
                Cart cart = new Cart();
                Home.stack.Push(this);
                this.Hide();
                cart.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please login or Sign up", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            ddMenu.Visible = !ddMenu.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prescriptionMedicine prescriptionMedicine = new prescriptionMedicine();
            Home.stack.Push(this);
            this.Hide();
            prescriptionMedicine.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            surgicalProduct prescription = new surgicalProduct();
            Home.stack.Push(this);
            this.Hide();
            prescription.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            otcMedicine otcMedicine = new otcMedicine();
            Home.stack.Push(this);
            this.Hide();
            otcMedicine.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            babyCare babyCare = new babyCare();
            Home.stack.Push(this);
            this.Hide();
            babyCare.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            About about = new About();
            Home.stack.Push(this);
            this.Hide();
            about.ShowDialog();
        }
    }
}

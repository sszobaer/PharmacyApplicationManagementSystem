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
    public partial class Employee : Form
    {
        Functions con;
        public Employee()
        {
            InitializeComponent();
            con = new Functions();
            ConfigureDataGridView();
            showEmployees();
            GetDept();
        }

        private void showEmployees()
        {
            string Query = "SELECT * FROM EmployeeTable";
            empList.DataSource = con.GetData(Query);
        }

        private void GetDept()
        {
            string Query = "SELECT * FROM DepartmentTable";
            DataTable dt = con.GetData(Query);
            deptCb.DisplayMember = "deptName";
            deptCb.ValueMember = "deptID";
            deptCb.DataSource = dt;
        }

        int key = 0;
        private void empList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpName.Text = empList.SelectedRows[0].Cells[1].Value.ToString();
            genderCb.Text = empList.SelectedRows[0].Cells[2].Value.ToString();
            deptCb.SelectedValue = empList.SelectedRows[0].Cells[3].Value.ToString();
            dobDtp.Text = empList.SelectedRows[0].Cells[4].Value.ToString();
            jDateDtp.Text = empList.SelectedRows[0].Cells[5].Value.ToString();
            txtSal.Text = empList.SelectedRows[0].Cells[6].Value.ToString();
            key = txtEmpName.Text == "" ? 0 : Convert.ToInt32(empList.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            key = 0;
            try
            {
                if (txtEmpName.Text == "" || genderCb.SelectedIndex == -1 || txtSal.Text == "")
                {
                    MessageBox.Show("Data missing!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string Name = txtEmpName.Text;
                string Gender = genderCb.SelectedItem.ToString();
                int Dept = Convert.ToInt32(deptCb.SelectedValue.ToString());
                string Dob = dobDtp.Value.ToString("yyyy-MM-dd");
                string jDate = jDateDtp.Value.ToString("yyyy-MM-dd");
                int Salary = Convert.ToInt32(txtSal.Text);

                string Query = "INSERT INTO EmployeeTable (empName, empGender, empDept, empDob, empJDate, empSal) VALUES (@Name, @Gender, @Dept, @Dob, @jDate, @Salary)";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@Name", Name },
                    { "@Gender", Gender },
                    { "@Dept", Dept },
                    { "@Dob", Dob },
                    { "@jDate", jDate },
                    { "@Salary", Salary }
                };

                con.setData(Query, parameters);
                showEmployees();
                MessageBox.Show("New employee added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpName.Text == "" || genderCb.SelectedIndex == -1 || txtSal.Text == "" || key == 0)
                {
                    MessageBox.Show("Data missing!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string Name = txtEmpName.Text;
                string Gender = genderCb.SelectedItem.ToString();
                int Dept = Convert.ToInt32(deptCb.SelectedValue.ToString());
                string Dob = dobDtp.Value.ToString("yyyy-MM-dd");
                string jDate = jDateDtp.Value.ToString("yyyy-MM-dd");
                int Salary = Convert.ToInt32(txtSal.Text);

                string Query = "UPDATE EmployeeTable SET eDate =mpName = @Name, empGender = @Gender, empDept = @Dept, empDob = @Dob, empJ @jDate, empSal = @Salary WHERE empID = @ID";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@Name", Name },
                    { "@Gender", Gender },
                    { "@Dept", Dept },
                    { "@Dob", Dob },
                    { "@jDate", jDate },
                    { "@Salary", Salary },
                    { "@ID", key }
                };

                con.setData(Query, parameters);
                showEmployees();
                MessageBox.Show("Employee's info updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (key == 0)
                {
                    MessageBox.Show("Data missing!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string Query = "DELETE FROM EmployeeTable WHERE empID = @ID";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@ID", key }
                };

                con.setData(Query, parameters);
                showEmployees();
                MessageBox.Show("Employee's info deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ConfigureDataGridView()
        {
            // Set alternating row colors for readability
            empList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Set header styles
            empList.EnableHeadersVisualStyles = false;
            empList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            empList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            empList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Set grid line color
            empList.GridColor = Color.Black;

            // Set default row styles
            empList.DefaultCellStyle.BackColor = Color.White;
            empList.DefaultCellStyle.ForeColor = Color.Black;
            empList.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Set selection styles
            empList.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            empList.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fit columns to the DataGridView
            empList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adjust row height to fit content
            empList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Disable column resize by the user for a consistent layout
            empList.AllowUserToResizeColumns = false;

            // Set row and column headers visibility if needed
            empList.RowHeadersVisible = false;
            empList.ColumnHeadersVisible = true;
        }

        private void ClearFields()
        {
            txtEmpName.Text = "";
            txtSal.Text = "";
            genderCb.SelectedIndex = -1;
            deptCb.SelectedIndex = -1;
            dobDtp.Value = DateTime.Now;
            jDateDtp.Value = DateTime.Now;
            key = 0;
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
            Employee emp = new Employee();
            Home.stack.Push(this);
            this.Hide();
            emp.ShowDialog();
            this.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Department dpt = new Department();
            Home.stack.Push(this);
            this.Hide();
            dpt.ShowDialog();
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
        //Design menuBtn
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.OrangeRed;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
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

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            label13.ForeColor = Color.OrangeRed;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.ForeColor = Color.Black;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label14.ForeColor = Color.OrangeRed;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Black;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }   
    }
}

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
            empList.DataSource=con.GetData(Query);
        }
        private void GetDept()
        {
            string Query = "SELECT * FROM DepartmentTable";
            deptCb.DisplayMember = con.GetData(Query).Columns["deptName"].ToString();
            deptCb.ValueMember = con.GetData(Query).Columns["deptID"].ToString();
            deptCb.DataSource = con.GetData(Query);
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpName.Text == "" || genderCb.SelectedIndex == -1 || txtSal.Text == "")
                {
                    MessageBox.Show("Data missing!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string Name = txtEmpName.Text;
                    string Gender = genderCb.SelectedItem.ToString();
                    int Dept = Convert.ToInt32(deptCb.SelectedValue.ToString());
                    string Dob = dobDtp.Value.ToString();
                    string jDate = jDateDtp.Value.ToString();
                    int Salary = Convert.ToInt32(txtSal.Text);


                    string Query = "INSERT INTO EmployeeTable VALUES('{0}','{1}',{2},'{3}','{4}',{5})";
                    Query = string.Format(Query, Name, Gender, Dept, Dob, jDate, Salary);
                    con.setData(Query);
                    showEmployees();
                    MessageBox.Show("New employee added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmpName.Text = "";
                    txtSal.Text = "";
                    genderCb.SelectedIndex = -1;
                    deptCb.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpName.Text == "" || genderCb.SelectedIndex == -1 || txtSal.Text == "")
                {
                    MessageBox.Show("Data missing!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string Name = txtEmpName.Text;
                    string Gender = genderCb.SelectedItem.ToString();
                    int Dept = Convert.ToInt32(deptCb.SelectedValue.ToString());
                    string Dob = dobDtp.Value.ToString();
                    string jDate = jDateDtp.Value.ToString();
                    int Salary = Convert.ToInt32(txtSal.Text);


                    string Query;
                    Query = "UPDATE EmployeeTable SET empName = '{0}', empGender= '{1}',empDept={2},empDob='{3}',empJDate='{4}',empSal={5} WHERE empID={6}";
                    Query = string.Format(Query, Name, Gender, Dept, Dob, jDate, Salary, key);
                    con.setData(Query);
                    showEmployees();
                    MessageBox.Show("Employee's info updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmpName.Text = "";
                    txtSal.Text = "";
                    genderCb.SelectedIndex = -1;
                    deptCb.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (key==0)
                {
                    MessageBox.Show("Data missing!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                { 
                    string Query;
                    Query = "DELETE FROM EmployeeTable WHERE empID={0}";
                    Query = string.Format(Query, key);
                    con.setData(Query);
                    showEmployees();
                    MessageBox.Show("Employee's info deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmpName.Text = "";
                    txtSal.Text = "";
                    genderCb.SelectedIndex = -1;
                    deptCb.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void label26_Click(object sender, EventArgs e)
        {
            if (Form1.stack.Count > 0)
            {
                Form previousForm = Form1.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            Form1.stack.Push(this);
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            requestOrder ro = new requestOrder();
            Form1.stack.Push(this);
            this.Hide();
            ro.ShowDialog();
            this.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            offer of = new offer();
            Form1.stack.Push(this);
            this.Hide();
            of.ShowDialog();
            this.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            location lc = new location();
            Form1.stack.Push(this);
            this.Hide();
            lc.ShowDialog();
            this.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Contacts cn = new Contacts();
            Form1.stack.Push(this);
            this.Hide();
            cn.ShowDialog();
            this.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            adminDashboard ad = new adminDashboard();
            Form1.stack.Push(this);
            this.Hide();
            ad.ShowDialog();
            this.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            Form1.stack.Push(this);
            this.Hide();
            emp.ShowDialog();
            this.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Department dpt = new Department();
            Form1.stack.Push(this);
            this.Hide();
            dpt.ShowDialog();
            this.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            salary sal = new salary();
            Form1.stack.Push(this);
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

        
        int key = 0;
        private void empList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpName.Text = empList.SelectedRows[0].Cells[1].Value.ToString();
            genderCb.Text = empList.SelectedRows[0].Cells[2].Value.ToString();
            deptCb.Text = empList.SelectedRows[0].Cells[3].Value.ToString();
            dobDtp.Text = empList.SelectedRows[0].Cells[4].Value.ToString();
            jDateDtp.Text = empList.SelectedRows[0].Cells[5].Value.ToString();
            txtSal.Text = empList.SelectedRows[0].Cells[6].Value.ToString();
            if (txtEmpName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(empList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        
    }
}

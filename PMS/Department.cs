using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class Department : Form
    {
        Functions con;

        public Department()
        {
            InitializeComponent();
            con = new Functions();
            showDepartments();
            ConfigureDataGridView();
        }

        private void showDepartments()
        {
            string query = "SELECT * FROM DepartmentTable";
            deptList.DataSource = con.GetData(query);
        }

        private void ConfigureDataGridView()
        {
            // Set alternating row colors for readability
            deptList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Set header styles
            deptList.EnableHeadersVisualStyles = false;
            deptList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            deptList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            deptList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Set grid line color
            deptList.GridColor = Color.Black;

            // Set default row styles
            deptList.DefaultCellStyle.BackColor = Color.White;
            deptList.DefaultCellStyle.ForeColor = Color.Black;
            deptList.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Set selection styles
            deptList.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            deptList.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fit columns to the DataGridView
            deptList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adjust row height to fit content
            deptList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Disable column resize by the user for a consistent layout
            deptList.AllowUserToResizeColumns = false;

            // Set row and column headers visibility if needed
            deptList.RowHeadersVisible = false;
            deptList.ColumnHeadersVisible = true;
        }
        int key = 0;
        private void deptList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && deptList.Rows[e.RowIndex].Cells.Count > 0)
            {
                if (deptList.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    txtDeptName.Text = deptList.Rows[e.RowIndex].Cells[1].Value.ToString();

                    key = Convert.ToInt32(deptList.Rows[e.RowIndex].Cells[0].Value);
                }
                else
                {
                    key = 0;
                }
            }
            else
            {
                key = 0;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDeptName.Text))
                {
                    MessageBox.Show("Data missing!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string dept = txtDeptName.Text;
                    string query = "INSERT INTO DepartmentTable (deptName) VALUES (@deptName)";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@deptName", dept }
                    };
                    con.setData(query, parameters);
                    showDepartments();
                    MessageBox.Show("Department added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDeptName.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Edit element into Database
        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDeptName.Text) || key == 0)
                {
                    MessageBox.Show("Data missing or no department selected!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string dept = txtDeptName.Text;
                    string query = "UPDATE DepartmentTable SET deptName = @deptName WHERE deptID = @deptID";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@deptName", dept },
                        { "@deptID", key }
                    };
                    con.setData(query, parameters);
                    showDepartments();
                    MessageBox.Show("Department updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDeptName.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete from Database
        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("No department selected!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "DELETE FROM DepartmentTable WHERE deptID = @deptID";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@deptID", key }
                    };
                    con.setData(query, parameters);
                    showDepartments();
                    MessageBox.Show("Department deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDeptName.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Enable other form from this form
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
        private void button9_Click(object sender, EventArgs e)
        {
            adminDashboard ad = new adminDashboard();
            Home.stack.Push(this);
            this.Hide();
            ad.ShowDialog();
            this.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            Home.stack.Push(this);
            this.Hide();
            emp.ShowDialog();
            this.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Department dept = new Department();
            Home.stack.Push(this);
            this.Hide();
            dept.ShowDialog();
            this.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            salary sal = new salary();
            Home.stack.Push(this);
            this.Hide();
            sal.ShowDialog();
            this.Show();
        }
        //MenuBtn Designing part start
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
            label18.ForeColor = Color.OrangeRed;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label18.ForeColor = Color.Black;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label14.ForeColor = Color.OrangeRed;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Black;
        }

        private void label13_Enter(object sender, EventArgs e)
        {
            label13.ForeColor = Color.OrangeRed;
        }

        private void label13_Leave(object sender, EventArgs e)
        {
            label13.ForeColor = Color.Black;
        }

        private void label1_Enter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.OrangeRed;
        }

        private void label1_Leave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.OrangeRed;
        }

        private void Department_Load(object sender, EventArgs e)
        {

        }
    }
}

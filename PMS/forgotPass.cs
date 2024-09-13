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
    public partial class forgotPass : Form
    {
        Functions con;
        public forgotPass()
        {
            InitializeComponent();
            con = new Functions();
        }
        private void txtForgotBtn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string newPass = txtNewPass.Text;
            string conPass = txtConPass.Text;

            if (validationInputs(email, newPass,conPass ))
            {
                if (forgotPassword(email,newPass))
                {
                    MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Something went wrong !!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
        private bool validationInputs(string username, string newPass, string conPass)
        {
            //String.IsNullOrWhiteSpace(value)
            if (username == "" || newPass == "" || conPass == "")
            {
                MessageBox.Show("Please fill all fields", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (newPass != conPass)
            {
                MessageBox.Show("New Password and Confirm Password do not match", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private bool forgotPassword(string email, string newPass)
        {
            string ValidationQuery = "SELECT pass FROM SignUpTable WHERE email = @email";
            var validationParameters = new Dictionary<string, object>
            {
                {"email", email}
            };
            DataTable parametersResult = con.GetData(ValidationQuery, validationParameters);

            //Update Password
            if (parametersResult.Rows.Count > 0 && parametersResult.Rows[0][0].ToString() == newPass)
            {
                string updatePassQuery = "UPDATE SignUpTable SET pass = @newPass WHERE email = @email";
                var updatePassParam = new Dictionary<string, object>
                {
                    {"@email",email},
                    {"@newPass", newPass}
                };
                int rowsAffected = con.setData(updatePassQuery, updatePassParam);
                return rowsAffected > 0;
            }
            return false;
        }
        //Esc btn event
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (Home.stack.Count > 0)
                {
                    Form previousForm = Home.stack.Pop();
                    this.Hide();
                    previousForm.Show();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Contacts cn = new Contacts();
            Home.stack.Push(this);
            this.Hide();
            cn.ShowDialog();
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

        private void label18_Click(object sender, EventArgs e)
        {
            Home fm = new Home();
            Home.stack.Push(this);
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prescriptionMedicine pm = new prescriptionMedicine();
            Home.stack.Push(this);
            this.Hide();
            pm.ShowDialog();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

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

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        

        private void label26_Click_1(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            surgicalProduct sp = new surgicalProduct();
            Home.stack.Push(this);
            this.Hide();
            sp.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
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

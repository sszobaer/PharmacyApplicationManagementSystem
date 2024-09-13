using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PMS
{

    public partial class userDashboard : Form
    {

        Functions con;
        private string firstname;
        private string lastname;
        private string email;
        private string contactno;
        private string dateofbirth;
        private string gender;
        private string address;

        public userDashboard(string fname, string lname, string email, string contactno, string dateofbirth, string gender, string adress)
        {
            InitializeComponent();
            this.firstname = fname;
            this.lastname = lname;
            this.email = email;
            this.contactno = contactno;
            this.dateofbirth = dateofbirth;
            this.gender = gender;
            this.address = adress;
            con = new Functions();
        }

        

        

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //Esc Button
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
        private void label18_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            Home.stack.Push(this);
            this.Hide();
            frm.ShowDialog();
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

        

        private void label26_Click_1(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

       
        //MenuBtn Color setting start
        private void label18_MouseEnter(object sender, EventArgs e)
        {
            label18.ForeColor = Color.OrangeRed;
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            label17.ForeColor = Color.OrangeRed;
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            label16.ForeColor = Color.OrangeRed;
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.ForeColor = Color.OrangeRed;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label14.ForeColor = Color.OrangeRed;
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            label13.ForeColor = Color.OrangeRed;
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label18.ForeColor = Color.Black;
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.ForeColor = Color.Black;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.ForeColor = Color.Black;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.ForeColor = Color.Black;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Black;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.ForeColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel14.Visible=!panel14.Visible;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sessionManager.IsLoggedIn = false;
            Home frm = new Home();
            this.Hide();    
            frm.ShowDialog();
            this.Show();
        }

        private void userDashboard_Load(object sender, EventArgs e)
        {
            // Display all of the information according to database
            lbluserFullName.Text = $"{firstname} {lastname}";
            lblfullNameMain.Text = $"{firstname} {lastname}";
            lblPhoneNo.Text = contactno;
            lblphoneNumberMain.Text = contactno;
            lblEmailAdd.Text = email;
            lblemailMain.Text = email;
            lblGender.Text = gender;
            lblDoB.Text = dateofbirth;
            lblAdress.Text = address;
        }

        private void UpdatePassBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string currentPassword = txtCurPass.Text;
            string newPassword = txtNewPass.Text;
            string confirmPassword = txtConPass.Text;

            if (validationInputs(username, currentPassword, newPassword, confirmPassword))
            {
                if(updatePassword(username, currentPassword, newPassword))
                {
                    MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Current Password is Incorrect !!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

        }
        private bool validationInputs(string username, string curPass, string newPass, string conPass)
        {
            //String.IsNullOrWhiteSpace(value)
            if(username=="" || curPass =="" || newPass == "" || conPass == "")
            {
                MessageBox.Show("Please fill all fields", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(newPass != conPass)
            {
                MessageBox.Show("New Password and Confirm Password do not match", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        
        private bool updatePassword(string username, string curPass, string newPass)
        {
            string ValidationQuery = "SELECT pass FROM SignUpTable WHERE username = @username";
            var validationParameters = new Dictionary<string, object>
            {
                {"username", username}    
            };
            DataTable parametersResult = con.GetData(ValidationQuery,validationParameters);

            //Update Password
            if (parametersResult.Rows.Count > 0 && parametersResult.Rows[0][0].ToString() == curPass)
            {
                string updatePassQuery = "UPDATE SignUpTable SET pass = @newPass WHERE username = @username AND pass = @curPass";
                var updatePassParam = new Dictionary<string, object>
                {
                    {"@username",username},
                    {"@curPass", curPass},
                    {"@newPass", newPass}
                };
                int rowsAffected = con.setData(updatePassQuery,updatePassParam);
                return rowsAffected > 0;
            }
            return false;
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtCurPass.UseSystemPasswordChar = !showPass.Checked;
            txtNewPass.UseSystemPasswordChar = !showPass.Checked;
            txtConPass.UseSystemPasswordChar = !showPass.Checked;
        }

        private void viewCartBtn_Click(object sender, EventArgs e)
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

        private void button15_Click(object sender, EventArgs e)
        {
            prescriptionMedicine pm = new prescriptionMedicine();
            Home.stack.Push(this);
            this.Hide();
            pm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            surgicalProduct sp = new surgicalProduct();
            Home.stack.Push(this);
            this.Hide();
            sp.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            otcMedicine om = new otcMedicine();
            Home.stack.Push(this);
            this.Hide();
            om.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            babyCare bc = new babyCare();
            Home.stack.Push(this);
            this.Hide();
            bc.ShowDialog();
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

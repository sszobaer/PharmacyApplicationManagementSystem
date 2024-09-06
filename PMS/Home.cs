using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class Home : Form
    {
        public static Stack<Form> stack = new Stack<Form>();
        public Home()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }


        string conStr = "Data Source=ZOBAER;Initial Catalog=\"Pharmacy Management System\";User ID=sa;Password=admin;TrustServerCertificate=True";
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) == true)
            {
                txtUsername.Focus();
                errorProvider1.SetError(this.txtUsername, "Please fill Username");
            }
            else if (string.IsNullOrEmpty(txtPass.Text) == true)
            {
                txtPass.Focus();
                errorProvider2.SetError(this.txtPass, "Please fill Password");
            }
            // Attempt to login as Admin 
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand adminCmd = new SqlCommand("SELECT name, email, contactno, dateofbirth, gender, address FROM AdminTable WHERE username=@username AND pass=@pass", con);
                adminCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                adminCmd.Parameters.AddWithValue("@pass", txtPass.Text);

                SqlDataReader adminReader = adminCmd.ExecuteReader();
                if (adminReader.Read())
                {
                    // Admin Login Success
                    string name = adminReader["name"].ToString();
                    string email = adminReader["email"].ToString();
                    string contactno = adminReader["contactno"].ToString();
                    string dateofbirth = adminReader["dateofbirth"].ToString();
                    string gender = adminReader["gender"].ToString();
                    string address = adminReader["address"].ToString();
                    MessageBox.Show($"Welcome back {name}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Login true
                    sessionManager.IsLoggedIn = true;

                    adminDashboard adminDashboard = new adminDashboard(name, email, contactno, dateofbirth, gender, address);
                    Home.stack.Push(this);
                    this.Hide();
                    adminDashboard.ShowDialog();
                    this.Show();
                    return; // Return early if admin login is successful
                }
                adminReader.Close(); // Close reader before reusing connection
            }

            // Attempt to login as User
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand userCmd = new SqlCommand("SELECT firstname, lastname, email, contactno, dateofbirth, gender, address FROM SignUpTable WHERE username=@username AND pass=@pass", con);
                userCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                userCmd.Parameters.AddWithValue("@pass", txtPass.Text);

                SqlDataReader userReader = userCmd.ExecuteReader();
                if (userReader.Read())
                {
                    // User Login Success
                    string firstname = userReader["firstname"].ToString();
                    string lastname = userReader["lastname"].ToString();
                    string email = userReader["email"].ToString();
                    string contactno = userReader["contactno"].ToString();
                    string dateofbirth = userReader["dateofbirth"].ToString();
                    string gender = userReader["gender"].ToString();
                    string address = userReader["address"].ToString();
                    MessageBox.Show($"Welcome {firstname} {lastname}", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    sessionManager.IsLoggedIn = true;

                    userDashboard userDashboard = new userDashboard(firstname, lastname, email, contactno, dateofbirth, gender, address);
                    Home.stack.Push(this);
                    this.Hide();
                    userDashboard.ShowDialog();
                    this.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUp su = new signUp();
            Home.stack.Push(this);
            this.Hide();
            su.ShowDialog();
            this.Show();   
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar=true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prescriptionMedicine pm = new prescriptionMedicine();
            Home.stack.Push(this);
            this.Hide();
            pm.ShowDialog();
            this.Show();
        }


        private void label1_Click_2(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPass fp = new forgotPass();
            this.Hide();
            Home.stack.Push(this);
            fp.ShowDialog();
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

        private void label18_MouseHover(object sender, EventArgs e)
        {
            label18.ForeColor = Color.Orange;
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            label18.ForeColor = Color.Orange;
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label18.ForeColor = Color.Black;
        }


        private void label18_MouseEnter_1(object sender, EventArgs e)
        {
            label18.ForeColor = Color.OrangeRed;
        }

        private void label18_MouseLeave_1(object sender, EventArgs e)
        {
            label18.ForeColor = Color.Black;
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            label17.ForeColor = Color.OrangeRed;
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.ForeColor= Color.Black;
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            label16.ForeColor = Color.OrangeRed;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.ForeColor= Color.Black;
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.ForeColor = Color.OrangeRed;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.ForeColor= Color.Black;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label14.ForeColor = Color.OrangeRed;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor= Color.Black;
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            label13.ForeColor = Color.OrangeRed;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.ForeColor= Color.Black;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.OrangeRed;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor= Color.Black;

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}

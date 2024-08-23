using System;
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
    public partial class Form1 : Form
    {
        public static Stack<Form> stack = new Stack<Form>();
        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        string conStr = "Data Source=ZOBAER;Initial Catalog=PMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
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

                    adminDashboard adminDashboard = new adminDashboard(name, email, contactno, dateofbirth, gender, address);
                    this.Hide();
                    adminDashboard.ShowDialog();
                    this.Close();
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

                    userDashboard userDashboard = new userDashboard(firstname, lastname, email, contactno, dateofbirth, gender, address);
                    this.Hide();
                    userDashboard.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        
private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUp su = new signUp();
            Form1.stack.Push(this);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prescriptionMedicine pm = new prescriptionMedicine();
            Form1.stack.Push(this);
            this.Hide();
            pm.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void label18_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Contacts cn = new Contacts();
            Form1.stack.Push(this);
            this.Hide();
            cn.ShowDialog();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPass fp = new forgotPass();
            this.Hide();
            Form1.stack.Push(this);
            fp.ShowDialog();
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

        private void txtUsername_Leave(object sender, EventArgs e)
        {

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {

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

        private void panel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }
    }
}

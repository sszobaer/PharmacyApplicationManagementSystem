using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace PMS
{
    
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }
        string mailFormat = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Image Files| *.jpg;*.jpeg;*.png;*.svg;*.bmp|All Files|*.*";

            if(openfd.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openfd.FileName;
                PictureBox pb = new PictureBox();
                pb.Image = Image.FromFile(selectedFilePath);
            }
            
        }
        string conStr = "Data Source=ZOBAER;Initial Catalog=PMS;Integrated Security=True;TrustServerCertificate=True";
        private void button3_Click(object sender, EventArgs e)
        {
            //First Name
            if (string.IsNullOrEmpty(txtFname.Text) == true)
            {
                txtFname.Focus();
                errorProvider1.SetError(this.txtFname, "Please fill First Name");
            }
            //Last Name
            else if (string.IsNullOrEmpty(txtLname.Text) == true)
            {
                txtLname.Focus();
                errorProvider2.SetError(this.txtLname, "Please fill Last Name");
            }
            //Username
            else if (string.IsNullOrEmpty(txtUsername.Text) == true)
            {
                txtLname.Focus();
                errorProvider3.SetError(this.txtUsername, "Please fill Username");
            }
            //Email Validation
            
            else if (Regex.IsMatch(txtEmail.Text, mailFormat) == false)
            {
                txtEmail.Focus();
                errorProvider4.SetError(this.txtEmail, "Invalid email");
            }
            //Contact No
            int ContactNo;
            if(!int.TryParse(txtConNo.Text, out ContactNo))
            {
                txtConNo.Focus();
                errorProvider5.SetError(this.txtConNo, "Contact number must be numeric.");
            }
            //Set Password
            else if (string.IsNullOrEmpty(txtNPass.Text) == true)
            {
                txtNPass.Focus();
                errorProvider6.SetError(this.txtNPass, "Please fill Set Password");
            }
            //Confirm Password
            else if (string.IsNullOrEmpty(txtCPass.Text) == true)
            {
                txtCPass.Focus();
                errorProvider7.SetError(this.txtCPass, "Please fill Confirm Password");
            }
            //Setting the confirm password = Set password
            else if (txtCPass.Text != txtNPass.Text)
            {
                errorProvider9.SetError(this.txtCPass, "Retype the password again");
            }
            //Adress
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                txtAddress.Focus();
                errorProvider8.SetError(this.txtAddress, "Please fill Address");
            }
            //Dob
            else if (DoBpicker.Checked == false)
            {
                DoBpicker.Focus();
                errorProvider10.SetError(this.DoBpicker, "please check that you provide the correct Birthday");
            }
            //Gender selection logic
            string SelectedGender = string.Empty;
            if(radioButton1.Checked && radioButton1.Enabled)
            {
                SelectedGender = radioButton1.Text;
            }
            else if(radioButton2.Checked && radioButton2.Enabled)
            {
                SelectedGender = radioButton2.Text;
            }
            else if(radioButton3.Checked && radioButton3.Enabled)
            {
                SelectedGender = radioButton3.Text;
            }
            if(string.IsNullOrEmpty(SelectedGender))
            {
                errorProvider9.SetError(this.lblGender, "Please select a gender");
            }
            else
            {
                //Clearing error providers
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();
                errorProvider6.Clear();
                errorProvider7.Clear();
                errorProvider9.Clear();
                errorProvider10.Clear();

                

                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO SignUpTable(firstname, lastname, username, email, contactno, pass, dateofbirth, gender, address)VALUES(@firstname, @lastname, @username, @email, @contactno, @pass, @dateofbirth, @gender, @address)", con);
                cmd.Parameters.AddWithValue("@firstname", txtFname.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLname.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@contactno", ContactNo);
                cmd.Parameters.AddWithValue("@pass", txtCPass.Text);
                DateTime DoB = DoBpicker.Value.Date;
                cmd.Parameters.AddWithValue("@dateofbirth", DoB);
                cmd.Parameters.AddWithValue("@gender", SelectedGender);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Sign Up Successful","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
        }
      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtNPass.UseSystemPasswordChar = !checkBox1.Checked;
            txtCPass.UseSystemPasswordChar= !checkBox1.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.ShowDialog();
            this.Show();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void signUp_Load(object sender, EventArgs e)
        {
            
        }
        //Esc btn event
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Escape)
            {
                if(Form1.stack.Count>0)
                {
                    Form previousForm = Form1.stack.Pop();
                    this.Hide();
                    previousForm.Show();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void label2_Click(object sender, EventArgs e)
        {
            Contacts cn = new Contacts();
            Form1.stack.Push(this);
            this.Hide();
            cn.ShowDialog();
            this.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            Form1.stack.Push(this);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            prescriptionMedicine pm = new prescriptionMedicine();
            Form1.stack.Push(this);
            this.Hide();
            pm.ShowDialog();
            this.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtConNo_TextChanged(object sender, EventArgs e)
        {
            
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

        //First Name
        private void txtFname_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFname.Text) == true)
            {
                txtFname.Focus();
                errorProvider1.SetError(this.txtFname, "Please fill First Name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_Leave(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Form1.stack.Count > 0)
            {
                Form previousForm = Form1.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {

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
            label16.ForeColor= Color.Black;
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.ForeColor = Color.OrangeRed;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.ForeColor = Color.Black;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.OrangeRed;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.OrangeRed;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.OrangeRed;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void label26_Click_1(object sender, EventArgs e)
        {
            if (Form1.stack.Count > 0)
            {
                Form previousForm = Form1.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }


        //More Update coming Soon
    }
}

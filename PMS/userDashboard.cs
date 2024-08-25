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
    public partial class userDashboard : Form
    {
        private string firstname;
        private string lastname;
        private string email;
        private string contactno;
        private string dateofbirth;
        private string gender;
        private string address;

        public userDashboard(string firstname, string lastname, string email, string contactno, string dateofbirth, string gender, string adress)
        {
            InitializeComponent();
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.contactno = contactno;
            this.dateofbirth = dateofbirth;
            this.gender = gender;
            this.address = adress;
        }



        public userDashboard()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //Esc Button
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (Form1.stack.Count > 0)
                {
                    Form previousForm = Form1.stack.Pop();
                    this.Hide();
                    previousForm.Show();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void label18_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            Form1.stack.Push(this);
            this.Hide();
            frm.ShowDialog();
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

        

        private void label26_Click_1(object sender, EventArgs e)
        {
            if (Form1.stack.Count > 0)
            {
                Form previousForm = Form1.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void userDashboard_Load(object sender, EventArgs e)
        {
            // Display all of the information according to database
            lbluserFullName.Text = $"{firstname} { lastname}";
            lblfullNameMain.Text = $"{firstname} {lastname}";
            lblPhoneNo.Text = contactno;
            lblphoneNumberMain.Text = contactno;
            lblEmailAdd.Text = email;
            lblemailMain.Text = email;
            lblGender.Text = gender;
            lblDoB.Text = dateofbirth;
            lblAdress.Text = address;
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
            Form1 frm = new Form1();
            this.Hide();    
            frm.ShowDialog();
            this.Show();
        }
    }
}

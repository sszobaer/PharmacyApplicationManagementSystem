using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PMS
{
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private string name;
        private string email;
        private string contactno;
        private string dateofbirth;
        private string gender;
        private string address;

        public adminDashboard(string name, string email, string contactno, string dateofbirth, string gender, string adress)
        {
            InitializeComponent();
            this.name = name;
            this.email = email;
            this.contactno = contactno;
            this.dateofbirth = dateofbirth;
            this.gender = gender;
            this.address = adress;
        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {
            // Display all of the information according to database
            
            lblfullNameMain.Text = name;
            lbladminFullName.Text = name;
            lblPhoneNo.Text = contactno;
            lblphoneNumberMain.Text = contactno;
            lblEmailAdd.Text = email;
            lblemailMain.Text = email;
            lblGender.Text = gender;
            lblDoB.Text = dateofbirth;
            lblAdress.Text = address;
         }
        

        private void button5_Click(object sender, EventArgs e)
        {
            panel14.Visible = !panel14.Visible;
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

        private void button8_Click(object sender, EventArgs e)
        {
            sessionManager.IsLoggedIn = false;
            Home frm = new Home();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            Home.stack.Push(this);
            this.Hide();
            employee.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Department dpt = new Department();
            Home.stack.Push(this);
            this.Hide();
            dpt.ShowDialog();
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

        private void label18_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            requestOrder ro = new requestOrder();
            this.Hide();
            ro.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            offer of = new offer();
            this.Hide();
            of.ShowDialog();
        }
    }
}

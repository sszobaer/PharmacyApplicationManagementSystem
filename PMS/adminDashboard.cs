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
    }
}

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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Home.stack.Push(this);
            this.Hide();
            home.ShowDialog();
        }

        private void reqOrderBtn_Click(object sender, EventArgs e)
        {
            requestOrder req = new requestOrder();
            Home.stack.Push(this);   
            this.Hide();
            req.ShowDialog();
        }

        private void offersBtn_Click(object sender, EventArgs e)
        {
            offer of = new offer();
            Home.stack.Push(this);
            this.Hide();
            of.ShowDialog();
        }

        private void loactionBtn_Click(object sender, EventArgs e)
        {
            location loc = new location();
            Home.stack.Push(this);
            this.Hide();
            loc.ShowDialog();
        }

        private void contactsBtn_Click(object sender, EventArgs e)
        {
            Contacts contacts = new Contacts();
            Home.stack.Push(this);
            this.Hide();
            contacts.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prescriptionMedicine prescriptionMedicine = new prescriptionMedicine();
            Home.stack.Push(this);
            this.Hide();
            prescriptionMedicine.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            surgicalProduct prescription = new surgicalProduct();
            Home.stack.Push(this);
            this.Hide();
            prescription.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            otcMedicine otc = new otcMedicine();
            Home.stack.Push(this);
            this.Hide(); 
            otc.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            babyCare babyCare = new babyCare();
            Home.stack.Push(this);
            this.Hide();
            babyCare.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            Home.stack.Push(this);
            this.Hide();
            cart.ShowDialog();
        }
    }
}

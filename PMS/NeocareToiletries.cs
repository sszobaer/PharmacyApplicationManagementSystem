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
    public partial class NeocareToiletries : Form
    {
        public NeocareToiletries()
        {
            InitializeComponent();
        }

        private void informationBtn_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
                panel4.Visible = false;
            }
        }

        private void reviewBtn_Click(object sender, EventArgs e)
        {
            if (panel4.Visible)
            {
                panel4.Visible = false;
            }
            else
            {
                panel4.Visible = true;
                panel2.Visible = false;
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Home.stack.Push(this);
            this.Hide();
            home.ShowDialog();
        }

        private void requestOrderBtn_Click(object sender, EventArgs e)
        {
            requestOrder ro = new requestOrder();
            Home.stack.Push(this);
            this.Hide();
            ro.ShowDialog();
        }

        private void offersBtn_Click(object sender, EventArgs e)
        {
            offer of = new offer();
            Home.stack.Push(this);
            this.Hide();
            of.ShowDialog();
        }

        private void locationBtn_Click(object sender, EventArgs e)
        {
            location lc = new location();
            Home.stack.Push(this);
            this.Hide();
            lc.ShowDialog();
        }

        private void contactsBtn_Click(object sender, EventArgs e)
        {
            Contacts contacts = new Contacts();
            Home.stack.Push(this);
            this.Hide();
            contacts.ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }
    }
}

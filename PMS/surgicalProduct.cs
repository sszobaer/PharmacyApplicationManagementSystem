﻿using System;
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
    public partial class surgicalProduct : Form
    {
        public surgicalProduct()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            wristSplint wristSplint = new wristSplint();
            Home.stack.Push(this);
            this.Hide();
            wristSplint.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bloodGlucoseMetter bgm = new bloodGlucoseMetter();
            Home.stack.Push(this);
            this.Hide();
            bgm.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            omronNebulizer omronNebulizer = new omronNebulizer();
            Home.stack.Push(this);
            this.Hide();
            omronNebulizer.ShowDialog();
            this.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            taylorBrace taylorBrace = new taylorBrace();
            Home.stack.Push(this);
            this.Hide();
            taylorBrace.ShowDialog();
            this.Show();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Home.stack.Push(this);
            this.Hide();
            home.ShowDialog();
            this.Show();
        }

        private void requestOrderBtn_Click(object sender, EventArgs e)
        {
            requestOrder requestOrder = new requestOrder();
            Home.stack.Push(this);
            this.Hide();
            requestOrder.ShowDialog();
            this.Show();
        }

        private void offersBtn_Click(object sender, EventArgs e)
        {
            offer offer = new offer();
            Home.stack.Push(this);
            this.Hide();
            offer.ShowDialog();
            this.Show();
        }

        private void locationBtn_Click(object sender, EventArgs e)
        {
            location location = new location();
            Home.stack.Push(this);
            this.Hide();
            location.ShowDialog();
            this.Show();
        }

        private void contactsBtn_Click(object sender, EventArgs e)
        {
            Contacts contacts = new Contacts();
            Home.stack.Push(this);
            this.Hide();
            contacts.ShowDialog();
            this.Show();
        }
    }
}

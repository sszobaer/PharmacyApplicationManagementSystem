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
    public partial class oralon : Form
    {
        Functions con;
        public oralon()
        {
            InitializeComponent();
            con = new Functions();
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
            requestOrder requestorder = new requestOrder();
            Home.stack.Push(this);
            this.Hide();
            requestorder.ShowDialog();
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
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

        private void postBtn_Click(object sender, EventArgs e)
        {
            string username = sessionManager.Username;
            if (sessionManager.IsLoggedIn)
            {
                string query = "INSERT INTO ReviewsTable VALUES (@username, @review)";
                var parameters = new Dictionary<string, object>
                {
                    {"@username",username },
                    {"@review",txtReview.Text }
                };
                con.setData(query, parameters);
                MessageBox.Show("Thanks for your valuable Comment", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please login", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace PMS
{
    public partial class payment : Form
    {
        Functions con;
        public payment()
        {
            InitializeComponent();
            con = new Functions();
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

        private void bkashBtn_Click(object sender, EventArgs e)
        {
            if (panelCard.Visible)
            {
                panelCard.Visible = false;
            }
            else
            {
                panelCard.Visible = false;
                mobileBankingPanel.Visible = true;
            }
        }

        private void nagadBtn_Click(object sender, EventArgs e)
        {
            if (panelCard.Visible)
            {
                panelCard.Visible = false;
            }
            else
            {
                panelCard.Visible = false;
                mobileBankingPanel.Visible = true;
            }
        }

        private void rocketBtn_Click(object sender, EventArgs e)
        {
            if (panelCard.Visible)
            {
                panelCard.Visible = false;
            }
            else
            {
                panelCard.Visible = false;
                mobileBankingPanel.Visible = true;
            }
        }

        private void cardBtn_Click(object sender, EventArgs e)
        {
            if (panelCard.Visible)
            {
                mobileBankingPanel.Visible = false;
            }
            else
            {
                panelCard.Visible = true;
                mobileBankingPanel.Visible = false;
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
        string status = "Order placed";
        string username = sessionManager.Username;
        private void cardMakePaymentbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCardExpiry.Text == "" || txtCardHolderName.Text == "" || txtCardNumber.Text =="" || txtCVC.Text =="" )
                {
                    MessageBox.Show($"Please fill all of the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string query = "UPDATE ProductTable SET pStatus = @pstatus WHERE username = @username AND pStatus = 'Cart'";
                var parameters = new Dictionary<string, object>
                {
                    { "@pstatus", status },
                    {"@username", username}

                };
                con.setData(query, parameters);
                MessageBox.Show("Order placed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mobileBankingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPhone.Text=="" || txtPin.Text=="")
                {
                    MessageBox.Show("Please fill all of the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string query = "UPDATE ProductTable SET pStatus = @pstatus WHERE username = @username AND pStatus = 'Cart'";
                var parameters = new Dictionary<string, object>
                {
                    { "@pstatus", status },
                    {"@username", username}

                };
                con.setData(query, parameters);
                MessageBox.Show("Order placed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            ddMenu.Visible = !ddMenu.Visible;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            prescriptionMedicine pm = new prescriptionMedicine();
            Home.stack.Push(this);
            this.Hide();
            pm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            surgicalProduct sp = new surgicalProduct();
            Home.stack.Push(this);
            this.Hide();
            sp.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            otcMedicine om = new otcMedicine();
            Home.stack.Push(this);
            this.Hide();
            om.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            babyCare bc = new babyCare();
            Home.stack.Push(this);
            this.Hide();
            bc.ShowDialog();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            About about = new About();
            Home.stack.Push(this);
            this.Hide();
            about.ShowDialog();
        }
    }
}

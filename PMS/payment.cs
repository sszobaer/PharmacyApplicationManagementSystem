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
            string query = "UPDATE TABLE ProductTable SET pStatus = @pstatus WHERE username = @username ";
            var parameters = new Dictionary<string, object>
            {
                { "@status", status },
                {"@username", username}
                
            };
            con.setData(query, parameters);
            MessageBox.Show("Order placed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mobileBankingBtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TABLE ProductTable SET pStatus = @pstatus WHERE username = @username ";
            var parameters = new Dictionary<string, object>
            {
                { "@status", status },
                {"@username", username}

            };
            con.setData(query, parameters);
            MessageBox.Show("Order placed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

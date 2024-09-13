using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PMS
{
    public partial class otcMedicine : Form
    {
        Functions con;
        public otcMedicine()
        {
            InitializeComponent();
            con = new Functions();
        }
        //Method for valid Product ID
        private bool IsValidProductID(string pID)
        {
            string pattern = @"^p-\d{3}$"; // Pattern for 'p-XXX' where XXX is exactly three digits
            Regex regex = new Regex(pattern);
            return regex.IsMatch(pID);
        }

        // Format product ID
        private string FormatProductID(int id)
        {
            return $"p-{id:D3}"; // Format integer as 'p-XXX' with leading zeros if necessary
        }
        //Declair Product informations
        string currentUsername = sessionManager.Username;
        string status = "Cart";
        string p1Name = "ORSALINE-N . Orsaline";
        double p1Price = 6;

        string p2Name = "ORALON 30 G Gel";
        double p2Price = 55.17;

        string p3Name = "FAMOTACK 50 ML PFS";
        string p3Price = "55 bdt";

        string p4Name = "DERMIN WHITFIELD JAYSONS 25 GM Ointment";
        double p4Price = 50.98;

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

        private void AddToCart1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!sessionManager.IsLoggedIn)
                {
                    MessageBox.Show("Please Login or Sign Up", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string P1ID = FormatProductID(13);
                    string query = "INSERT INTO ProductTable VALUES (@pId, @pName, @price, @pStatus, @username)";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@pId", P1ID },
                        { "@pName", p1Name},
                        {"@price",p1Price },
                        {"@pStatus", status },
                        {"@username", currentUsername}
                    };
                    con.setData(query, parameters);
                    MessageBox.Show("Successfully Added to Cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddToCart2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!sessionManager.IsLoggedIn)
                {
                    MessageBox.Show("Please Login or Sign Up", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string p2ID = FormatProductID(14);
                    string query = "INSERT INTO ProductTable VALUES (@pId, @pName, @price, @pStatus, @username)";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@pId", p2ID },
                        { "@pName", p2Name},
                        {"@price",p2Price },
                        {"@pStatus", status }, 
                        { "@username", currentUsername }
                    };
                    con.setData(query, parameters);
                    MessageBox.Show("Successfully Added to Cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddToCart3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!sessionManager.IsLoggedIn)
                {
                    MessageBox.Show("Please Login or Sign Up", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string p3ID = FormatProductID(15);
                    string query = "INSERT INTO ProductTable VALUES (@pId, @pName, @price, @pStatus, @username)";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@pId", p3ID },
                        { "@pName", p3Name},
                        {"@price",p3Price },
                        {"@pStatus", status },
                        {"@username", currentUsername }
                    };
                    con.setData(query, parameters);
                    MessageBox.Show("Successfully Added to Cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddToCart4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!sessionManager.IsLoggedIn)
                {
                    MessageBox.Show("Please Login or Sign Up", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string p4ID = FormatProductID(16);
                    string query = "INSERT INTO ProductTable VALUES (@pId, @pName, @price, @pStatus, @username)";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@pId", p4ID },
                        { "@pName", p4Name},
                        {"@price",p4Price },
                        {"@pStatus", status },
                        {"@username", currentUsername }
                    };
                    con.setData(query, parameters);
                    MessageBox.Show("Successfully Added to Cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            orsaline or = new orsaline();
            Home.stack.Push(this);
            this.Hide();
            or.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            oralon or = new oralon();
            Home.stack.Push(this);
            this.Hide();
            or.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            famotack famotack = new famotack();
            Home.stack.Push(this);
            this.Hide();
            famotack.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            derminWhitefield dwf = new derminWhitefield();
            Home.stack.Push(this);
            this.Hide();
            dwf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void label14_Click(object sender, EventArgs e)
        {
            About about = new About();
            Home.stack.Push(this);
            this.Hide();
            about.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class surgicalProduct : Form
    {
        Functions con;
        public surgicalProduct()
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
        string p1Name = "WRIST SPLINT AMBIDEXTROUS SIZE: S-M-L-XL-XXL ";
        string P1ID = "p-009";
        double p1Price = 1270;

        string p2Name = "OG CARE BLOOD GLUCOSE METTER DEVICE";
        string p2ÍD = "p-010";
        double p2Price = 2650;

        string p3Name = "OMRON NEBULIZER NE-C101 DEVICE";
        string p3ID = "p-011";
        double p3Price = 4153;

        string p4Name = "TAYLOR BRACE TYNOR . SURGICAL";
        string p4ID = "p-012";
        double p4Price = 5098;

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
                    string query = "INSERT INTO ProductTable VALUES (@pId, @pName, @price, @pStatus, @username)";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@pId", P1ID },
                        { "@pName", p1Name},
                        {"@price",p1Price },
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
                    string query = "INSERT INTO ProductTable VALUES (@pId, @pName, @price, @pStatus, @username)";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@pId", p2ÍD },
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
                    string query = "INSERT INTO ProductTable VALUES (@pId, @pName, @price, @pStatus, @username)";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@pId", p3ID },
                        { "@pName", p3Name},
                        {"@price",p3Price },
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
                    string query = "INSERT INTO ProductTable VALUES (@pId, @pName, @price, @pStatus, @username)";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@pId", p4ID },
                        { "@pName", p4Name},
                        {"@price",p4Price },
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
    }
}

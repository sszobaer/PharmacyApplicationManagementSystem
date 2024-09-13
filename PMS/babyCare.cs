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
    public partial class babyCare : Form
    {
        Functions con;
        public babyCare()
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
        string p1Name = "KODOMO BABY HAIR AND BODY WASH 200 ML Toiletries";
        double p1Price = 507;

        string p2Name = "NEOCARE SMALL 50 PCS Toiletries";
        double p2Price = 977;

        string p3Name = "KODOMO BABY TOOTH PASTE GRAPE 80 GM Toiletries";
        double p3Price = 200;

        string p4Name = "LACTOGEN 1-TIN 400 GM FOOD (TOILETRIES)";
        double p4Price = 675;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NeocareToiletries neocareToiletries = new NeocareToiletries();
            Home.stack.Push(this);
            this.Hide();
            neocareToiletries.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bodyWash bw = new bodyWash();
            Home.stack.Push(this);
            this.Hide();
            bw.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            toothPaste toothPaste = new toothPaste();
            Home.stack.Push(this);
            this.Hide();
            toothPaste.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            babyHair bh = new babyHair();
            Home.stack.Push(this);
            this.Hide();
            bh.ShowDialog();
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
        private void AddtoCart1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!sessionManager.IsLoggedIn)
                {
                    MessageBox.Show("Please Login or Sign Up", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string P1ID = FormatProductID(17);
                    string query = "INSERT INTO ProductTable VALUES (@pId, @pName, @price, @pStatus, @username)";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@pId", P1ID },
                        { "@pName", p1Name},
                        {"@price",p1Price },
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

        private void AddtoCart2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!sessionManager.IsLoggedIn)
                {
                    MessageBox.Show("Please Login or Sign Up", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string p2ID = FormatProductID(18);
                    string query = "INSERT INTO ProductTable VALUES (@pId, @pName, @price, @pStatus,@username)";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@pId", p2ID },
                        { "@pName", p2Name},
                        {"@price",p2Price },
                        {"@pStatus", status },
                        {"@username",currentUsername }
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
                    string p3ID = FormatProductID(19);
                    string query = "INSERT INTO ProductTable VALUES (@pId, @pName, @price, @pStatus,@username)";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@pId", p3ID },
                        { "@pName", p3Name},
                        {"@price",p3Price },
                        {"@pStatus", status },
                        {"@username",currentUsername}
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
                    string p4ID = FormatProductID(20);
                    string query = "INSERT INTO ProductTable VALUES (@pId, @pName, @price, @pStatus, @username)";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@pId", p4ID },
                        { "@pName", p4Name},
                        {"@price",p4Price },
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

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

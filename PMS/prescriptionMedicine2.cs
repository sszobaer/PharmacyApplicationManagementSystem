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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PMS
{
    public partial class prescriptionMedicine2 : Form
    {
        Functions con;
        public prescriptionMedicine2()
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
        string p1Name = "DIAMICRON MR 30 MG";
        double p1Price = 14;

        string p2Name = "MONTENE 5 MG Tab";
        double p2Price = 9;

        string p3Name = "ZIMAX 500 MG Tab";
        double p3Price = 40;

        string p4Name = "PRONOR 5 MG Tab";
        double p4Price = 10.07;
        //Esc btn event
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (Home.stack.Count > 0)
                {
                    Form previousForm = Home.stack.Pop();
                    this.Hide();
                    previousForm.Show();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Contacts cn = new Contacts();
            Home.stack.Push(this);
            this.Hide();
            cn.ShowDialog();
            this.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            Home.stack.Push(this);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            prescriptionMedicine pm = new prescriptionMedicine();
            this.Hide();
            pm.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Diamicron dm = new Diamicron();
            Home.stack.Push(this);
            this.Hide();
            dm.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Montene mn = new Montene();
            Home.stack.Push(this);
            this.Hide();
            mn.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Zimax zm = new Zimax();
            Home.stack.Push(this);
            this.Hide();
            zm.ShowDialog();
            this.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            requestOrder ro = new requestOrder();
            Home.stack.Push(this);
            this.Hide();
            ro.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel5.Visible = !panel5.Visible;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            offer of = new offer();
            Home.stack.Push(this);
            this.Hide();
            of.ShowDialog();
            this.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pronor po = new pronor();
            Home.stack.Push(this);
            this.Hide();
            po.ShowDialog();
            this.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            location lc = new location();
            Home.stack.Push(this);
            this.Hide();
            lc.ShowDialog();
            this.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.OrangeRed;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            label18.ForeColor = Color.OrangeRed;
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label18.ForeColor = Color.Black;
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            label18.ForeColor = Color.OrangeRed;
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.ForeColor = Color.Black;
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            label16.ForeColor = Color.OrangeRed;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.ForeColor = Color.Black;
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.ForeColor = Color.OrangeRed;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.ForeColor = Color.Black;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label14.ForeColor = Color.OrangeRed;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Black;
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            label13.ForeColor = Color.OrangeRed;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.ForeColor = Color.Black;
        }

        

        private void label26_Click_1(object sender, EventArgs e)
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
                    string P1ID = FormatProductID(5);
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
                    string p2ID = FormatProductID(6);
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
                    string p3ID = FormatProductID(7);
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!sessionManager.IsLoggedIn)
                {
                    MessageBox.Show("Please Login or Sign Up", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string p4ID = FormatProductID(8);
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

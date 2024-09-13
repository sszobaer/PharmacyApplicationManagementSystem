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
    
    public partial class prescriptionMedicine : Form
    {
        public static Stack<Form> pmstack = new Stack<Form>();
        Functions con;
        public prescriptionMedicine()
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
        string p1Name = "FILFRESH 3MG Tab";
        double p1Price = 3.01;

        string p2Name = "Co-Dopa 110MG Tab";
        double p2Price = 7;

        string p3Name = "OPTIMOX 5ML Eye Drop";
        double p3Price = 160;

        string p4Name = "LIJENTA 5 MG Tab";
        double p4Price = 22;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FileFreshDetails ffd = new FileFreshDetails();
            Home.stack.Push(this);
            this.Hide();
            ffd.ShowDialog(); 
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CoDopaCR cdr = new CoDopaCR();
            Home.stack.Push(this);
            this.Hide();
            cdr.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            prescriptionMedicine pm = new prescriptionMedicine();
            Home.stack.Push(this);
            this.Hide();
            pm.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            prescriptionMedicine2 pm2 = new prescriptionMedicine2();
            Home.stack.Push(this);
            this.Hide();
            pm2.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (prescriptionMedicine.pmstack.Count > 0)
            {
                Form previousForm = prescriptionMedicine.pmstack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel5.Visible = !panel5.Visible;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            optimox op = new optimox();
            Home.stack.Push(this);
            this.Hide();
            op.ShowDialog();
            this.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            lijenta lj = new lijenta();
            Home.stack.Push(this);
            this.Hide();
            lj.ShowDialog();
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

        private void label16_Click(object sender, EventArgs e)
        {
            offer of = new offer();
            Home.stack.Push(this);
            this.Hide();
            of.ShowDialog();
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
            label17.ForeColor = Color.OrangeRed;
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

        private void AddToCartBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!sessionManager.IsLoggedIn)
                {
                    MessageBox.Show("Please Login or Sign Up", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string p1ID = FormatProductID(1);
                    string query = "INSERT INTO ProductTable VALUES (@pId, @pName, @price, @pStatus, @username)";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@pId", p1ID},
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
                    string p2ID = FormatProductID(2);
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
                    string p3ID = FormatProductID(3);
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
                    string p4ID = FormatProductID(4);
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

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            FileFreshDetails ffd = new FileFreshDetails();
            Home.stack.Push(this);
            this.Hide();
            ffd.ShowDialog();
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
    }
}

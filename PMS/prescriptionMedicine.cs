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
    
    public partial class prescriptionMedicine : Form
    {
        public static Stack<Form> pmstack = new Stack<Form>();
        public prescriptionMedicine()
        {
            InitializeComponent();
        }
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
            this.Hide();
            pm.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            prescriptionMedicine2 pm2 = new prescriptionMedicine2();
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
    }
}

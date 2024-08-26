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
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            if (Form1.stack.Count > 0)
            {
                Form previousForm = Form1.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            Form1.stack.Push(this);
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            requestOrder ro = new requestOrder();
            Form1.stack.Push(this);
            this.Hide();
            ro.ShowDialog();
            this.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            offer of = new offer();
            Form1.stack.Push(this);
            this.Hide();
            of.ShowDialog();
            this.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            location lc = new location();
            Form1.stack.Push(this);
            this.Hide();
            lc.ShowDialog();
            this.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Contacts cn = new Contacts();
            Form1.stack.Push(this);
            this.Hide();
            cn.ShowDialog();
            this.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            adminDashboard ad = new adminDashboard();
            Form1.stack.Push(this);
            this.Hide();
            ad.ShowDialog();
            this.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            Form1.stack.Push(this);
            this.Hide();
            employee.ShowDialog();
            this.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Department dept = new Department();
            Form1.stack.Push(this);
            this.Hide();
            dept.ShowDialog();
            this.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            salary sal = new salary();
            Form1.stack.Push(this);
            this.Hide();
            sal.ShowDialog();
            this.Show();
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}

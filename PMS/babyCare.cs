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
    public partial class babyCare : Form
    {
        public babyCare()
        {
            InitializeComponent();
        }

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
    }
}

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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;//ms
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<100)
            {
                //0 +1 = 1 , 1+1 = 2......100
                progressBar1.Value += 1;
            }
            else
            {
                timer1.Stop();
                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}

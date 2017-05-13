using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco2City
{
    public partial class Renti : Form
    {
        public Renti()
        {
            InitializeComponent();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 12;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 13;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 14;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 15;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 16;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 17;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 18;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 19;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }
    }
}

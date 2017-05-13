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
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 13;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 14;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 15;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 16;
        }

        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 17;
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 18;
        }

        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 19;
            MessageBox.Show(Form1.y.ToString());
        }
    }
}

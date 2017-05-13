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

    public partial class Nikaia : Form

    {
        
        public Nikaia()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 6;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 7;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

        
    }
}

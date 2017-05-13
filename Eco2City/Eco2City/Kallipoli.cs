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
    public partial class Kallipoli : Form
    {
        
        public Kallipoli()
        {
            InitializeComponent();

        }

        private void b5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void id1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
             Form1.y = 1;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 2;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 3;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 4;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 5;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

       
    }
}

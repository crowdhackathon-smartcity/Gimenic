﻿using System;
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
    public partial class Koridallos : Form
    {
        public Koridallos()
        {
            InitializeComponent();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 8;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
            


        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 9;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();

        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 10;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            Form1.y = 11;
            Last last = new Last();
            last.Tag = this;
            last.Show(this);
            Hide();
        }

        private void Koridallos_Load(object sender, EventArgs e)
        {

        }
    }
}

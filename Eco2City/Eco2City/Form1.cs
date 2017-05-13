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
    public partial class Form1 : Form
    {
        bool fadeflag = false;
        public Form1()
        {
            
            InitializeComponent();
            geia.Visible = true;
            kalwsorisma.Visible = false;
            geia.ForeColor = this.BackColor;
            kalwsorisma.ForeColor = this.BackColor;
            geiaTimer.Enabled=true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = 3;
            if (!fadeflag)
            {
                kalwsorisma.ForeColor = Color.FromArgb(kalwsorisma.ForeColor.R - fadingSpeed, kalwsorisma.ForeColor.G - fadingSpeed, kalwsorisma.ForeColor.B - fadingSpeed);
            }
            if (kalwsorisma.ForeColor.R == 0) fadeflag = true;

            if (fadeflag)
            {
                kalwsorisma.ForeColor = Color.FromArgb(kalwsorisma.ForeColor.R + fadingSpeed, kalwsorisma.ForeColor.G + fadingSpeed, kalwsorisma.ForeColor.B + fadingSpeed);
            }
            if (kalwsorisma.ForeColor.R == this.BackColor.R)
            {
                fadeflag = false;
                kalwsorisma.Visible = false;
            }

            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = 3;
            if (!fadeflag)
            {
                geia.ForeColor = Color.FromArgb(geia.ForeColor.R - fadingSpeed, geia.ForeColor.G - fadingSpeed, geia.ForeColor.B - fadingSpeed);
            }
            if (geia.ForeColor.R == 0) fadeflag = true;

            if (fadeflag)
            {
                geia.ForeColor = Color.FromArgb(geia.ForeColor.R + fadingSpeed, geia.ForeColor.G + fadingSpeed, geia.ForeColor.B + fadingSpeed);
            }
            if (geia.ForeColor.R == this.BackColor.R)
            {
                geiaTimer.Stop();
                fadeflag = false;
                geia.Visible = false;
                kalwsorisma.Visible = true;
                KalwsorTimer.Start();
            }
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

           
            
        }

        private void cb1_DropDownClosed(object sender, EventArgs e)
        {
            string x = cb1.SelectedItem.ToString();
            MessageBox.Show(x);
        }
    }
}

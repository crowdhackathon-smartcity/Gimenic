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
        public string x;
        public Form2()
        {
            InitializeComponent();

           
            
        }

        private void cb1_DropDownClosed(object sender, EventArgs e)
        {
             x = cb1.SelectedItem.ToString();


            if (x=="Καλλίπολη")
            {
                {

                   

                    
                    try

                    {

                        StringBuilder queryadress = new StringBuilder();

                        queryadress.Append("https://www.google.gr/maps/place/Kallipoli,+Pireas+185+39/@37.9307333,23.633287,17z/data=!3m1!4b1!4m5!3m4!1s0x14a1b963aac49e3f:0x7c2e3e6cfb4efbc8!8m2!3d37.9307333!4d23.6354757?hl=en");


                        webBrowser1.Navigate(queryadress.ToString());

                    }



                    catch (Exception ex)

                    {

                        MessageBox.Show(ex.Message.ToString(), "Erro");

                    }

                }

            }
            else if (x=="Νίκαια")
            {

            }
            else if (x=="Κορυδαλλός")
            {

            }

            else if (x=="Ρέντη")
            {

            }

            else if (x=="Ελευσίνα")
            {

            }
        }
    }
}

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

                        queryadress.Append("https://www.openstreetmap.org/search?query=%CE%9A%CE%B1%CE%BB%CE%BB%CE%AF%CF%80%CE%BF%CE%BB%CE%B7%20%2C%20%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82#map=19/37.93010/23.63639");


                        webBrowser1.Navigate(queryadress.ToString());

                        co2lab.Visible = true;
                        humlab.Visible = true;
                        co2Pic.Visible = true;
                        HumPic.Visible = true;

                       

                    }



                    catch (Exception ex)

                    {

                        MessageBox.Show(ex.Message.ToString(), "Erro");

                    }

                }

            }
            else if (x=="Νίκαια")
            {
                {
                  try

                    {

                        StringBuilder queryadress = new StringBuilder();

                        queryadress.Append("https://www.openstreetmap.org/search?query=%CE%9D%CE%AF%CE%BA%CE%B1%CE%B9%CE%B1%20%2C%20%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82#map=18/37.94829/23.64344");


                        webBrowser1.Navigate(queryadress.ToString());


                        co2lab.Visible = true;
                        humlab.Visible = true;
                        co2Pic.Visible = true;
                        HumPic.Visible = true;



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Erro");
                    }

                }
            }
            else if (x=="Κορυδαλλός")
            {
                {
                    try

                    {

                        StringBuilder queryadress = new StringBuilder();

                        queryadress.Append("https://www.openstreetmap.org/search?query=%CE%9A%CE%BF%CF%81%CF%85%CE%B4%CE%B1%CE%BB%CE%BB%CF%8C%CF%82%20%2C%20%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82#map=15/37.9748/23.6572");


                        webBrowser1.Navigate(queryadress.ToString());


                        co2lab.Visible = true;
                        humlab.Visible = true;
                        co2Pic.Visible = true;
                        HumPic.Visible = true;



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Erro");
                    }

                }

            }

            else if (x=="Ρέντη")
            {
                {
                    try

                    {

                        StringBuilder queryadress = new StringBuilder();

                        queryadress.Append("https://www.openstreetmap.org/search?query=%CE%A1%CE%AD%CE%BD%CF%84%CE%B7%20%2C%20%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82#map=17/37.95557/23.66905");


                        webBrowser1.Navigate(queryadress.ToString());

                        co2lab.Visible = true;
                        humlab.Visible = true;
                        co2Pic.Visible = true;
                        HumPic.Visible = true;



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Erro");
                    }

                }
            }

            else if (x=="Ελευσίνα")
            {
                {
                    try

                    {

                        StringBuilder queryadress = new StringBuilder();

                        queryadress.Append("https://www.openstreetmap.org/search?query=%CE%95%CE%BB%CE%B5%CF%85%CF%83%CE%AF%CE%BD%CE%B1%20%2C%20%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82#map=13/38.0277/23.5996");


                        webBrowser1.Navigate(queryadress.ToString());

                       

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Erro");
                    }

                }
            }
        }

        private void BackFromMaps_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Tag = this;
            form1.Show(this);
            Hide();
        }
    }
}

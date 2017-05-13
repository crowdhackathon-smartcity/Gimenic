using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace Eco2City
{
    public partial class Last : Form
    {
        public Last()
      {
           
            
            InitializeComponent();
            string val1 = Form1.x;
            int val2 = Form1.y;
            string connectionString = "SERVER=localhost;DATABASE=db;UID=root;PASSWORD=1234;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("select Co2 from db.data, db.info where (info.city=@param_val_1 and info.idsensor=@param_val_2)and info.idsensor=data.idsensor", connection);
            cmd.Parameters.AddWithValue("@param_val_1", val1);
            cmd.Parameters.AddWithValue("@param_val_2", val2);
            connection.Open();
            DataTable dt = new DataTable();

            dt.Load(cmd.ExecuteReader());

            connection.Close();
            var rows = dt.AsEnumerable().ToArray();
            for (int i = 0; i < rows.Length; i++)
            {
                var value = rows[i]["Co2"];
                MessageBox.Show(value.ToString());
            }

            if (Form1.y == 1)
            {
                pictureBox1.BackgroundImage = Image.FromFile("1.png");
            }

            if (Form1.y == 2)
            {
                pictureBox1.BackgroundImage = Image.FromFile("2.png");

            }

            if (Form1.y == 3)
            {
                pictureBox1.BackgroundImage = Image.FromFile("3.png");
            }

            if (Form1.y == 4)
            {
                pictureBox1.BackgroundImage = Image.FromFile("4.png");
            }

            if (Form1.y == 5)
            {
                pictureBox1.BackgroundImage = Image.FromFile("5.png");
            }

            if (Form1.y == 6)
            {
                pictureBox1.BackgroundImage = Image.FromFile("6.png");
            }

            if (Form1.y == 7)
            {
                pictureBox1.BackgroundImage = Image.FromFile("7.png");
            }

            if (Form1.y == 8)
            {
                pictureBox1.BackgroundImage = Image.FromFile("8.png");
            }

            if (Form1.y == 9)
            {
                pictureBox1.BackgroundImage = Image.FromFile("9.png");
            }

            if (Form1.y == 10)
            {
                pictureBox1.BackgroundImage = Image.FromFile("10.png");
            }

            if (Form1.y == 11)
            {
                pictureBox1.BackgroundImage = Image.FromFile("11.png");
            }

            if (Form1.y == 12)
            {
                pictureBox1.BackgroundImage = Image.FromFile("12.png");
            }

            if (Form1.y == 13)
            {
                pictureBox1.BackgroundImage = Image.FromFile("13.png");
            }

            if (Form1.y == 14)
            {
                pictureBox1.BackgroundImage = Image.FromFile("14.png");
            }

            if (Form1.y == 15)
            {
                pictureBox1.BackgroundImage = Image.FromFile("15.png");
            }

            if (Form1.y == 16)
            {
                pictureBox1.BackgroundImage = Image.FromFile("16.png");

               
            }

            if (Form1.y == 17)
            {
                pictureBox1.BackgroundImage = Image.FromFile("17.png");
            }

            if (Form1.y == 18)
            {
                pictureBox1.BackgroundImage = Image.FromFile("18.png");
            }

            if (Form1.y == 19)
            {
                pictureBox1.BackgroundImage = Image.FromFile("19.png");
            }

            if (Form1.y == 20)
            {
                pictureBox1.BackgroundImage = Image.FromFile("20.png");
            }

        }

        private void Last_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }
    }
}

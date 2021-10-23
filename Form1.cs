using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int toplamben = 0, toplamrakip = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;

            int c = rastgele.Next(1, 7);
            label10.Text = c.ToString();
            int d = rastgele.Next(1, 7);
            label9.Text = d.ToString();
            toplamrakip += c + d;
            label15.Text = toplamrakip.ToString();

            if (c == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\zar1.png";
            }
            if (c == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\2.png";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\3.png";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\4.png";
            }
            if (c == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\5.png";
            }
            if (c == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\6.png";
            }



            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\zar1.png";
            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\2.png";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\3.png";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\4.png";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\5.png";
            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\6.png";
            }


            if (toplamben > 100 && toplamben >toplamrakip)
            {
                label13.Text = " KAZANDINIZ... TEBRİKLER!!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            int a = rastgele.Next(1, 7);
            label3.Text = a.ToString();
            int b = rastgele.Next(1, 7);
            label4.Text = b.ToString();
            toplamben += a + b;
            if (a==1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\zar1.png";
            }
            if (a==2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\2.png";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\3.png";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\4.png";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\5.png";
            }
            if (a == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\6.png";
            }





            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\zar1.png";
            }
             if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\2.png";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\3.png";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\4.png";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\5.png";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\faruk\\OneDrive\\Masaüstü\\Zar\\6.png";
            }

            label16.Text = toplamben.ToString();

            if (toplamrakip > 100 && toplamrakip > toplamben)
            {
                label13.Text = " KAZANAN BİLGİSAYAR... KAYBETTİNİZ!!!";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITU_ZarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int toplamben;
        int toplampc;
        private void button1_Click(object sender, EventArgs e)
        {
            int a=rastgele.Next(1,7);
            int b = rastgele.Next(1, 7);

            toplamben = toplamben + a + b;
            label16.Text = "" + toplamben.ToString();

            if (a==1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\1.png";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\2.jpeg";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\3.jpeg";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\4.png";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\5.jpeg";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\6.jpeg";
            }


            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\1.png";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\2.jpeg";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\3.jpeg";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\4.png";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\5.jpeg";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\6.jpeg";
            }

            label3.Text=a.ToString();
            label4.Text=b.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = rastgele.Next(1, 7);
            int d = rastgele.Next(1, 7);

            toplampc = toplampc + c + d;
            label15.Text=toplampc.ToString();

            label10.Text = c.ToString();
            label9.Text = d.ToString();

            if (c == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\1.png";
            }
            if (c == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\2.jpeg";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\3.jpeg";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\4.png";
            }
            if (c == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\5.jpeg";
            }
            if (c == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\6.jpeg";
            }


            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\1.png";
            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\2.jpeg";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\3.jpeg";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\4.png";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\5.jpeg";
            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\atikm\\OneDrive\\Masaüstü\\ZAR\\Image\\6.jpeg";
            }

            if(toplamben > 100 && toplamben>toplampc)
            {
                label13.Text = "Kazanan Sizsiniz !! Tebrikler";
            }
            if (toplampc>100 && toplampc>toplamben)
            {
                label13.Text = "Kazanan Bilgisayar !! Siz Kaybettiniz";

            }
        }
    }
}

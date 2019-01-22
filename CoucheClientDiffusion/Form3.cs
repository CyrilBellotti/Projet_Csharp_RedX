using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoucheClientDiffusion
{
    public partial class Form3 : Form
    {
        int picture;
        public Form3(int i)
        {
            picture = i;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            string p1 = " ";

            if (picture == 3)
            {
                //   p1 = @"C:\Users\Cyril\Desktop\PROJET .NET\photo1.png";
                p1 = @"C:\Users\Cyril\Desktop\image\noirmod.jpg";
            }

            pictureBox1.Image = Image.FromFile(p1);
            var bmp1 = new Bitmap(pictureBox1.Image);
            bmp1.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = bmp1;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            //Configuration Image du DROITE
            pictureBox2.Image = Image.FromFile(p1);
            var bmp2 = new Bitmap(pictureBox2.Image);
            bmp2.RotateFlip(RotateFlipType.Rotate270FlipX);
            pictureBox2.Image = bmp2;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            //Configuration Image de BAS
            pictureBox3.Image = Image.FromFile(p1);
            var bmp3 = new Bitmap(pictureBox3.Image);
            bmp3.RotateFlip(RotateFlipType.Rotate180FlipX);
            pictureBox3.Image = bmp3;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;

            //Configuration Image de GAUCHE
            pictureBox4.Image = Image.FromFile(p1);
            var bmp4 = new Bitmap(pictureBox4.Image);
            bmp4.RotateFlip(RotateFlipType.Rotate90FlipX);
            pictureBox4.Image = bmp4;
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

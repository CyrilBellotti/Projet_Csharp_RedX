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
    public partial class Form2 : Form
    {
   //     private string newtext;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked && checkBox2.CheckState == CheckState.Checked || checkBox1.CheckState == CheckState.Checked && checkBox3.CheckState == CheckState.Checked || checkBox3.CheckState == CheckState.Checked && checkBox2.CheckState == CheckState.Checked || checkBox1.CheckState == CheckState.Checked && checkBox2.CheckState == CheckState.Checked && checkBox3.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Veuillez ne cocher qu'une seule case.", "Rappel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                checkBox1.CheckState = CheckState.Unchecked;
                checkBox2.CheckState = CheckState.Unchecked;
                checkBox3.CheckState = CheckState.Unchecked;

            }
            if (checkBox1.CheckState == CheckState.Unchecked && checkBox2.CheckState == CheckState.Unchecked && checkBox3.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Vous n'avez rien cocher, veuillez cocher une case", "Rappel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (checkBox1.CheckState == CheckState.Checked)
                {
                    Form1 frm = new Form1(1);
                    frm.Show();
                }

                if (checkBox2.CheckState == CheckState.Checked)
                {
                    Form5 frm = new Form5();
                    frm.Show();
                }
                if (checkBox3.CheckState == CheckState.Checked)
                {
                    if (String.IsNullOrEmpty(textBox1.Text))
                    {
                        MessageBox.Show("Le champ est vide, veuillez entrer du texte", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        //dataGridView1.Rows.Clear();
                    }
                    else
                    {
                        Form3 frm = new Form3(3);
                        frm.Show();
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Le champ est vide, veuillez entrer du texte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //dataGridView1.Rows.Clear();
            }
            else
            {
            
            PointF firstLocation = new PointF(0,0);
            string imageFilePath = @"C:\Users\Cyril\Desktop\image\noir.jpg";

            Bitmap bitmap = (Bitmap)Image.FromFile(imageFilePath);//load the image file

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Font arialFont = new Font("Arial", 100))
                {
                    graphics.DrawString(text1, arialFont, Brushes.White, firstLocation);
                }
            }

            bitmap.Save(@"C:\Users\Cyril\Desktop\image\noirmod.jpg");//save the image file
     //       newtext = @"C:\Users\Cyril\Desktop\image\noirmod.jpg";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

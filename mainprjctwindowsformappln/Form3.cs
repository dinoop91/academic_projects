using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
        Class1 cs=new Class1();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text="";
            if(radioButton1.Checked)
            {
                text=textBox1.Text;
            }
            else
            {
                text=File.ReadAllText(textBox2.Text);
            }
         string encrypt=  cs.Encrypt(text, textBox3.Text);

            byte[] tarray = ASCIIEncoding.ASCII.GetBytes(encrypt);
          int  f1 = tarray.Length;
            int kbs = f1 / 1024;
            int balbytes = f1 % 1024;
            int byts = balbytes / 256;
            int rem = balbytes % 256;
            int count;
        int z = 0;
            count = 0;
      Bitmap bmp = new Bitmap(textBox4.Text);
            int w = bmp.Width;
            int h=bmp.Height;
            int imgsize = h * w;
            int offset = imgsize / (f1);
            bmp.SetPixel(0, 0, Color.FromArgb(kbs, byts, rem));
            int div = offset;
            for (int x = 0; x < h; x++)
            {
                for (int y = 0; y < w; y++)
                {
                    count++;
                    if (count == div && z < f1)
                    {
                        Color c = bmp.GetPixel(y, x);
                        bmp.SetPixel(y, x, Color.FromArgb(tarray[z++], c.G, c.B));
                        div = div + offset;
                    }
                }
            }
            bmp.Save(textBox5.Text);
            MessageBox.Show("hide");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = saveFileDialog1.FileName;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox4.Text = openFileDialog1.FileName;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {

                textBox2.Text = openFileDialog2.FileName;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
            label1.Visible = true; ;
            textBox1.Visible = true; 

        }

        private void radioButton1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            label2.Visible = true;
            button1.Visible = true;

        }
    }
}

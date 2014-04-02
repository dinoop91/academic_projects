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
    public partial class Form4 : Form
    {
        Class1 cls=new Class1();
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(openFileDialog1.FileName);
            Color c = bmp.GetPixel(0, 0);
            int kbs = (int)(c.R);
            int byts = (int)(c.G);
            int rem = (int)(c.B);
            int div = 0;
            int textsize = (kbs * 1024) + (byts * 256) + (rem);
            int h = bmp.Height;
            int w = bmp.Width;
            int count, i = 0;
            int imgsize = h * w;
            int offset = (int)(imgsize / (textsize));
            count = 0;
            div = offset;
            string txt4 = textBox3.Text;
            byte[] text = new byte[textsize];
            for (int a = 0; a < h; a++)
            {
                for (int b = 0; b < w; b++)
                {
                    count++;
                    if (i < textsize && (count == div))
                    {
                        c = bmp.GetPixel(b, a);
                        text[i++] = c.R;

                        div = div + offset;
                    }
                }

            }
                string txt = ASCIIEncoding.ASCII.GetString(text);
            textBox4.Text=    cls.Decrypt(txt, textBox2.Text);
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
            StreamWriter b2 = new StreamWriter(fs);
            b2.Write(textBox4.Text);
            b2.Flush();
            b2.Close();
            fs.Close();
            
        }


        private void Form4_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox3.Text = saveFileDialog1.FileName;

            }
        }
        
              
        }
}
    
    


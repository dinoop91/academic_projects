using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Imaging;

namespace OCR
{
    public partial class ocr : Form
    {

        
        public Bitmap b1;
        public ocr()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "BMPs|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                b1 = new Bitmap(openFileDialog1.FileName);
                selectimagebox.Text = openFileDialog1.FileName;
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {

        }
    }
}

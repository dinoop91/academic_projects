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
    public partial class OCR : Form
    {
        //private AxMODI.AxMiDocView axMiDocView1;
        //private MODI.Document_MODIDocument=null;
        //Bitmap bmpsave=new Bitmap(100,100);
        //public Bitmap m_objBitmap;
        
        public OCR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Convert this To Text?", "Convert?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string strfilename = "temp" + DateTime.Now.Millisecond + ".tiff";
                try
                {
                    Bitmap b1 =(Bitmap) pictureBox1.Image;
                    b1.Save(strfilename,System.Drawing.Imaging.ImageFormat.Tiff);
                    MODI.Document md = new MODI.Document();
                    md.Create(strfilename);
                    md.OCR(MODI.MiLANGUAGES.miLANG_ENGLISH, true, true);
                    string strtext = string.Empty;
                    MODI.Image image = (MODI.Image)md.Images[0];
                    MODI.Layout layout = image.Layout;
                    for (int i = 0; i < layout.Words.Count; i++)
                    {
                        MODI.Word word = (MODI.Word)layout.Words[i];
                        if (strtext.Length > 0)
                        {
                            strtext += " ";
                        }
                        strtext += word.Text;
                    }
                    md.Close(false);
                    Program.imagetext = strtext;
                    Form1 w1 = new Form1();
                    w1.Show();
                    //MessageBox.Show(strtext);
                    textBox1.Text = strtext;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                try
                {
                    File.Delete(strfilename);
                }
                catch
                { }
            }
            Close();
                 
        }

        private void OCR_Load(object sender, EventArgs e)
        {
            OCR fr = new OCR();
            string si = fr.Size.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

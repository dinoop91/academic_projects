using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class htmleditor : Form
    {
        string str = "";
        string s;
        public htmleditor()
        {
            InitializeComponent();
        }

        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            htmleditor h1 = new htmleditor();
            h1.Text = "";
            h1.Show();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "html|*.html";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                str = openFileDialog1.FileName;
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str1 = richTextBox1.Text;
            if (str != "")
            {
                FileStream fs = new FileStream(str, FileMode.Create, FileAccess.Write);
                BinaryWriter b1 = new BinaryWriter(fs);
                b1.Write(str1);
                b1.Close();
            }
            else
            {
                saveFileDialog1.Filter = "html|*.html";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    str = saveFileDialog1.FileName;
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                }
            }

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string html = richTextBox1.Text;
            FileStream fs = new FileStream(Application.StartupPath+"\\html.htm", FileMode.Create, FileAccess.Write);
           StreamWriter  b2 = new StreamWriter(fs);
            b2.Write(html);
            b2.Flush();
            b2.Close();
            fs.Close();

            
            string str=Application.StartupPath + "\\html.htm";
            Process.Start("C:\\Program Files\\Internet Explorer\\iexplore.exe", Application.StartupPath + "\\html.htm");
        }
        //E:\MAIN PROJECT\WindowsFormsApplication3\WindowsFormsApplication3\bin\Debug\html.htm

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void fontcolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Bitmaps(*.bmp),GIFs(*.gif),JPEGs(*.jpg)|*.bmp;*.gif;*.jpg|Bitmaps(*.bmp)|*.bmp|Gifs(*.gif)|*.gif|JPEGs(*.jpg)|*.jpg"; ;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imageurl = openFileDialog1.FileName;
                string image = "\n<div><image src=\"" + imageurl + "\"/></div>/n";
                int p = s.IndexOf("</BODY>");
                s = s.Insert(p, image);
                richTextBox1.Text = s;
               // richTextBox1.Text = "";
            }
        }

        private void htmleditor_Load(object sender, EventArgs e)
        {
            s = "<HTML>\n\n<HEAD>\n\n<TITLE>WebPage</TITLE>\n\n</HEAD>\n\n<BODY>\n\n</BODY>\n\n</HTML>";
            richTextBox1.Text = s;
        }

        

        private void unnumberedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string unnumberlist = "\n<UL>\n<LI>unnumbered list\n<LI>Type your text here\n<LI>Type your text here and add more\n<LI>If necessary\n<UL>\n";
            int p = s.IndexOf("</BODY>");
            s = s.Insert(p, unnumberlist);
            richTextBox1.Text = s;

        }

        private void numberedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string numberlist = "\n<OL>\n<LI>numbered list\n<LI>Type your text here\n<LI>Type your text here and add more\n<LI>If necessary\n<OL>\n";
            int p = s.IndexOf("</BODY>");
            s = s.Insert(p, numberlist);
            richTextBox1.Text = s;
        }

        private void definitionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string definitionlist = "\n<DL>\n<DT>definitionlist\n<DD>Type your text here\n<DT>Second Paragraph Title\n<DD>If necessary\n<DL>\n";
            int p = s.IndexOf("</BODY>");
            s = s.Insert(p, definitionlist);
            richTextBox1.Text = s;
        }

        private void linkWithImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Bitmaps(*.bmp),GIFs(*.gif),JPEGs(*.jpg)|*.bmp;*.gif;*.jpg|Bitmaps(*.bmp)|*.bmp|Gifs(*.gif)|*.gif|JPEGs(*.jpg)|*.jpg"; ;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagelinkurl = openFileDialog1.FileName;
                string linkimage = "\n<a href='" + "" + "',><img alt='" + "" + "',src=''" + imagelinkurl + "',Border=0><\a>\n";
                int p = s.IndexOf("</BODY>");
                s = s.Insert(p, linkimage);
                richTextBox1.Text = s;
            }
        }
    

        private void whiteSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string whitespace="\n<P>&nbsp;</p>\n";
            int p = s.IndexOf("</BODY>");
            s = s.Insert(p, whitespace);
            richTextBox1.Text = s;
        }
}
}
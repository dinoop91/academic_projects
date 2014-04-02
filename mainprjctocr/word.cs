using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Speech.Recognition;
using SpeechLib;
using System.Speech.Recognition.SrgsGrammar;
using System.Runtime.InteropServices;
using System.Threading;

namespace OCR
{
    public partial class word : Form
    {
        int line = 1;
        justify j1 = new justify();
        public static string save = "";
        public word()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            richTextBox1.Refresh();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            float zoom = richTextBox1.ZoomFactor;
            float zoom1 = (zoom * 100) + 100;
            richTextBox1.ZoomFactor = zoom1 / 100;

        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            float zoom = richTextBox1.ZoomFactor;
            float zoom1 = (zoom * 100) - 100;
            if (zoom > 1.0)
                richTextBox1.ZoomFactor = zoom1 / 100;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "RichText|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(openFileDialog1.FileName);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            word w1 = new word();
            w1.Show();
            this.Hide();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Arial", (float)9.75, FontStyle.Bold);
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
           // richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
           // richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            //richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Arial", (float)9.75, FontStyle.Italic);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Arial", (float)9.75, FontStyle.Underline);
        }

        private void htmlEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            html_editor h1 = new html_editor();
            h1.Show();
            this.Hide();
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            web_browser w1 = new web_browser();
            w1.Show();
            this.Hide();
            
        }

        private void oCRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocr o1 = new ocr();
            o1.Show();
            this.Hide();
        }

        private void word_Load(object sender, EventArgs e)
        {
            Program.str = richTextBox1.Text;
            if (Program.text != "")
            {
                richTextBox1.Text = Program.text;
            }
            if (Program.decrypttext != "")
            {
                richTextBox1.Text = Program.decrypttext;
            }
        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RichText|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(saveFileDialog1.FileName);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "RichText|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(openFileDialog1.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "RichText|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                save = openFileDialog1.FileName;
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string st = richTextBox1.Text;

            if (save != "")
            {
                FileStream ts = new FileStream(save, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(ts);
                bw.Write(st);
                bw.Close();
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    save = saveFileDialog1.FileName;
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                }


            }

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RichText|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(saveFileDialog1.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            string s = richTextBox1.Text;
            string j = j1.Justify(s, 5);
            richTextBox1.Text = j;
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void fontColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void backColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionBackColor = colorDialog1.Color;
        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //int currentline = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
            //if (currentline > line)
            //{
            //    line = currentline;
            //    Font tempfont = richTextBox1.Font;
            //    int margin = richTextBox1.Bounds.Height - richTextBox1.ClientSize.Height;
            //    richTextBox1.Height = (TextRenderer.MeasureText(" ", tempfont).Height * line) + margin + 2;

            //}
        }

        private void imageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        



            OpenFileDialog getpicture = new OpenFileDialog();
            getpicture.Filter="Bitmaps (*.bmp), GIFs (*.gif), JPEGs (*.jpg)|*.bmp;*.gif;*.jpg|Bitmaps (*.bmp)|*.bmp|GIFs (*.gif)|*.gif|JPEGs (*.jpg)|*.jpg";;
            getpicture.FilterIndex = 1;
            getpicture.InitialDirectory = "c:\\";
            if (getpicture.ShowDialog() == DialogResult.OK)
            {
                string selectedpicture = getpicture.FileName;
                Bitmap bm = new Bitmap(selectedpicture);
                Clipboard.SetImage(bm);
                DataFormats.Format fr = DataFormats.GetFormat(DataFormats.Bitmap);
                if (richTextBox1.CanPaste(fr))
                {
                    richTextBox1.Paste(fr);
                }
            }
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int position = richTextBox1.SelectionStart;
            string textbfr = richTextBox1.Text.Substring(0, position);
            string textaftr = richTextBox1.Text.Substring(position);
            string curntdate = " " +System.DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + " ";
            richTextBox1.Text = textbfr + curntdate + textaftr;

        }

        private void bulletsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.BulletIndent = 10;
            richTextBox1.SelectionBullet = true;

        }

       
        

        private void speechToConvertionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox1.SelectedText != " ")
            {
                SpVoice voice = new SpVoice();
                voice.Volume = 100;
                voice.Speak(richTextBox1.SelectedText, SpeechVoiceSpeakFlags.SVSFlagsAsync);
                voice.WaitUntilDone(Timeout.Infinite);
            }

            else

                MessageBox.Show("No Content");

        }

        private void wordToBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ende = "R1";
            Program.text = richTextBox1.Text;
            pascii p1 = new pascii();
            p1.Show();
            this.Hide();
        }

        private void wordToHexaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ende = "R2";
            
            Program.text = richTextBox1.Text;
            
            pascii p1 = new pascii();
            p1.Show();
            this.Hide();
        }

        private void binaryToWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ende = "R3";
            Program.text = richTextBox1.Text;

            pascii p1 = new pascii();
            p1.Show();
            this.Hide();
        }

        private void hexaToWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ende = "R4";
            Program.text = richTextBox1.Text;
            pascii p1 = new pascii();
            p1.Show();
            this.Hide();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bulletsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Bullets.Checked)
                {
                    this.Bullets.Checked = false;
                    this.Bullets.Checked = false;

                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();

                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.None;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndParenthesis;
                    this.richTextBox1.SelectionListType = pls;
                }
                else
                {
                    this.Bullets.Checked = false;
                    this.Bullets.Checked = true;

                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();

                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.Bullet;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndPeriod;
                    this.richTextBox1.SelectionListType = pls;
                }
            }
            catch (Exception)
            { }


        }

        private void numbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.numbering.Checked)
                {
                    this.numbering.Checked = false;
                    this.numbering.Checked = false;

                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();

                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.None;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndParenthesis;
                    this.richTextBox1.SelectionListType = pls;

                }
                else
                {
                    this.numbering.Checked = false;
                    this.numbering.Checked = true;

                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();

                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.Numbers;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndPeriod;
                    this.richTextBox1.SelectionListType = pls;
                }
            }
            catch (Exception)
            {

            }
        }

        private void capitalRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.capitalRoman.Checked)
                {
                    this.capitalRoman.Checked = false;
                    this.capitalRoman.Checked = false;

                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();

                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.None;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndParenthesis;
                    this.richTextBox1.SelectionListType = pls;
                }
                else
                {
                    this.capitalRoman.Checked = false;
                    this.capitalRoman.Checked = true;

                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();

                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.CapitalRoman;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndPeriod;
                    this.richTextBox1.SelectionListType = pls;
                }
            }
            catch (Exception)
            { }
        }

        private void smallRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.smallRoman.Checked)
                {
                    this.smallRoman.Checked = false;
                    this.smallRoman.Checked = false;

                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();

                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.None;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndParenthesis;
                    this.richTextBox1.SelectionListType = pls;
                }
                else
                {
                    this.smallRoman.Checked = false;
                    this.smallRoman.Checked = true;

                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();

                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.SmallRoman;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndPeriod;
                    this.richTextBox1.SelectionListType = pls;
                }
            }
            catch (Exception)
            { }
        }

        private void capitalLettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.capitalLetters.Checked)
                {
                    this.capitalLetters.Checked = false;
                    this.capitalLetters.Checked = false;

                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();

                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.None;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndParenthesis;
                    this.richTextBox1.SelectionListType = pls;
                }
                else
                {
                    this.capitalLetters.Checked = false;
                    this.capitalLetters.Checked = true;

                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();

                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.CapitalLetters;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndPeriod;
                    this.richTextBox1.SelectionListType = pls;
                }
            }
            catch (Exception)
            { }
        }

        private void smallLetters_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.smallLetters.Checked)
                {
                    this.smallLetters.Checked = false;
                    this.smallLetters.Checked = false;

                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();

                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.None;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndParenthesis;
                    this.richTextBox1.SelectionListType = pls;
                }
                else
                {
                    this.smallLetters.Checked = false;
                    this.smallLetters.Checked = true;

                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();

                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.SmallLetters;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndPeriod;
                    this.richTextBox1.SelectionListType = pls;
                }
            }
            catch (Exception)
            { }
        }

        private void none_Click(object sender, EventArgs e)
        {
            try
            {
                
                    this.none.Checked = false;
                    this.none.Checked = false;

                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();

                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.None;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndParenthesis;
                    this.richTextBox1.SelectionListType = pls;
             }
                
            
            catch (Exception)
            { }

        }

        

    }
}


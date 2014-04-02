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
using System.Speech.Recognition.SrgsGrammar;
using System.Runtime.InteropServices;
using System.Threading;
using SpeechLib;
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public static string save = "";
        static int flag = 0;
        public static string path = "";
        public static ExtendedRichTextBox er = new ExtendedRichTextBox();
        static int tabindex=0;
        static string[] tabpath = new string[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            if (err.Text != "")
            {
                if (MessageBox.Show("Do you want to save", "wordmate", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {

                    saveFileDialog1.Filter = "Rich Text|*.rtf";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        err.SaveFile(saveFileDialog1.FileName);

                    }
                }
                else if (MessageBox.Show("Do you want to save", "wordmate", MessageBoxButtons.YesNoCancel) == DialogResult.No)
                { err.Text = ""; }

                     //(MessageBox.Show("Do you want to save", "wordmate", MessageBoxButtons.YesNoCancel) == DialogResult.Cancel)
                else { }

            }



        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Rich Text|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                path = openFileDialog1.FileName;

            }
            else
            { }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            string s1;
            s1 = err.Text;
            if (tabpath[tabindex] != null)
            {
                err.SaveFile(tabpath[tabindex]);
            }
            else
                // saveFileDialog1.Filter = "Rich Text|*.rtf";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog1.FileName;
                    tabpath[tabindex] = saveFileDialog1.FileName;
                    tabControl1.SelectedTab.Text = Path.GetFileNameWithoutExtension(tabpath[tabindex]) + "  X";
                    //richTextBox1.Text = "";
                }
            string st = err.Text;
            if (tabControl1.SelectedTab.Text != "New Document  X")
            {
                FileStream fs = new FileStream(tabpath[tabindex], FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(st);
                bw.Close();
                
            }




        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.Redo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.SelectAll();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.SelectedText = "";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            string s1;
            s1 = err.Text;
            if (path != "")
            {
                err.SaveFile(path);
            }
            else
                // saveFileDialog1.Filter = "Rich Text|*.rtf";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog1.FileName;
                    //richTextBox1.Text = "";
                }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.Cut();
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.Copy();
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.Paste();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.Undo();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.Redo();
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            float zoom = err.ZoomFactor;
            float zoom1 = (zoom * 100) + 100;
            err.ZoomFactor = zoom1 / 100;

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            string st = err.Text;

            err.Refresh();
            err.Text = st;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            if (err.Text == "")
            { this.Hide(); }

            else if (err.Text != "")
            {
                if (MessageBox.Show("Do you want to save", "wordmate", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {

                    saveFileDialog1.Filter = "Rich Text|*.rtf";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        err.SaveFile(saveFileDialog1.FileName);
                        //richTextBox1.Text = "";
                    }
                }
                else if (MessageBox.Show("Do you want to save", "wordmate", MessageBoxButtons.YesNoCancel) == DialogResult.No)
                { //richTextBox1.Text = "";
                    this.Hide();
                }

                if (MessageBox.Show("Do you want to save", "wordmate", MessageBoxButtons.YesNoCancel) == DialogResult.Cancel)
                { }

            }


        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.SelectionAlignment = ExtendedRichTextBox.RichTextAlign.Left;
            //richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.SelectionAlignment = ExtendedRichTextBox.RichTextAlign.Left;
            //richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.SelectionAlignment = ExtendedRichTextBox.RichTextAlign.Center;
            //ric.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.SelectionAlignment = ExtendedRichTextBox.RichTextAlign.Right;
            //richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void justifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.SelectionAlignment = ExtendedRichTextBox.RichTextAlign.Justify;
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.SelectionAlignment = ExtendedRichTextBox.RichTextAlign.Center;
            //richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.SelectionAlignment = ExtendedRichTextBox.RichTextAlign.Right;
            //richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            err.SelectionAlignment = ExtendedRichTextBox.RichTextAlign.Justify;

        }

        private void fontStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            fontDialog1.ShowDialog();
            err.Font = fontDialog1.Font;

        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            colorDialog1.ShowDialog();
            err.BackColor = colorDialog1.Color;

        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            colorDialog1.ShowDialog();
            err.ForeColor = colorDialog1.Color;
        }

        private void cmbfontsize_Click(object sender, EventArgs e)
        {

            //   err.Font = fontDialog1.Font;

        }

        private void cmbfontstyle_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            OpenFileDialog getpicture = new OpenFileDialog();
            getpicture.Filter = "Bitmaps(*.bmp),GIFs(*.gif),JPEGs(*.jpg)|*.bmp;*.gif;*.jpg|Bitmaps(*.bmp)|*.bmp|GIFs(*.gif)|*.gif|JPEGs(*.jpg)|*.jpg"; ;

            if (getpicture.ShowDialog() == DialogResult.OK)
            {
                string img = getpicture.FileName;
                Bitmap bm = new Bitmap(img);
                Clipboard.SetImage(bm);
                DataFormats.Format fr = DataFormats.GetFormat(DataFormats.Bitmap);
                if (err.CanPaste(fr))
                {
                    //Clipboard.GetImage();
                    err.Paste(fr);


                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            if (err.Text != "")
            {
                if (MessageBox.Show("Do you want to save", "wordmate", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {

                    saveFileDialog1.Filter = "Rich Text|*.rtf";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        err.SaveFile(saveFileDialog1.FileName);

                    }
                }
                else if (MessageBox.Show("Do you want to save", "wordmate", MessageBoxButtons.YesNoCancel) == DialogResult.No)
                { err.Text = ""; }

                     //(MessageBox.Show("Do you want to save", "wordmate", MessageBoxButtons.YesNoCancel) == DialogResult.Cancel)
                else { }

            }
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            int position = err.SelectionStart;
            string textbfr = err.Text.Substring(0, position);
            string textaftr = err.Text.Substring(position);
            string currentdate = "" + System.DateTime.Now.ToString("dd-MM-yyyy,hh:mm:ss") + "";
            err.Text = textbfr + currentdate + textaftr;
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            float zoom = err.ZoomFactor;

            float zoom1 = (zoom * 100) - 100;
            if (zoom1 > 1.0)
                err.ZoomFactor = zoom1 / 100;
            //try
            //{
            //    if (zoom1 <= 1)
            //    {
            //        err.ZoomFactor = 1;
            //    }
            //}
            //catch (Exception)
            //{
            //}
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            if (Program.bold1 == false && Program.italic1 == false && Program.under1 == false)
            {


                err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold);
                Program.bold1 = true;
            }

            else
                if (Program.bold1 == false && Program.italic1 == false && Program.under1 == true)
                {

                    err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold | FontStyle.Underline);
                    Program.bold1 = true;
                }

                else
                    if (Program.bold1 == false && Program.italic1 == true && Program.under1 == false)
                    {

                        err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold | FontStyle.Italic);
                        Program.bold1 = true;
                    }

                    else
                        if (Program.bold1 == false && Program.italic1 == true && Program.under1 == true)
                        {

                            err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                            Program.bold1 = true;
                        }
                        else
                            if (Program.bold1 == true && Program.italic1 == false && Program.under1 == false)
                            {

                                err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Regular);
                                Program.bold1 = false;
                            }
                            else
                                if (Program.bold1 == true && Program.italic1 == false && Program.under1 == true)
                                {

                                    err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Underline);
                                    Program.bold1 = false;

                                }
                                else
                                    if (Program.bold1 == true && Program.italic1 == true && Program.under1 == false)
                                    {

                                        err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Italic);
                                        Program.bold1 = false;

                                    }
                                    else if (Program.bold1 == true && Program.italic1 == true && Program.under1 == true)
                                    {

                                        err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Italic | FontStyle.Underline);
                                        Program.bold1 = false;

                                    }


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void hTMLEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            htmleditor h = new htmleditor();
            h.Show();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            saveFileDialog1.Filter = "RichText|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                err.SaveFile(saveFileDialog1.FileName);
                tabControl1.SelectedTab.Text = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName)+"  X";
                tabpath[tabindex] = saveFileDialog1.FileName;
            }
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void addnewtab()
        {
            // err = getcurrentrichtextbox();
            TabPage tpage = new TabPage();
            tpage.BorderStyle = BorderStyle.Fixed3D;
            tabControl1.TabPages.Insert(tabControl1.TabCount - 1, tpage);
            ExtendedRichTextBox err = new ExtendedRichTextBox();

            tpage.Controls.Add(err);
            err.Dock = DockStyle.Fill;
            tpage.Text = "New Document  X";
            tabControl1.SelectTab(tpage);
            err.Refresh();
            //browser.ProgressChanged+=new WebBrowserProgressChangedEventHandler(Form1_ProgressChanged);
            err.TextChanged += new EventHandler(err_TextChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            addnewtab();
            flag = 0;
            foreach (FontFamily f in System.Drawing.FontFamily.Families)
            {
                cmbfontstyle.Items.Add(f.Name);
            }
            cmbfontsize.SelectedIndex = 2;
            cmbfontstyle.SelectedIndex = 0;
            err.Text = Program.imagetext;
            Program.str = err.Text;
            if (Program.text != "")
            {
                err.Text = Program.text;
            }
            if (Program.decrypttext != "")
            {
                err.Text = Program.decrypttext;
            }
            //err.Location = richTextBox1.Location;
            //err.Size = richTextBox1.Size;
            //err.TabIndex = richTextBox1.TabIndex;
            //err.Lines = richTextBox1.Lines;


        }

        private void bulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void bulletsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            try
            {
                if (this.bulletsToolStripMenuItem1.Checked)
                {
                    this.bulletsToolStripMenuItem1.Checked = false;
                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();
                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.None;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndParenthesis;
                    err.SelectionListType = pls;
                }
                else
                {
                    this.bulletsToolStripMenuItem1.Checked = true;
                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();
                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.Bullet;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndPeriod;
                    err.SelectionListType = pls;

                }
            }
            catch (Exception)
            {
            }
        }


        private void allignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void err_TextChanged(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            if (err.Text != "")
            {
                string s = err.Text;
                string k = s.Substring(s.Length - 1, 1);
                if (k == " ")
                {
                    string[] w = s.Split(' ');
                    int i = w.Length;
                    SpVoice voice = new SpVoice();
                    voice.Volume = 100;
                    voice.Speak(err.SelectedText, SpeechVoiceSpeakFlags.SVSFlagsAsync);
                    voice.WaitUntilDone(Timeout.Infinite);
                }
            }

        }
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            if (Program.bold1 == false && Program.italic1 == false && Program.under1 == false)
            {


                err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Italic);
                Program.italic1 = true;
            }

            else
                if (Program.bold1 == false && Program.italic1 == false && Program.under1 == true)
                {

                    err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Italic | FontStyle.Underline);
                    Program.italic1 = true;
                }

                else
                    if (Program.bold1 == false && Program.italic1 == true && Program.under1 == false)
                    {

                        err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Regular);
                        Program.italic1 = false;
                    }

                    else
                        if (Program.bold1 == false && Program.italic1 == true && Program.under1 == true)
                        {

                            err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Underline);
                            Program.italic1 = false;
                        }
                        else
                            if (Program.bold1 == true && Program.italic1 == false && Program.under1 == false)
                            {

                                err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold | FontStyle.Italic);
                                Program.italic1 = true;
                            }
                            else
                                if (Program.bold1 == true && Program.italic1 == false && Program.under1 == true)
                                {

                                    err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
                                    Program.italic1 = true;

                                }
                                else
                                    if (Program.bold1 == true && Program.italic1 == true && Program.under1 == false)
                                    {

                                        err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold);
                                        Program.italic1 = false;

                                    }
                                    else if (Program.bold1 == true && Program.italic1 == true && Program.under1 == true)
                                    {

                                        err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold | FontStyle.Underline);
                                        Program.italic1 = false;

                                    }
        }

        private void numbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            try
            {
                if (this.bulletsToolStripMenuItem1.Checked)
                {
                    this.bulletsToolStripMenuItem1.Checked = false;
                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();
                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.None;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndParenthesis;
                    err.SelectionListType = pls;
                }
                else
                {
                    this.bulletsToolStripMenuItem1.Checked = true;
                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();
                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.Numbers;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndPeriod;
                    err.SelectionListType = pls;

                }
            }
            catch (Exception)
            {
            }
        }

        private void romanLettersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void capitalRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            try
            {
                if (this.bulletsToolStripMenuItem1.Checked)
                {
                    this.bulletsToolStripMenuItem1.Checked = false;
                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();
                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.None;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndParenthesis;
                    err.SelectionListType = pls;
                }
                else
                {
                    this.bulletsToolStripMenuItem1.Checked = true;
                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();
                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.CapitalRoman;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndPeriod;
                    err.SelectionListType = pls;

                }
            }
            catch (Exception)
            {
            }
        }

        private void smallRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            try
            {
                if (this.bulletsToolStripMenuItem1.Checked)
                {
                    this.bulletsToolStripMenuItem1.Checked = false;
                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();
                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.None;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndParenthesis;
                    err.SelectionListType = pls;
                }
                else
                {
                    this.bulletsToolStripMenuItem1.Checked = true;
                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();
                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.SmallRoman;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndPeriod;
                    err.SelectionListType = pls;

                }
            }
            catch (Exception)
            {
            }
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            if (Program.bold1 == false && Program.italic1 == false && Program.under1 == false)
            {


                err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Underline);
                Program.under1 = true;
            }

            else
                if (Program.bold1 == false && Program.italic1 == false && Program.under1 == true)
                {

                    err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Regular);
                    Program.under1 = false;
                }

                else
                    if (Program.bold1 == false && Program.italic1 == true && Program.under1 == false)
                    {

                        err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Underline | FontStyle.Italic);
                        Program.under1 = true;
                    }

                    else
                        if (Program.bold1 == false && Program.italic1 == true && Program.under1 == true)
                        {

                            err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Italic);
                            Program.under1 = false;
                        }
                        else
                            if (Program.bold1 == true && Program.italic1 == false && Program.under1 == false)
                            {

                                err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold | FontStyle.Underline);
                                Program.under1 = true;
                            }
                            else
                                if (Program.bold1 == true && Program.italic1 == false && Program.under1 == true)
                                {

                                    err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold);
                                    Program.under1 = false;

                                }
                                else
                                    if (Program.bold1 == true && Program.italic1 == true && Program.under1 == false)
                                    {

                                        err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                                        Program.under1 = true;

                                    }
                                    else if (Program.bold1 == true && Program.italic1 == true && Program.under1 == true)
                                    {

                                        err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Italic | FontStyle.Bold);
                                        Program.under1 = false;

                                    }
        }

        private void cmbfontstyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            if (flag == 1)
            {
                if (Program.bold1 == false && Program.italic1 == false && Program.under1 == false)
                {


                    err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Regular);
                }

                else
                    if (Program.bold1 == false && Program.italic1 == false && Program.under1 == true)
                    {

                        err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold | FontStyle.Underline);
                    }

                    else
                        if (Program.bold1 == false && Program.italic1 == true && Program.under1 == false)
                        {

                            err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold | FontStyle.Italic);
                        }

                        else
                            if (Program.bold1 == false && Program.italic1 == true && Program.under1 == true)
                            {

                                err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                            }
                            else
                                if (Program.bold1 == true && Program.italic1 == false && Program.under1 == false)
                                {

                                    err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Regular);
                                }
                                else
                                    if (Program.bold1 == true && Program.italic1 == false && Program.under1 == true)
                                    {

                                        err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Underline);

                                    }
                                    else
                                        if (Program.bold1 == true && Program.italic1 == true && Program.under1 == false)
                                        {

                                            err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Italic);

                                        }
                                        else if (Program.bold1 == true && Program.italic1 == true && Program.under1 == true)
                                        {

                                            err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Italic | FontStyle.Underline);

                                        }
            }
            flag = 1;
        }

        private void capitalLettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            try
            {
                if (this.bulletsToolStripMenuItem1.Checked)
                {
                    this.bulletsToolStripMenuItem1.Checked = false;
                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();
                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.None;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndParenthesis;
                    err.SelectionListType = pls;
                }
                else
                {
                    this.bulletsToolStripMenuItem1.Checked = true;
                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();
                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.CapitalLetters;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndPeriod;
                    err.SelectionListType = pls;

                }
            }
            catch (Exception)
            {
            }
        }

        private void smallLettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            try
            {
                if (this.bulletsToolStripMenuItem1.Checked)
                {
                    this.bulletsToolStripMenuItem1.Checked = false;
                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();
                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.None;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndParenthesis;
                    err.SelectionListType = pls;
                }
                else
                {
                    this.bulletsToolStripMenuItem1.Checked = true;
                    ExtendedRichTextBox.ParaListStyle pls = new ExtendedRichTextBox.ParaListStyle();
                    pls.Type = ExtendedRichTextBox.ParaListStyle.ListType.SmallLetters;
                    pls.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndPeriod;
                    err.SelectionListType = pls;

                }
            }
            catch (Exception)
            {
            }
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void speechToConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            if (err.SelectedText != "")
            {
                SpVoice voice = new SpVoice();
                voice.Volume = 100;
                voice.Speak(err.SelectedText, SpeechVoiceSpeakFlags.SVSFlagsAsync);
                voice.WaitUntilDone(Timeout.Infinite);
            }
            else
            {
                MessageBox.Show("no content");
            }
        }

        private void wordTOBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            Program.end = "R1";
            Program.text = err.Text;
            pascii f = new pascii();
            f.Show();
            this.Hide();

        }

        private void err_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //            err = getcurrentrichtextbox();
            webbrowser w1 = new webbrowser();
            w1.Show();
        }

        private void oCRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OCR ocr = new OCR();
            ocr.Show();
        }

        private void wordToHexaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox(); Program.end = "R2";
            Program.text = err.Text;
            pascii f = new pascii();
            f.Show();
            this.Hide();
        }

        private void binaryToWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            Program.end = "R3";
            Program.text = err.Text;
            pascii f = new pascii();
            f.Show();
            this.Hide();

        }

        private void hexaToWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            Program.end = "R4";
            Program.text = err.Text;
            pascii f = new pascii();
            f.Show();
            this.Hide();
        }

        private void cmbfontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            err = getcurrentrichtextbox();
            if (flag == 1)
            {
                if (Program.bold1 == false && Program.italic1 == false && Program.under1 == false)
                {


                    err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Regular);
                }

                else
                    if (Program.bold1 == false && Program.italic1 == false && Program.under1 == true)
                    {

                        err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold | FontStyle.Underline);
                    }

                    else
                        if (Program.bold1 == false && Program.italic1 == true && Program.under1 == false)
                        {

                            err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold | FontStyle.Italic);
                        }

                        else
                            if (Program.bold1 == false && Program.italic1 == true && Program.under1 == true)
                            {

                                err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                            }
                            else
                                if (Program.bold1 == true && Program.italic1 == false && Program.under1 == false)
                                {

                                    err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Regular);
                                }
                                else
                                    if (Program.bold1 == true && Program.italic1 == false && Program.under1 == true)
                                    {

                                        err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Underline);

                                    }
                                    else
                                        if (Program.bold1 == true && Program.italic1 == true && Program.under1 == false)
                                        {

                                            err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Italic);

                                        }
                                        else if (Program.bold1 == true && Program.italic1 == true && Program.under1 == true)
                                        {

                                            err.Font = new Font(cmbfontstyle.SelectedItem.ToString(), (float)Convert.ToDecimal(cmbfontsize.SelectedItem), FontStyle.Italic | FontStyle.Underline);

                                        }
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void unHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == tabControl1.TabPages.Count - 1)
                addnewtab();
            tabindex = tabControl1.SelectedIndex;

        }
        private ExtendedRichTextBox getcurrentrichtextbox()
        {
            return (ExtendedRichTextBox)tabControl1.SelectedTab.Controls[0];
        }

        private void extendedRichTextBox1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                Rectangle r = tabControl1.GetTabRect(i);
               // Rectangle r = tabControl1.GetTabRect(i);
                Rectangle closebutton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closebutton.Contains(e.Location))
                {
                    if (MessageBox.Show("Would you like to close this tab", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tabControl1.TabPages.RemoveAt(i);
                        tabpath[tabindex] = null;
                        break;
                    }
                }

            }

        }
    }
}
        
        
        
    

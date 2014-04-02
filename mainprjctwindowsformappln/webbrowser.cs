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
    public partial class webbrowser : Form
    {
        public webbrowser()
        {
            InitializeComponent();
        }

        private void webbrowser_Load(object sender, EventArgs e)
        {
            addnewtab();
            
        }
        private void addnewtab()
        {
            TabPage tpage = new TabPage();
            tpage.BorderStyle = BorderStyle.Fixed3D;
            tabControl1.TabPages.Insert(tabControl1.TabCount - 1, tpage);
            WebBrowser browser = new WebBrowser();

            textBox1.Text= "";
            browser.Navigate(textBox1.Text);
            tpage.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

            tabControl1.SelectTab(tpage);
            browser.Refresh();
            browser.ProgressChanged += new WebBrowserProgressChangedEventHandler(webBrowser1_ProgressChanged);

            }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == tabControl1.TabPages.Count - 1)
                addnewtab();
            else
            {
                if (getcurrentBrowser().Url != null)
                {
                    textBox1.Text = getcurrentBrowser().Url.ToString();
                }
                else
                {
                    textBox1.Text = "about:blank";
                }
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab.Dispose();

        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress < toolStripProgressBar1.Maximum)
            {
                if (e.CurrentProgress < 0)
                {
                    toolStripProgressBar1.Value = 0;
                }
                else
                {
                    toolStripProgressBar1.Value = (int)e.CurrentProgress;
                }
            }
            else
                toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            getcurrentBrowser().GoBack();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            getcurrentBrowser().GoForward();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            getcurrentBrowser().Stop();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            getcurrentBrowser().GoHome();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            getcurrentBrowser().Refresh();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (searchbuttn.Checked == true)
            {
                getcurrentBrowser().Navigate("http://www.google.co.in/#sclient=psy&hl=en&source=hp&q=" + searchtext.Text);
            }
            else
            {
                getcurrentBrowser().Navigate("http://www.bing.com/search?q=" + searchtext.Text);
            }
        }

        private void go_Click(object sender, EventArgs e)
        {
            getcurrentBrowser().Navigate(textBox1.Text);
            tabControl1.SelectedTab.Text=textBox1.Text;

        }
        private WebBrowser getcurrentBrowser()
        {
            return (WebBrowser)tabControl1.SelectedTab.Controls[0];
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
      
                
        }

        

      
        

        

       

        
       

        

      

      
    }


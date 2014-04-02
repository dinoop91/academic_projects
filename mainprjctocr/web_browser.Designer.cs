namespace OCR
{
    partial class web_browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(web_browser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.back = new System.Windows.Forms.ToolStripButton();
            this.forword = new System.Windows.Forms.ToolStripButton();
            this.stop = new System.Windows.Forms.ToolStripButton();
            this.refresh = new System.Windows.Forms.ToolStripButton();
            this.home = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchtext = new System.Windows.Forms.ToolStripTextBox();
            this.searchbuttn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.back,
            this.forword,
            this.stop,
            this.refresh,
            this.home,
            this.toolStripLabel1,
            this.searchtext,
            this.searchbuttn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1064, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // back
            // 
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(49, 22);
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forword
            // 
            this.forword.Image = ((System.Drawing.Image)(resources.GetObject("forword.Image")));
            this.forword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forword.Name = "forword";
            this.forword.Size = new System.Drawing.Size(67, 22);
            this.forword.Text = "Forward";
            this.forword.Click += new System.EventHandler(this.forword_Click);
            // 
            // stop
            // 
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(49, 22);
            this.stop.Text = "Stop";
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // refresh
            // 
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(65, 22);
            this.refresh.Text = "Refresh";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // home
            // 
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(54, 22);
            this.home.Text = "Home";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel1.Text = "Search";
            // 
            // searchtext
            // 
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(150, 25);
            // 
            // searchbuttn
            // 
            this.searchbuttn.Checked = true;
            this.searchbuttn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchbuttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchbuttn.Image = ((System.Drawing.Image)(resources.GetObject("searchbuttn.Image")));
            this.searchbuttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchbuttn.Name = "searchbuttn";
            this.searchbuttn.Size = new System.Drawing.Size(23, 22);
            this.searchbuttn.Text = "search";
            this.searchbuttn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1064, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.textBox1.Location = new System.Drawing.Point(88, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 20);
            this.textBox1.TabIndex = 3;
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.ForestGreen;
            this.go.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.ForeColor = System.Drawing.SystemColors.WindowText;
            this.go.Location = new System.Drawing.Point(454, 25);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(38, 23);
            this.go.TabIndex = 4;
            this.go.Text = "GO";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.toolStrip3.Location = new System.Drawing.Point(0, 552);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1064, 25);
            this.toolStrip3.TabIndex = 8;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 25);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 527);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1056, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1050, 495);
            this.webBrowser1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(901, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "CLOSE TAB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // web_browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.go);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(20, 34);
            this.Name = "web_browser";
            this.Text = "web_browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.web_browser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton back;
        private System.Windows.Forms.ToolStripButton forword;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.ToolStripButton stop;
        private System.Windows.Forms.ToolStripButton refresh;
        private System.Windows.Forms.ToolStripButton home;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchtext;
        private System.Windows.Forms.ToolStripButton searchbuttn;
    }
}
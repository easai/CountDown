namespace CountDown
{
    partial class CountDown
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountDown));
            this.TimeText = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.messageText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pREFERENCEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCountDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideShow = new SlideShow.SlideShow();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeText
            // 
            this.TimeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeText.Enabled = false;
            this.TimeText.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeText.Location = new System.Drawing.Point(73, 31);
            this.TimeText.Multiline = false;
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(387, 66);
            this.TimeText.TabIndex = 0;
            this.TimeText.Text = "";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // messageText
            // 
            this.messageText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.messageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageText.Enabled = false;
            this.messageText.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageText.Location = new System.Drawing.Point(12, 685);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(578, 102);
            this.messageText.TabIndex = 2;
            this.messageText.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pREFERENCEToolStripMenuItem,
            this.hELPToolStripMenuItem,
            this.tEXTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pREFERENCEToolStripMenuItem
            // 
            this.pREFERENCEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.pREFERENCEToolStripMenuItem.Name = "pREFERENCEToolStripMenuItem";
            this.pREFERENCEToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.pREFERENCEToolStripMenuItem.Text = "&FILE";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutCountDownToolStripMenuItem});
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.hELPToolStripMenuItem.Text = "&HELP";
            // 
            // aboutCountDownToolStripMenuItem
            // 
            this.aboutCountDownToolStripMenuItem.Name = "aboutCountDownToolStripMenuItem";
            this.aboutCountDownToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.aboutCountDownToolStripMenuItem.Text = "&About CountDown";
            this.aboutCountDownToolStripMenuItem.Click += new System.EventHandler(this.aboutCountDownToolStripMenuItem_Click);
            // 
            // tEXTToolStripMenuItem
            // 
            this.tEXTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomToolStripMenuItem,
            this.openFileToolStripMenuItem});
            this.tEXTToolStripMenuItem.Name = "tEXTToolStripMenuItem";
            this.tEXTToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.tEXTToolStripMenuItem.Text = "&TEXT";
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.randomToolStripMenuItem.Text = "&Random";
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.randomToolStripMenuItem_Click);
            // 
            // slideShow
            // 
            this.slideShow.Location = new System.Drawing.Point(0, 109);
            this.slideShow.Name = "slideShow";
            this.slideShow.Size = new System.Drawing.Size(600, 570);
            this.slideShow.TabIndex = 4;
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.openFileToolStripMenuItem.Text = "&Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // CountDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 824);
            this.Controls.Add(this.slideShow);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(620, 869);
            this.MinimumSize = new System.Drawing.Size(620, 869);
            this.Name = "CountDown";
            this.Text = "CountDown";
            this.Load += new System.EventHandler(this.CountDown_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TimeText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RichTextBox messageText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pREFERENCEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCountDownToolStripMenuItem;
        private SlideShow.SlideShow slideShow;
        private System.Windows.Forms.ToolStripMenuItem tEXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
    }
}


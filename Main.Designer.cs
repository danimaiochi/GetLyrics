namespace GetLyrics
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.optionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.getItunesSong = new System.Windows.Forms.ToolStripMenuItem();
            this.stayOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.lyricsForm = new GetLyrics.LyricsForm();
            this.panel1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtSong);
            this.panel1.Controls.Add(this.txtArtist);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 41);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "R";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSong
            // 
            this.txtSong.Location = new System.Drawing.Point(206, 7);
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(100, 20);
            this.txtSong.TabIndex = 9;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(60, 7);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(100, 20);
            this.txtArtist.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Song";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Artist";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(356, 24);
            this.mainMenu.TabIndex = 9;
            this.mainMenu.Text = "menuStrip1";
            // 
            // optionMenu
            // 
            this.optionMenu.Checked = true;
            this.optionMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getItunesSong,
            this.stayOnTop});
            this.optionMenu.Name = "optionMenu";
            this.optionMenu.Size = new System.Drawing.Size(61, 20);
            this.optionMenu.Text = "Options";
            // 
            // getItunesSong
            // 
            this.getItunesSong.Checked = true;
            this.getItunesSong.CheckOnClick = true;
            this.getItunesSong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.getItunesSong.Name = "getItunesSong";
            this.getItunesSong.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.getItunesSong.Size = new System.Drawing.Size(179, 22);
            this.getItunesSong.Text = "Get iTunes Song";
            this.getItunesSong.Click += new System.EventHandler(this.getItunesSong_Click);
            // 
            // stayOnTop
            // 
            this.stayOnTop.CheckOnClick = true;
            this.stayOnTop.Name = "stayOnTop";
            this.stayOnTop.Size = new System.Drawing.Size(179, 22);
            this.stayOnTop.Text = "Stay on top";
            this.stayOnTop.Click += new System.EventHandler(this.stayOnTopToolStripMenuItem_Click);
            // 
            // lyricsForm
            // 
            this.lyricsForm.AutoSize = true;
            this.lyricsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lyricsForm.Location = new System.Drawing.Point(0, 65);
            this.lyricsForm.Name = "lyricsForm";
            this.lyricsForm.Size = new System.Drawing.Size(356, 341);
            this.lyricsForm.song = null;
            this.lyricsForm.source = null;
            this.lyricsForm.Source = null;
            this.lyricsForm.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 406);
            this.Controls.Add(this.lyricsForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Main";
            this.Text = "GimmeLyrics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private LyricsForm lyricsForm;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem optionMenu;
        private System.Windows.Forms.ToolStripMenuItem getItunesSong;
        private System.Windows.Forms.ToolStripMenuItem stayOnTop;

    }
}


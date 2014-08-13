namespace GetLyrics
{
    partial class LyricsForm
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
            this.wbLyrics = new System.Windows.Forms.WebBrowser();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbLyrics
            // 
            this.wbLyrics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbLyrics.Location = new System.Drawing.Point(0, 24);
            this.wbLyrics.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbLyrics.Name = "wbLyrics";
            this.wbLyrics.Size = new System.Drawing.Size(537, 453);
            this.wbLyrics.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(537, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "MainMenu";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // saveFile
            // 
            this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // LyricsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 477);
            this.Controls.Add(this.wbLyrics);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "LyricsForm";
            this.Text = "LyricsForm";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbLyrics;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}
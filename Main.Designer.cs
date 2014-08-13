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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Song";
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(49, 10);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(100, 20);
            this.txtArtist.TabIndex = 2;
            // 
            // txtSong
            // 
            this.txtSong.Location = new System.Drawing.Point(49, 37);
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(100, 20);
            this.txtSong.TabIndex = 3;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(49, 63);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 4;
            this.btnGet.Text = "GIMME!";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "R";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 89);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtSong);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "GimmeLyrics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button button1;
    }
}


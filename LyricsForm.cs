﻿using System;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GetLyrics
{
    public partial class LyricsForm : UserControl
    {
        public LyricsForm()
        {
            InitializeComponent();
        }

        public void init()
        {
            wbLyrics.DocumentText = source.Lyrics;

            //TODO: arrumar essa feiura
            try
            {
                mainMenu.Items.RemoveAt(1);
            }
            catch { }
            if (source.Name != string.Empty && source.URL != string.Empty)
            {
                mainMenu.Items.Add(source.Name).Click += LyricsForm_Click;
            }
        }
        
        public Song song { get; set; }
        public Source source { get; set; }

        void LyricsForm_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.source.URL);
        }
        public string Source { get; set; }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile.FileName = string.Format("{0} - {1}", song.Artist, song.Name) ;
            saveFile.Filter = "Text (*.txt)|*.txt";
            saveFile.ShowDialog();
            
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFile.FileName, 
                Regex.Replace(
                    wbLyrics.DocumentText
                    .Replace("<br>",Environment.NewLine)
                    .Replace("<br/>", Environment.NewLine)
                    .Replace("<br />", Environment.NewLine), 
                    "<.*?>", string.Empty));
        }


    }
}

using System;
using System.ComponentModel;
using System.IO;
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
            mainMenu.Items[1].Text = source.Name;
            mainMenu.Items[1].Click += LyricsForm_Click;
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
            File.WriteAllText(saveFile.FileName, wbLyrics.DocumentText);
        }


    }
}

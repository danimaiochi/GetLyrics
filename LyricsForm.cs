using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace GetLyrics
{
    public partial class LyricsForm : Form
    {
        public LyricsForm()
        {
            InitializeComponent();
        }

        public void init()
        {
            wbLyrics.DocumentText = source.Lyrics;
            this.Text = string.Format("{0} - {1}", song.Artist, song.Name);
            this.mainMenu.Items.Add(source.Name).Click += LyricsForm_Click;
            this.Show();
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
            saveFile.FileName = LyricsForm.ActiveForm.Text;
            saveFile.Filter = "Texto (*.txt)|*.txt";
            saveFile.ShowDialog();
            
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFile.FileName, wbLyrics.DocumentText);
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetLyrics
{
    public partial class LyricsForm : Form
    {
        public LyricsForm(Song song)
        {
            InitializeComponent();
            wbLyrics.DocumentText = song.Lyrics;
            this.Text = string.Format("{0} - {1}", song.Artist, song.Name);
            this.mainMenu.Items.Add(song.Source).Enabled = false;
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

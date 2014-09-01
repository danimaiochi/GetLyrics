using iTunesLib;
using System;
using WMPLib;

namespace GetLyrics
{
    class Functions
    {
        internal static string Clean(string texto)
        {
            return RemoverAcentos(texto.ToLower().Replace(@"\", "").Replace(".", "").Replace("'", "").Replace("!","").Replace("#",""));
        }
        internal static string RemoverAcentos(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return String.Empty;
            else
            {
                byte[] bytes = System.Text.Encoding.GetEncoding("iso-8859-8").GetBytes(texto);
                return System.Text.Encoding.UTF8.GetString(bytes);
            }
        }
        internal static Song getCurrentSong()
        {
            Song song = new Song();
            
            iTunesApp itunes = new iTunesApp();
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();

            if (itunes.CurrentTrack != null)
            {
                song.Name = itunes.CurrentTrack.Name;
                song.Artist = itunes.CurrentTrack.Artist;
            }

            if (wmp.currentMedia != null)
            {
                song.Name = wmp.currentMedia.name;
            }
            return song;
        }
    }
}

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
            
            if (Main.itunes.CurrentTrack != null)
            {
                song.Name = Main.itunes.CurrentTrack.Name;
                song.Artist = Main.itunes.CurrentTrack.Artist;
            }
            
            return song;
        }
        
    }
}

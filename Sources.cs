using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetLyrics
{
    class Sources
    {
        internal enum Sites
        {
            AZLyrics,
            Vagalume
        }
        internal static string GetFrom(Sites src, Song song)
        {
            if (src == Sites.AZLyrics)
                return AZLyrics(song);

            if (src == Sites.Vagalume)
                return Vagalume(song);

            return "";
        }
        internal static string AZLyrics(Song song)
        {
            string url = string.Format("http://www.azlyrics.com/lyrics/{0}/{1}.html", Functions.Clean(song.Artist).Replace(" ", ""), Functions.Clean(song.Name).Replace(" ", ""));
            string lyrics = null;
            WebClient site = new WebClient();
            try
            {
                lyrics = site.DownloadString(url);
                lyrics = Regex.Match(lyrics, @"<!-- start of lyrics -->(.*\n)*<!-- end of lyrics -->").Value;
            }
            catch { }

            return lyrics;
        }
        internal static string Vagalume(Song song)
        {

            string url = string.Format("http://www.vagalume.com.br/{0}/{1}.html", Functions.Clean(song.Artist).Replace(" ", "-"), Functions.Clean(song.Name).Replace(" ", "-"));
            string lyrics = null;
            WebClient site = new WebClient();
            try
            {
                lyrics = site.DownloadString(url);
                lyrics.Replace("\"", "");
                lyrics = Regex.Match(lyrics, @"<div itemprop=description>(.*\n)*?</div>").Value;
            }
            catch { }

            return lyrics;
        }
    }
}

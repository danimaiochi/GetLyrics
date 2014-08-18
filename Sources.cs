using System.Net;
using System.Text.RegularExpressions;

namespace GetLyrics
{
    class Sources
    {
        internal enum Sites
        {
            AZLyrics,
            Vagalume
        }
        internal static Source GetFrom(Sites src, Song song)
        {
            if (src == Sites.AZLyrics)
                return AZLyrics(song);

            if (src == Sites.Vagalume)
                return Vagalume(song);

            return new Source();
        }
        internal static Source AZLyrics(Song song)
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

            return new Source() { Name = "AZLyrics", Lyrics = lyrics, URL = url };
        }
        internal static Source Vagalume(Song song)
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

            return new Source() { Name = "Vagalume", Lyrics = lyrics, URL = url };
        }
    }
    public class Source
    {
        public string Name;
        public string Lyrics;
        public string URL;
    }
}

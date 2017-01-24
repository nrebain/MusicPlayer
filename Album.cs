using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Album
    {
        private string title;
        private string artist;
        private string year;
        private string artFilePath;

        List<Song> songs = new List<Song>();

        public Album(string title, string artist, string year, string artFilePath)
        {
            this.title = title;
            this.artist = artist;
            this.year = year;
            this.artFilePath = artFilePath;
        }
        public string getTitle()
        {
            return this.title;
        }
        public string getArtist()
        {
            return this.artist;
        }
        public string getYear()
        {
            return this.year;
        }
    }
}

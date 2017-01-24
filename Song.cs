using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
   public class Song
    {
        private string title;
        private string artist;
        private string album;
        private string fileLoc;
        private double duration;

        public Song(string title, string artist, string album, string fileLoc, double duration)
        {
            this.title = title;
            this.artist = artist;
            this.album = album;
            this.fileLoc = fileLoc;
            this.duration = duration;
        }

        public string getTitle()
        {
            return this.title;
        }
        public string getArtist()
        {
            return this.artist;
        }
        public string getAlbum()
        {
            return this.album;
        }
        public string getFileLoc()
        {
            return this.fileLoc;
        }
        public double getDuration()
        {
            return this.duration;
        }
    }
}

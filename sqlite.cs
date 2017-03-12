using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class sqlite
    {
        private SQLiteConnection connection;

        public sqlite()
        {
            if (!File.Exists("library.sqlite"))
            {
                Console.Out.WriteLine("DB doesnt exist!!!");
                Console.Out.WriteLine("DB doesnt exist!!!");
                Console.Out.WriteLine("DB doesnt exist!!!");
                Console.Out.WriteLine("DB doesnt exist!!!");
                Console.Out.WriteLine("DB doesnt exist!!!");
                Console.Out.WriteLine("DB doesnt exist!!!");
                createDB();  
                fillDB();
            }
        }
        // Gets all the songs from the database and puts them into a list
        public List<Song> getSongs()
        {
            List<Song> songsToReturn = new List<Song>();
            connection = new SQLiteConnection("Data Source=library.sqlite;Version=3;");
            connection.Open();
            string sql = "select * from songs";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            string title = null;
            string artist = null;
            string album = null;
            string filePath = null;
            double duration = 0;
            while (reader.Read())
            {
                    Console.Out.WriteLine("Title is: " + (string)reader["title"]);
                if (reader["title"] != DBNull.Value)
                {
                    title = (string)reader["title"];
                }
                else title = "unknown";

                if (reader["artist"] != DBNull.Value)
                {
                    artist = (string)reader["artist"];
                }
                else artist = "unknown";

                if (reader["album"] != DBNull.Value)
                {
                    album = (string)reader["album"];
                }
                else album = "unknown";

                if (reader["filePath"] != DBNull.Value)
                {
                   filePath = (string)reader["filePath"];
                }
                else filePath = "unknown";

                if (reader["duration"] != DBNull.Value)
                {
                   duration = (double)reader["duration"];
                }
                else duration = 0;
                Song newSong = new Song(title, artist, album, filePath, duration);
                songsToReturn.Add(newSong);
            }
            return songsToReturn;
        }
        // Gets all music files from the given directory 
        public void fillDB()
        {
            List<string> files = Directory.GetFiles(@"D:\TestMusic", "*.*", SearchOption.AllDirectories).ToList();
            TagLib.File tagFile;
            foreach (string musicFile in files)
            {
                if (!musicFile.Substring(musicFile.Length - 4).Equals(".jpg") && !musicFile.Substring(musicFile.Length - 4).Equals(".ini") && !musicFile.Substring(musicFile.Length - 4).Equals(".pdf"))
                {
                    try
                    {
                        tagFile = TagLib.File.Create(musicFile);
                    }
                    catch (Exception e)
                    {
                        continue;
                    }
                    double duration = MusicPlayer.Instance.GetMediaDuration(musicFile);

                    string sql = "INSERT INTO songs (title, artist, album, filePath, duration) VALUES(@param1, @param2, @param3, @param4, @param5)";
                    SQLiteCommand command = new SQLiteCommand(sql, connection);
                    command.Parameters.Add(new SQLiteParameter("@param1", tagFile.Tag.Title));
                    command.Parameters.Add(new SQLiteParameter("@param2", tagFile.Tag.FirstAlbumArtist));
                    command.Parameters.Add(new SQLiteParameter("@param3", tagFile.Tag.Album));
                    command.Parameters.Add(new SQLiteParameter("@param4", musicFile));
                    command.Parameters.Add(new SQLiteParameter("@param5", duration));
                    command.ExecuteNonQuery();
                }
            }
        }

        // If the sqlite db doesnt exist, create it
        public void createDB()
        {
            Console.Out.WriteLine("Creating DB!");
            SQLiteConnection.CreateFile("library.sqlite");
            connection = new SQLiteConnection("Data Source=library.sqlite;Version=3;");
            connection.Open();
            string sql = "create table songs (title varchar(255), artist varchar(255), album varchar(255), filePath varchar(255), duration double)";

            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
        }

        
    }
}

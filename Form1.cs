using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public List<Song> songs = new List<Song>();
        public List<Song> currentList = new List<Song>();
        public List<Album> albums = new List<Album>();
        int mouseStartX;
        int mouseStartY;
        public Form1()
        {
            //Creat the music player instance, set some styles and query the DB to get the songs
            InitializeComponent();
            MusicPlayer.Init();
            sqlite sql = new sqlite();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            songs = sql.getSongs();
            currentList = songs;
            populateSongsList();
            // fillList();
            //timer1.Enabled = true;
            timer1.Interval = 1000;
            volumeTrackBar.Value = 50;
            // Use songs list to populate an album list
            populateAlbumList();
        }


        // This makes borderless window resizeable

        //records old position of mouse
        private void resize_MouseDown(object sender, MouseEventArgs e)
        {
            mouseStartX = Cursor.Position.X;
            mouseStartY = Cursor.Position.Y;
        }
        //Gets new position of mouse and resizes form accordingly
        private void resize_MouseUp(object sender, MouseEventArgs e)
        {

            int mouseFinalX = Cursor.Position.X;
            int mouseFinalY = Cursor.Position.Y;
            ChangeSize((this.Width + (mouseFinalX - mouseStartX)),(this.Height + (mouseFinalY - mouseStartY)));

        }
        public void ChangeSize(int width, int height)
        {
            this.Size = new Size(width, height);
        }
        // These are the button listeners

        
        private void button1_Click(object sender, EventArgs e)
        {
            MusicPlayer.Instance.Stop();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Mp3(*.mp3|*.mp3;";
            if (open.ShowDialog() != DialogResult.OK) return;
            MusicPlayer.Instance.Play(open.FileName);
        }

        // Calls function to pause the song
        private void pauseButton_Click(object sender, EventArgs e)
        {
            MusicPlayer.Instance.Pause();
        }

        //Close form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MusicPlayer.Instance.Stop();
        }


        public void addItem(ListViewItem item)
        {
            this.listView1.Items.Add(item);
        }

        //Initialise the songs list
        public void populateSongsList()
        {
            int counter = 0;
            foreach (Song song in currentList)
            {                   
                   ListViewItem newItem = new ListViewItem(counter.ToString());
                   newItem.SubItems.Add(song.getTitle());
                   newItem.SubItems.Add(song.getArtist());
                   newItem.SubItems.Add(song.getAlbum());
                   this.listView1.Items.Add(newItem);
                   counter++;
            }
         }
         
        //gets the duration of a song to display to the user       
         double GetMediaDuration(string MediaFilename)
         {
            double duration = 0.0;
            using (FileStream fs = File.OpenRead(MediaFilename))
            {
                Mp3Frame frame = Mp3Frame.LoadFromStream(fs);
                if (frame != null)
                {
                    //_sampleFrequency = (uint)frame.SampleRate;
                }
                while (frame != null)
                {
                    if (frame.ChannelMode == ChannelMode.Mono)
                    {
                        duration += (double)frame.SampleCount * 2.0 / (double)frame.SampleRate;
                    }
                    else
                    {
                        duration += (double)frame.SampleCount / (double)frame.SampleRate;
                    }
                    try
                    {
                        frame = Mp3Frame.LoadFromStream(fs);
                    }
                    catch (Exception e)
                    {
                        Console.Out.WriteLine("caught exception on " + MediaFilename + " skipping");
                        return 0;
                    }
                }
            }
            Console.Out.WriteLine("Duration completed for " + MediaFilename);
            return duration;
        }

        // Called upon clicking on a new song in the song list
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                MusicPlayer player = MusicPlayer.Instance;
                player.Stop();
                timer1.Stop();
                seekBar.Value = 0;
                currTimeLbl.Text = "00:00";
                ListViewItem item = listView1.SelectedItems[0];
                //Console.Out.WriteLine("The two strings are: " + item.SubItems[1].Text+ " " + item.SubItems[2].Text);
                Song selectedSong = getSong(item.SubItems[1].Text, item.SubItems[2].Text);
                //Console.Out.WriteLine("Returned song is " + selectedSong.getTitle());
                
                //Set the now playing labels to the selected song
                this.titleLbl.Text = item.SubItems[1].Text;
                this.artistLbl.Text = item.SubItems[2].Text;
                int sizeOfBar = Convert.ToInt32(selectedSong.getDuration());
                this.seekBar.Maximum = sizeOfBar;    
                this.seekBar.Show();
                endTimeLbl.Text = (Math.Floor((selectedSong.getDuration() / 60)).ToString("00") + ":" + (Math.Floor(selectedSong.getDuration() % 60)).ToString("00"));
                MusicPlayer.Instance.Play(selectedSong.getFileLoc());
            }
        }

        //Sets the max size for the track bar
        public void setTrackMax(int size)
        {
            this.seekBar.Maximum = size;
        }

        //Closes the application
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Goes to next song
        private void nextBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = listView1.SelectedIndices[0];
            selectedIndex++;
            listView1.Items[selectedIndex].Selected = true;
        }

        //Goes to previous song
        private void prevBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = listView1.SelectedIndices[0];
            selectedIndex--;
            listView1.Items[selectedIndex].Selected = true;
        }

        // Displays entire list of songs
        private void SongsBtn_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            albumLayout.Visible = false;
        }

        //Displays list of artists
        private void ArtistsBtn_Click(object sender, EventArgs e)
        {

        }

        //Displays list of albums
        private void AlbumsBtn_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            albumLayout.Visible = true;

        }
        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Following code makes window movable
        private bool mouseDown;
        private Point lastLocation;
        private void panel2_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }


        private void seekBar_CursorChanged(object sender, EventArgs e)
        {
           // Console.Out.WriteLine("Time passed into change" + seekBar.Value);
          //  MusicPlayer.Instance.setPosition(seekBar.Value);
        }
        //following 2 functions allow for the user to skip to a time int he song with the trackbar
        private int PreviousValue;

        private void seekBar_MouseUp(object sender, MouseEventArgs e)
        {                     
                MusicPlayer.Instance.setPosition(seekBar.Value);
                Console.Out.WriteLine("Time passed into change" + (seekBar.Value - PreviousValue));
        }

        private void seekBar_MouseDown(object sender, MouseEventArgs e)
        {
            PreviousValue = seekBar.Value;
        }

        //Timer for the song time starts
        public void startTimer()
        {
            timer1.Start();
        }
        //Timer for the song time stops
        public void stopTimer()
        {
            timer1.Stop();
        }
        //Sets the value of the seekbar and the lable that displays the current time in the song
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seekBar.Value != seekBar.Maximum)
            {
                seekBar.Value++;
                currTimeLbl.Text = (seekBar.Value / 60).ToString("00") + ":" + (seekBar.Value % 60).ToString("00");
                Console.Out.WriteLine("seekbar is at" + (seekBar.Value));
            }
        }
        
        private void titleLbl_Click(object sender, EventArgs e)
        {

        }

        // Calls function to change volume
        private void volumeTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            float divisor = 100;
            float volume = volumeTrackBar.Value/divisor;
            Console.Out.WriteLine("volumebar is at" + volumeTrackBar.Value);
            Console.Out.WriteLine("After math it is at" + volume);
            MusicPlayer.Instance.setVolume(volume);

        }
        //Gets the Song object of a particular song given the title and artist
        public Song getSong(string title, string artist)
        {
            for (int i = 0; i < currentList.Count; i++)
            {
                //Console.Out.WriteLine("Comparisons are: "+title + " and " + currentList[i].getTitle())+ " " + artist + " and " + currentList[i].getArtist());
                if (currentList[i].getTitle().Equals(title) && currentList[i].getArtist().Equals(artist))
                {
                    return currentList[i];
                }
            }
            return null;
        }

        //Populates the albums List and displays them on the albumLayout in the form
        public void populateAlbumList()
        {
            String lastAlbumName = "empty";
            string albumArt = "empty";
            foreach (Song song in songs)
            {
                if(!song.getAlbum().Equals(lastAlbumName))
                {
                    
                    var ext = new List<string> { "jpg", "gif", "png" };
                    DirectoryInfo albumFolder = Directory.GetParent(song.getFileLoc());
                    Console.Out.WriteLine(albumFolder.ToString());
                    string[] exts = { ".jpg", ".png", ".gif" };
                    IEnumerable<FileInfo> files = GetFilesByExtensions(albumFolder,exts);
                    List<FileInfo> files1 = files.ToList();
                   // Console.Out.WriteLine(files1.Count);

                    if (files1.Count >= 1)
                    {
                        //Console.Out.WriteLine("Art to be added: " + files1.ElementAt(0).FullName.ToString());
                        albumArt = files1.ElementAt(0).FullName.ToString();
                    }
                    Console.Out.WriteLine("Album is: " + song.getAlbum());
                    Album newAlbum = new Album(song.getAlbum(), song.getArtist(), albumArt);
                    albums.Add(newAlbum);
                    albumArt = "empty";
                    lastAlbumName = song.getAlbum();
               
                }             
            }       
                    
            int counter = 0;
            foreach (Album album in albums)
            {
                //Create new panel to go on the albumLayout
                Panel newPanel = new Panel();
                newPanel.Height = 125;
                newPanel.Width = 100;
                newPanel.Click += panelClick;
                //Create new buttont o go ont he new panel
                Button newAlbum = new Button();
                newAlbum.Anchor = AnchorStyles.Top;
                newAlbum.Dock = DockStyle.Top;
                newAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", .1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //newAlbum.Click += panelClick;
                //create new label to go under new button
                Label albumName = new Label();
                albumName.Text = album.getTitle();
                
                albumName.Anchor = AnchorStyles.Bottom;
                albumName.Dock = DockStyle.Fill;
                albumName.Text = album.getTitle();
                albumName.MaximumSize = new Size(110, 0);
                albumName.AutoSize = true;
                albumName.TextAlign = ContentAlignment.MiddleCenter;

                Console.Out.WriteLine("It is on: " + album.getTitle());
                Console.Out.WriteLine("art location is: " + album.getAlbumArt());
                if (!album.getAlbumArt().Equals("empty"))
                {
                   newAlbum.BackgroundImage = Image.FromFile(album.getAlbumArt());                   
                   newAlbum.BackgroundImageLayout = ImageLayout.Stretch;
                }
                newAlbum.TextImageRelation = TextImageRelation.ImageAboveText;
                newAlbum.FlatStyle = FlatStyle.Flat;
                newAlbum.Height = 100;
                newAlbum.Width = 100;
                newPanel.Controls.Add(albumName);
                newPanel.Controls.Add(newAlbum);

                this.albumLayout.Controls.Add(newPanel);
                counter++;
            }
        }
        public static IEnumerable<FileInfo> GetFilesByExtensions(DirectoryInfo dir, string[] extensions)
        {
            if (extensions == null)
                throw new ArgumentNullException("extensions");
            IEnumerable<FileInfo> files = dir.EnumerateFiles();
            return files.Where(f => extensions.Contains(f.Extension));
        }
        void panelClick(object sender, EventArgs e)
        {
            Console.Out.WriteLine("Clicked on a panel");
            
        }
    }
}

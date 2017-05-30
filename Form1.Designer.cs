namespace MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pauseButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NumberCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TitleCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArtistCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AlbumCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SongsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resize = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.endTimeLbl = new System.Windows.Forms.Label();
            this.currTimeLbl = new System.Windows.Forms.Label();
            this.seekBar = new System.Windows.Forms.TrackBar();
            this.artistLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AlbumsBtn = new System.Windows.Forms.Button();
            this.ArtistsBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.albumLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.Black;
            this.pauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.BackgroundImage")));
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseButton.CausesValidation = false;
            this.pauseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pauseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.pauseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.ForeColor = System.Drawing.Color.White;
            this.pauseButton.Location = new System.Drawing.Point(386, 33);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(46, 47);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumberCol,
            this.TitleCol,
            this.ArtistCol,
            this.AlbumCol});
            this.listView1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(154, 43);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(628, 442);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // NumberCol
            // 
            this.NumberCol.Text = "#";
            this.NumberCol.Width = 32;
            // 
            // TitleCol
            // 
            this.TitleCol.Text = "Title";
            this.TitleCol.Width = 242;
            // 
            // ArtistCol
            // 
            this.ArtistCol.Text = "Artist";
            this.ArtistCol.Width = 172;
            // 
            // AlbumCol
            // 
            this.AlbumCol.Text = "Album";
            this.AlbumCol.Width = 184;
            // 
            // SongsBtn
            // 
            this.SongsBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SongsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SongsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SongsBtn.FlatAppearance.BorderSize = 0;
            this.SongsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.SongsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.SongsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SongsBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongsBtn.ForeColor = System.Drawing.Color.White;
            this.SongsBtn.Image = ((System.Drawing.Image)(resources.GetObject("SongsBtn.Image")));
            this.SongsBtn.Location = new System.Drawing.Point(19, 32);
            this.SongsBtn.Name = "SongsBtn";
            this.SongsBtn.Size = new System.Drawing.Size(129, 59);
            this.SongsBtn.TabIndex = 5;
            this.SongsBtn.Text = "Songs";
            this.SongsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SongsBtn.UseVisualStyleBackColor = false;
            this.SongsBtn.Click += new System.EventHandler(this.SongsBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.resize);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.volumeTrackBar);
            this.panel1.Controls.Add(this.endTimeLbl);
            this.panel1.Controls.Add(this.currTimeLbl);
            this.panel1.Controls.Add(this.seekBar);
            this.panel1.Controls.Add(this.artistLbl);
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Controls.Add(this.prevBtn);
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Controls.Add(this.pauseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 83);
            this.panel1.TabIndex = 6;
            // 
            // resize
            // 
            this.resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resize.Location = new System.Drawing.Point(762, 60);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(21, 20);
            this.resize.TabIndex = 10;
            this.resize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
            this.resize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resize_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(645, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Location = new System.Drawing.Point(675, 25);
            this.volumeTrackBar.Maximum = 100;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.volumeTrackBar.TabIndex = 0;
            this.volumeTrackBar.TickFrequency = 0;
            this.volumeTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.volumeTrackBar_MouseUp);
            // 
            // endTimeLbl
            // 
            this.endTimeLbl.AutoSize = true;
            this.endTimeLbl.ForeColor = System.Drawing.Color.White;
            this.endTimeLbl.Location = new System.Drawing.Point(652, 4);
            this.endTimeLbl.Name = "endTimeLbl";
            this.endTimeLbl.Size = new System.Drawing.Size(34, 13);
            this.endTimeLbl.TabIndex = 8;
            this.endTimeLbl.Text = "00:00";
            // 
            // currTimeLbl
            // 
            this.currTimeLbl.AutoSize = true;
            this.currTimeLbl.ForeColor = System.Drawing.Color.White;
            this.currTimeLbl.Location = new System.Drawing.Point(194, 3);
            this.currTimeLbl.Name = "currTimeLbl";
            this.currTimeLbl.Size = new System.Drawing.Size(34, 13);
            this.currTimeLbl.TabIndex = 7;
            this.currTimeLbl.Text = "00:00";
            // 
            // seekBar
            // 
            this.seekBar.BackColor = System.Drawing.Color.Black;
            this.seekBar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.seekBar.Location = new System.Drawing.Point(224, -4);
            this.seekBar.Maximum = 1020;
            this.seekBar.Name = "seekBar";
            this.seekBar.Size = new System.Drawing.Size(432, 45);
            this.seekBar.TabIndex = 6;
            this.seekBar.TickFrequency = 0;
            this.seekBar.CursorChanged += new System.EventHandler(this.seekBar_CursorChanged);
            this.seekBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.seekBar_MouseDown);
            this.seekBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.seekBar_MouseUp);
            // 
            // artistLbl
            // 
            this.artistLbl.BackColor = System.Drawing.Color.Black;
            this.artistLbl.Font = new System.Drawing.Font("Arial", 7.75F);
            this.artistLbl.ForeColor = System.Drawing.Color.White;
            this.artistLbl.Location = new System.Drawing.Point(91, 28);
            this.artistLbl.Name = "artistLbl";
            this.artistLbl.Size = new System.Drawing.Size(104, 16);
            this.artistLbl.TabIndex = 5;
            this.artistLbl.Text = "Artist";
            this.artistLbl.Click += new System.EventHandler(this.artistLbl_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.Color.Black;
            this.titleLbl.Font = new System.Drawing.Font("Arial Narrow", 12.75F);
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(86, 6);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(109, 25);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = "Title";
            this.titleLbl.Click += new System.EventHandler(this.titleLbl_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Black;
            this.prevBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prevBtn.BackgroundImage")));
            this.prevBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prevBtn.CausesValidation = false;
            this.prevBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.prevBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.prevBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevBtn.ForeColor = System.Drawing.Color.White;
            this.prevBtn.Location = new System.Drawing.Point(322, 33);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(46, 47);
            this.prevBtn.TabIndex = 3;
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Black;
            this.nextBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextBtn.BackgroundImage")));
            this.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextBtn.CausesValidation = false;
            this.nextBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.nextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(457, 33);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(46, 47);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 46);
            this.panel2.TabIndex = 7;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown_1);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove_1);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp_1);
            // 
            // exitBtn
            // 
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(761, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(23, 46);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.logo);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 432);
            this.panel3.TabIndex = 8;
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(5, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(153, 80);
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.AlbumsBtn);
            this.panel4.Controls.Add(this.ArtistsBtn);
            this.panel4.Controls.Add(this.SongsBtn);
            this.panel4.Location = new System.Drawing.Point(0, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(157, 326);
            this.panel4.TabIndex = 6;
            // 
            // AlbumsBtn
            // 
            this.AlbumsBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AlbumsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AlbumsBtn.FlatAppearance.BorderSize = 0;
            this.AlbumsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlbumsBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumsBtn.ForeColor = System.Drawing.Color.White;
            this.AlbumsBtn.Image = ((System.Drawing.Image)(resources.GetObject("AlbumsBtn.Image")));
            this.AlbumsBtn.Location = new System.Drawing.Point(19, 199);
            this.AlbumsBtn.Name = "AlbumsBtn";
            this.AlbumsBtn.Size = new System.Drawing.Size(129, 59);
            this.AlbumsBtn.TabIndex = 7;
            this.AlbumsBtn.Text = "Albums";
            this.AlbumsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AlbumsBtn.UseVisualStyleBackColor = false;
            this.AlbumsBtn.Click += new System.EventHandler(this.AlbumsBtn_Click);
            // 
            // ArtistsBtn
            // 
            this.ArtistsBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ArtistsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ArtistsBtn.FlatAppearance.BorderSize = 0;
            this.ArtistsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArtistsBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistsBtn.ForeColor = System.Drawing.Color.White;
            this.ArtistsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ArtistsBtn.Image")));
            this.ArtistsBtn.Location = new System.Drawing.Point(19, 116);
            this.ArtistsBtn.Name = "ArtistsBtn";
            this.ArtistsBtn.Size = new System.Drawing.Size(129, 59);
            this.ArtistsBtn.TabIndex = 6;
            this.ArtistsBtn.Text = "Artists";
            this.ArtistsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ArtistsBtn.UseVisualStyleBackColor = false;
            this.ArtistsBtn.Click += new System.EventHandler(this.ArtistsBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // albumLayout
            // 
            this.albumLayout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.albumLayout.AutoScroll = true;
            this.albumLayout.Location = new System.Drawing.Point(154, 43);
            this.albumLayout.Name = "albumLayout";
            this.albumLayout.Size = new System.Drawing.Size(630, 438);
            this.albumLayout.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.albumLayout);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "NickTunes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NumberCol;
        private System.Windows.Forms.ColumnHeader TitleCol;
        private System.Windows.Forms.ColumnHeader ArtistCol;
        private System.Windows.Forms.ColumnHeader AlbumCol;
        private System.Windows.Forms.Button SongsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AlbumsBtn;
        private System.Windows.Forms.Button ArtistsBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label artistLbl;
        private System.Windows.Forms.TrackBar seekBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label endTimeLbl;
        private System.Windows.Forms.Label currTimeLbl;
        private System.Windows.Forms.TrackBar volumeTrackBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FlowLayoutPanel albumLayout;
        private System.Windows.Forms.Panel resize;
    }
}


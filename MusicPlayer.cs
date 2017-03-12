using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    class MusicPlayer
    {
        Boolean firstTime = true;
        private static MusicPlayer instance;
        public static MusicPlayer Instance { get { return instance; } }
        public static void Init()
        {
            instance = new MusicPlayer();
        }
        private NAudio.Wave.AudioFileReader reader = null;
        private NAudio.Wave.DirectSoundOut output = null;
        
        // Plays audio track
        public void Play(string FileName)
        {
            Console.Out.WriteLine("FileName is: " + FileName);
            reader = new NAudio.Wave.AudioFileReader(FileName);
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(new NAudio.Wave.WaveChannel32(reader));
            if(firstTime == true)
            {
                SetVolume((float) .5);
                firstTime = false;
            }
            output.Play();
            Program.MainForm.StartTimer();
        }

        //Pauses music playback and stops trackbar
        public void Pause()
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                   Program.MainForm.StopTimer();
                   output.Pause();
                }
                else if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused)
                {
                    output.Play();
                    Program.MainForm.StartTimer();
                }

            }
        }

        // Stops music playback
        public void Stop()
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                    output.Stop();
            }
            if (reader != null)
            {
                reader.Dispose();
                reader = null;
            }
        }

        // Called whent he volume slider is used to set the volume
        public void SetVolume(float volume)
        {
            reader.Volume = volume;
            Console.Out.WriteLine("volume is is: " + reader.Volume);
        }

        // Sets the time of the audio playback when the trackbar value gets changed
        public void SetPosition(long seconds)
        {
            reader.CurrentTime = (TimeSpan.FromSeconds(seconds));
        }
        
        // Calculates the length of the audio track so we can display it and use it to skip to certain times in the song
       public double GetMediaDuration(string MediaFilename)
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


    }
}

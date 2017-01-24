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
        

        public void Play(string FileName)
        {
            Console.Out.WriteLine("FileName is: " + FileName);
            reader = new NAudio.Wave.AudioFileReader(FileName);
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(new NAudio.Wave.WaveChannel32(reader));
            if(firstTime == true)
            {
                setVolume((float) .5);
                firstTime = false;
            }
            output.Play();
            Program.MainForm.startTimer();
        }
        public void Pause()
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                   Program.MainForm.stopTimer();
                   output.Pause();
                }
                else if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused)
                {
                    output.Play();
                    Program.MainForm.startTimer();
                }

            }
        }
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
        public void setVolume(float volume)
        {
            reader.Volume = volume;
            Console.Out.WriteLine("volume is is: " + reader.Volume);
        }
        public void setPosition(long seconds)
        {
            reader.CurrentTime = (TimeSpan.FromSeconds(seconds));
        }

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

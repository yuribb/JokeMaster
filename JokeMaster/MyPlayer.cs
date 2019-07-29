using System;
using NAudio.Wave;

namespace JokeMaster
{
    public class MyPlayer
    {
        private AudioFileReader File { get; set; }
        public string Name { get; }
        public bool Played { get; set; }

        private WaveOutEvent outputDevice;

        public MyPlayer(string path)
        {
            Played = false;
            Name = path;
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            DisposeInternal();
        }

        private void DisposeInternal()
        {
            Played = false;
            if (outputDevice != null)
            {
                outputDevice.Dispose();
                outputDevice = null;
            }

            if (File != null)
            {
                File.Dispose();
                File = null;
            }
        }

        public void Start(EventHandler doneCallback = null)
        {
            Played = true;
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (File == null)
            {
                File = new AudioFileReader(Name);
                outputDevice.Init(File);
            }
            outputDevice.Play();
        }

        public void Stop()
        {
            outputDevice?.Stop();
            DisposeInternal();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

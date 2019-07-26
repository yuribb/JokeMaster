using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NAudio.Wave;

namespace JokeMaster
{
    public partial class MainForm : Form
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

        private readonly List<MyPlayer> players = new List<MyPlayer>();


        public MainForm()
        {
            InitializeComponent();
            players.Add(new MyPlayer(@"Sounds\BadumTish.wav"));
            players.Add(new MyPlayer(@"Sounds\FyutHa.wav"));
            players.Add(new MyPlayer(@"Sounds\SadTrombone.wav"));
            players.Add(new MyPlayer(@"Sounds\Chastushka.wav"));
            players.Add(new MyPlayer(@"Sounds\DMX.wav"));
            players.Add(new MyPlayer(@"Sounds\Vitas.wav"));
            players.Add(new MyPlayer(@"Sounds\Beavis.wav"));
            players.Add(new MyPlayer(@"Sounds\Leviosa.wav"));
        }

        private void BtBadumTish_Click(object sender, EventArgs e)
        {

            PlaySound(0);
        }

        private void BtFyutHa_Click(object sender, EventArgs e)
        {
            PlaySound(1);
        }

        private void BtSadTrombone_Click(object sender, EventArgs e)
        {
            PlaySound(2);
        }

        private void BtChastushka_Click(object sender, EventArgs e)
        {
            PlaySound(3);
        }

        private void BtDimitrius_Click(object sender, EventArgs e)
        {
            PlaySound(4);
        }

        private void BtBash_Click(object sender, EventArgs e)
        {
            PlaySound(5);
        }

        private void BtBeavis_Click(object sender, EventArgs e)
        {
            PlaySound(6);
        }

        private void BtLeviosa_Click(object sender, EventArgs e)
        {
            PlaySound(7);
        }

        private void StopSound()
        {
            foreach (MyPlayer player in players)
            {
                player?.Stop();
            }
        }

        private void PlaySound(int i)
        {
            if (players[i].Played)
            {
                players[i].Stop();
            }
            else
            {
                StopSound();
                players[i].Start();
            }
        }

        
    }
}
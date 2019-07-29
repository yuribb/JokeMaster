using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokeMaster
{
    public class UserPlayer
    {
        private readonly List<MyPlayer> players = new List<MyPlayer>();

        public UserPlayer(params string[] paths)
        {
            players.Add(new MyPlayer(@"Sounds\BadumTish.wav"));
            players.Add(new MyPlayer(@"Sounds\FyutHa.wav"));
            players.Add(new MyPlayer(@"Sounds\SadTrombone.wav"));
            players.Add(new MyPlayer(@"Sounds\Chastushka.wav"));
            players.Add(new MyPlayer(@"Sounds\DMX.wav"));
            players.Add(new MyPlayer(@"Sounds\Vitas.wav"));
            players.Add(new MyPlayer(@"Sounds\Beavis.wav"));
            players.Add(new MyPlayer(@"Sounds\Leviosa.wav"));
        }

        public void PlaySound(int i)
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
        public void StopSound()
        {
            foreach (MyPlayer player in players)
            {
                player?.Stop();
            }
        }
    }
}

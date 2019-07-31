using System.Collections.Generic;

namespace JokeMaster
{
    public class UserPlayer
    {
        private readonly List<MyPlayer> players = new List<MyPlayer>();

        public UserPlayer(params string[] paths)
        {

            if (paths != null)
            {
                foreach(string path in paths)
                {
                    players.Add(new MyPlayer(path));
                }
            }
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

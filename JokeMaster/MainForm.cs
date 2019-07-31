using System;
using System.Windows.Forms;

namespace JokeMaster
{
    public partial class MainForm : Form
    {
        private UserPlayer Player { get; }

        public MainForm()
        {
            InitializeComponent();
            Player = new UserPlayer(
                @"Sounds\BadumTish.wav", 
                @"Sounds\FyutHa.wav",
                @"Sounds\SadTrombone.wav",
                @"Sounds\Chastushka.wav",
                @"Sounds\DMX.wav",
                @"Sounds\Vitas.wav",
                @"Sounds\Beavis.wav",
                @"Sounds\Leviosa.wav",
                @"Sounds\Kosoy.wav");
        }

        private void BtBadumTish_Click(object sender, EventArgs e)
        {

            Player.PlaySound(0);
        }

        private void BtFyutHa_Click(object sender, EventArgs e)
        {
            Player.PlaySound(1);
        }

        private void BtSadTrombone_Click(object sender, EventArgs e)
        {
            Player.PlaySound(2);
        }

        private void BtChastushka_Click(object sender, EventArgs e)
        {
            Player.PlaySound(3);
        }

        private void BtDimitrius_Click(object sender, EventArgs e)
        {
            Player.PlaySound(4);
        }

        private void BtBash_Click(object sender, EventArgs e)
        {
            Player.PlaySound(5);
        }

        private void BtBeavis_Click(object sender, EventArgs e)
        {
            Player.PlaySound(6);
        }

        private void BtLeviosa_Click(object sender, EventArgs e)
        {
            Player.PlaySound(7);
        }

        private void BtKosoy_Click(object sender, EventArgs e)
        {
            Player.PlaySound(8);
        }
    }
}
using System;
using System.Windows.Forms;

using NAudio.Wave;

namespace CompareAudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private Player player1;
        private Player player2;

        private IWavePlayer WaveOutDevice { get; set; }


        // Form events

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WaveOutDevice = new WaveOut();

            this.player1 = new Player(this.chart1, this.File1Label);
            this.player1.SetFile("c:\\Users\\Simon\\Desktop\\3 2 5.5.wav");

            this.player2 = new Player(this.chart2, this.File2Label);
            this.player2.SetFile("c:\\Users\\Simon\\Desktop\\Simon2.wav");

            this.Play(this.player1);
            this.Mute1Button.Text = "Mute";
            this.Mute2Button.Text = "Unmute";
        }

        private void OpenWaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog { Filter = "Wave file (*.wav)|*.wav" };
            if (open.ShowDialog() != DialogResult.OK)
                return;

            this.player1.SetFile(open.FileName);
            this.player2.SetFile(open.FileName);

            this.Play(this.player1);
            this.Play(this.player2);
        }

        private void ShowPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.player1.PositionInMillions() + " million\n"
                            + this.player2.PositionInMillions() + " million");
        }

        private void Mute1Button_Click(object sender, EventArgs e)
        {
            if (this.Mute1Button.Text == "Mute")
            {
                this.Play(this.player2);
                this.Mute1Button.Text = "Unmute";
                this.Mute2Button.Text = "Mute";
            }
            else
            {
                this.Play(this.player1);
                this.Mute1Button.Text = "Mute";
                this.Mute2Button.Text = "Unmute";
            }
        }

        private void Mute2Button_Click(object sender, EventArgs e)
        {
            if (this.Mute2Button.Text == "Mute")
            {
                this.Play(this.player1);
                this.Mute1Button.Text = "Mute";
                this.Mute2Button.Text = "Unmute";
            }
            else
            {
                this.Play(this.player2);
                this.Mute1Button.Text = "Unmute";
                this.Mute2Button.Text = "Mute";
            }
        }


        // Non-public methods

        private void Play(Player player, float volume = 1, int positionInMillions = 10)
        {
            player.Volume = volume;
            this.WaveOutDevice.Volume = volume;

            this.PlayWave(player, 10 * player.Million);
        }

        private void PlayWave(Player player, long position)
        {
            player.Reader.Position = position;

            if (this.WaveOutDevice != null)
                this.WaveOutDevice.Stop();

            this.WaveOutDevice = new WaveOut();

            try
            {
                this.WaveOutDevice.Init(player.Reader);
                this.label1.Text = player.File;
                this.WaveOutDevice.Play();
            }
            catch (Exception ee)
            {
                MessageBox.Show("error " + ee.Message);
            }
        }
    }
}

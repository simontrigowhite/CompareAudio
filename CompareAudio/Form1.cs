using System;
using System.Windows.Forms;

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


        // Form events

        private void Form1_Load(object sender, EventArgs e)
        {
            this.player1 = new Player(this.chart1);
            this.player1.SetFile("c:\\Users\\Simon\\Desktop\\3 2 5.5.wav");

            this.player2 = new Player(this.chart2);
            this.player2.SetFile("c:\\Users\\Simon\\Desktop\\3 2 5.5.wav");

            this.player1.Play();
            this.player2.Play();
        }

        private void OpenWaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog { Filter = "Wave file (*.wav)|*.wav" };
            if (open.ShowDialog() != DialogResult.OK)
                return;

            this.player1.SetFile(open.FileName);
            this.player2.SetFile(open.FileName);

            this.player1.Play();
            this.player2.Play();
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
                this.player1.Mute();
                this.Mute1Button.Text = "Unmute";
            }
            else
            {
                this.player1.Unmute();
                this.Mute1Button.Text = "Mute";
            }
        }

        private void Mute2Button_Click(object sender, EventArgs e)
        {
            if (this.Mute2Button.Text == "Mute")
            {
                this.player2.Mute();
                this.Mute2Button.Text = "Unmute";
            }
            else
            {
                this.player2.Unmute();
                this.Mute2Button.Text = "Mute";
            }
        }
    }
}

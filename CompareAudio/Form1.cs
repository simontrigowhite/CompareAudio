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

        private Player player;


        // Form events

        private void Form1_Load(object sender, EventArgs e)
        {
            this.player = new Player(this.chart1);
            this.player.SetChart("c:\\Users\\Simon\\Desktop\\3 2 5.5.wav");
        }

        private void OpenWaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog { Filter = "Wave file (*.wav)|*.wav" };
            if (open.ShowDialog() != DialogResult.OK)
                return;

            this.player.SetChart(open.FileName);
        }

        private void ShowPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.player.PositionMillions() + " million");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NAudio.Wave;

namespace CompareAudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string file = "c:\\Users\\Simon\\Desktop\\3 2 5.5.wav";

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.PlayFile();
            this.ShowFile();
        }

        private void PlayFile()
        {
            IWavePlayer waveOutDevice;
            AudioFileReader audioFileReader;

            waveOutDevice = new WaveOut();

            try
            {
                audioFileReader = new AudioFileReader(this.file);

                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
            }
            catch (Exception ee)
            {
                MessageBox.Show("error " + ee.Message);
            }
        }

        private void openWaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFile();
        }

        private void ShowFile()
        {
            //OpenFileDialog open = new OpenFileDialog();
            //open.Filter = "Wave file (*.wav)|*.wav";
            //if (open.ShowDialog() != DialogResult.OK) 
            //    return;

            this.waveViewer1.SamplesPerPixel = 4000;

            this.waveViewer1.WaveStream = new NAudio.Wave.WaveFileReader(this.file);
        }
    }
}

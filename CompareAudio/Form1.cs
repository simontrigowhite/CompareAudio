using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            Series series = chart1.Series.Add("wave");
            series.ChartType = SeriesChartType.FastLine;
            series.ChartArea = "ChartArea1";

            NAudio.Wave.WaveChannel32 wave = new WaveChannel32(new NAudio.Wave.WaveFileReader(file));

            int read = 0;
            while (wave.Position < wave.Length)
            {
                byte[] buffer = new byte[4096];
                read = wave.Read(buffer, 0, 4096);

                double max = -1;

                for (int i = 0; i < read / 4; i++)
                {
                    double x = BitConverter.ToSingle(buffer, i * 4);
                    if (x > max)
                        max = x;
                }
                series.Points.Add(max);
            }


        }
    }
}

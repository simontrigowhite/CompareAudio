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
        IWavePlayer waveOutDevice;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowFile();
        }

        private void openWaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Wave file (*.wav)|*.wav";
            if (open.ShowDialog() != DialogResult.OK)
                return;
            this.file = open.FileName;
            this.ShowFile();
        }

        private void ShowFile()
        {

            if (this.waveOutDevice != null)
                this.waveOutDevice.Stop();

            WaveFileReader reader = new NAudio.Wave.WaveFileReader(file);

            this.ShowChart(reader);

            PlayWave(reader);
        }

        private void PlayWave(WaveFileReader reader)
        {
            waveOutDevice = new WaveOut();

            reader.Position = 0;

            try
            {
                waveOutDevice.Init(reader);
                waveOutDevice.Play();
            }
            catch (Exception ee)
            {
                MessageBox.Show("error " + ee.Message);
            }
        }

        private void ShowChart(WaveFileReader reader)
        {
            this.chart1.Series.RemoveAt(0);

            Series series = this.chart1.Series.Add("wave");
            series.ChartType = SeriesChartType.FastLine;
            series.ChartArea = "ChartArea1";

            NAudio.Wave.WaveChannel32 wave = new WaveChannel32(reader);

            int read = 0;
            while (wave.Position < wave.Length)
            {
                int bytes = 100000;
                byte[] buffer = new byte[bytes];
                read = wave.Read(buffer, 0, bytes);

                double total = 0;
                int count = 0;

                for (int i = 0; i < read / 4; i++)
                {
                    double x = BitConverter.ToSingle(buffer, i * 4);

                    total += x;
                    count += 1;
                }
                series.Points.Add(total / Convert.ToDouble(count));
            }
        }
    }
}

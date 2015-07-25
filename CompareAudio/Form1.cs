using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using NAudio.Wave;

namespace CompareAudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        const int million = 1000000;

        private IWavePlayer waveOutDevice;

        private WaveFileReader reader;


        // Form events

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowFile("c:\\Users\\Simon\\Desktop\\3 2 5.5.wav");
        }

        private void OpenWaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog { Filter = "Wave file (*.wav)|*.wav" };
            if (open.ShowDialog() != DialogResult.OK)
                return;

            this.ShowFile(open.FileName);
        }

        private void showPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            long position = this.reader.Position;

            string positionMillions = (Convert.ToSingle(position) / Convert.ToSingle(million)).ToString();
            MessageBox.Show(positionMillions + " million");
        }


        // Non-public methods

        private void ShowFile(string file)
        {
            if (this.waveOutDevice != null)
                this.waveOutDevice.Stop();

            this.reader = new WaveFileReader(file);

            this.ShowChart();

            this.PlayWave(10 * million);
        }

        private void PlayWave(long position)
        {
            this.waveOutDevice = new WaveOut();

            this.reader.Position = position;

            try
            {
                this.waveOutDevice.Init(reader);
                this.waveOutDevice.Play();
            }
            catch (Exception ee)
            {
                MessageBox.Show("error " + ee.Message);
            }
        }

        private void ShowChart()
        {
            this.chart1.Series.RemoveAt(0);

            Series series = this.chart1.Series.Add("wave");
            series.ChartType = SeriesChartType.FastLine;
            series.ChartArea = "ChartArea1";

            WaveChannel32 wave = new WaveChannel32(reader);

            while (wave.Position < wave.Length)
            {
                int bytes = 100000;
                byte[] buffer = new byte[bytes];

                int read = wave.Read(buffer, 0, bytes);

                double total = 0;
                int count = 0;
                double average = 0;

                for (int i = 0; i < read / 4; i++)
                {
                    double x = BitConverter.ToSingle(buffer, i * 4);

                    double z = average * count;

                    double diff = Math.Abs(z - total);

                    if (diff > 0.00001)
                        throw new Exception("no");
                            
                    total += x;
                    count += 1;

                    average = (z + x) / count;
                }
                series.Points.Add(total / Convert.ToDouble(count));
            }
        }
    }
}

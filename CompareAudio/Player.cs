using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using NAudio.Wave;

namespace CompareAudio
{
    public class Player
    {
        public Player(Chart chart, Label fileLabel)
        {
            this.Chart = chart;
            this.FileLabel = fileLabel;
        }


        // Properties and fields

        public string File { get; private set; }
        public WaveFileReader Reader { get; private set; }
        public Chart Chart { get; private set; }
        public Label FileLabel { get; private set; }

        public float Volume { get; set; }
        public int Million = 1000000;


        // Public methods

        public void SetFile(string file)
        {
            //if (this.WaveOutDevice != null)
            //    this.WaveOutDevice.Stop();

            //this.WaveOutDevice = new WaveOut();

            this.File = file;
            this.Reader = new WaveFileReader(file);
            this.ShowChart();
            this.FileLabel.Text = file;
        }

        //public void Play(float volume = 1, int positionInMillions = 10)
        //{
        //    this.Volume = volume;
        //    this.WaveOutDevice.Volume = volume;

        //    this.PlayWave(10 * Million);
        //}

        public string PositionInMillions()
        {
            return (Convert.ToSingle(this.Reader.Position) / Convert.ToSingle(Million)).ToString();
        }

        //public void Mute()
        //{
        //    this.WaveOutDevice.Volume = 0;
        //}

        //public void Unmute()
        //{
        //    this.WaveOutDevice.Volume = this.Volume;
        //}


        // Non-public methods

        //private void PlayWave(long position)
        //{
        //    this.Reader.Position = position;

        //    try
        //    {
        //        this.WaveOutDevice.Init(this.Reader);
        //        this.WaveOutDevice.Play();
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show("error " + ee.Message);
        //    }
        //}

        private void ShowChart()
        {
            this.Chart.Series.RemoveAt(0);

            Series series = this.Chart.Series.Add("wave");
            series.ChartType = SeriesChartType.FastLine;
            series.ChartArea = "ChartArea1";

            WaveChannel32 wave = new WaveChannel32(this.Reader);

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

using NAudio.Wave;

namespace Quinta
{
    public partial class Form1 : Form
    {
        private readonly WaveOutEvent _outputDevice;
        private AudioFileReader _audioFile;
        private System.Windows.Forms.Timer _timer;

        public Form1()
        {
            InitializeComponent();
            _outputDevice = new WaveOutEvent();
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 100;
            _timer.Tick += Timer_Tick;
        }

        //Timer
        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (_audioFile != null && _outputDevice.PlaybackState == PlaybackState.Playing)
            {
                labelTimer.Text = _audioFile.CurrentTime.ToString(@"mm\:ss") + " / " + _audioFile.TotalTime.ToString(@"mm\:ss");

                trackBarTimer.Value = (int)_audioFile.CurrentTime.TotalMilliseconds;
            }
        }

        //Buttons
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_audioFile != null)
                {
                    buttonStop.PerformClick();
                }
                string selectedFile = openFileDialog.FileName;
                _audioFile = new AudioFileReader(selectedFile);
                _outputDevice.Init(_audioFile);
                trackBarTimer.Maximum = (int)_audioFile.TotalTime.TotalMilliseconds;

                labelTrackName.Text = System.IO.Path.GetFileName(selectedFile);
                buttonStart.PerformClick();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (_audioFile != null && _outputDevice != null)
            {
                _outputDevice.Play();
                _timer.Start();
            };
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (_outputDevice != null && _audioFile != null)
            {
                _outputDevice.Stop();
                _timer.Stop();
                _audioFile.Dispose();
                _audioFile = null;
                trackBarTimer.Value = 0;

                labelTrackName.Text = "Выберите трек";
                labelTimer.Text = "00:00";
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (_outputDevice != null)
            {
                _outputDevice.Pause();
                _timer.Stop();
            }
        }

        //TrackBars
        private void trackBarTimer_Scroll(object sender, EventArgs e)
        {
            if (_outputDevice != null && _audioFile != null)
            {
                int newPosition = trackBarTimer.Value;
                double percentage = (double)newPosition / trackBarTimer.Maximum;
                long newPositionInBytes = (long)(_audioFile.Length * percentage);

                _audioFile.Position = newPositionInBytes;
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            if (_outputDevice != null)
            {
                _outputDevice.Volume = (float)trackBarVolume.Value / trackBarVolume.Maximum;
            }
        }
    }
}

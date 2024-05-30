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
            ListBoxPlayList.DataSource = playlist;
            ListBoxPlayList.SelectedIndexChanged += ListBoxPlayList_SelectedIndexChanged;
            _outputDevice = new WaveOutEvent();
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 100;
            _timer.Tick += Timer_Tick;
            this.MaximizeBox = false;
            _outputDevice.Volume = (float)trackBarVolume.Value / trackBarVolume.Maximum;
        }

        //playlist
        private List<string> playlist = new List<string>();
        private void ListBoxPlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxPlayList.SelectedIndex != -1) // Проверка, выбран ли элемент
            {
                string selectedFile = ListBoxPlayList.SelectedItem.ToString();

                // Остановка текущего воспроизведения, если оно есть
                buttonStop.PerformClick();

                // Открытие нового трека
                _audioFile = new AudioFileReader(selectedFile);
                _outputDevice.Init(_audioFile);
                trackBarTimer.Maximum = (int)_audioFile.TotalTime.TotalMilliseconds;

                labelTrackName.Text = System.IO.Path.GetFileName(selectedFile);

                // Начало воспроизведения
                buttonPause.PerformClick();
                buttonStart.PerformClick();
            }
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
                buttonPause.PerformClick();
                string selectedFile = openFileDialog.FileName;
                if (!playlist.Contains(selectedFile))
                {
                    playlist.Add(selectedFile);
                }

                ListBoxPlayList.DataSource = null;
                ListBoxPlayList.DataSource = playlist;
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
                buttonStart.Visible = false;
                buttonPause.Visible = true;

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
                buttonStart.Visible = true;
                buttonPause.Visible = false;
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
            if (trackBarVolume.Value == 0)
            {
                buttonVolume.Visible = false;
                buttonVolumeMute.Visible = true;
            }
            else
            {
                buttonVolume.Visible = true;
                buttonVolumeMute.Visible = false;
            }
        }
        private void buttonVolume_Click(object sender, EventArgs e)
        {
            trackBarVolume.Value = 0;
            _outputDevice.Volume = 0;
            buttonVolume.Visible = false;
            buttonVolumeMute.Visible = true;
        }

        private void buttonVolumeMute_Click(object sender, EventArgs e)
        {
            trackBarVolume.Value = 20;
            _outputDevice.Volume = (float)trackBarVolume.Value / trackBarVolume.Maximum;
            buttonVolume.Visible = true;
            buttonVolumeMute.Visible = false;
        }



        private void buttonNext_Click(object sender, EventArgs e)
        {
            int currentIndex = ListBoxPlayList.SelectedIndex;
            if (currentIndex < ListBoxPlayList.Items.Count - 1)
            {
                ListBoxPlayList.SelectedIndex = currentIndex + 1;
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            int currentIndex = ListBoxPlayList.SelectedIndex;
            if (currentIndex > 0)
            {
                ListBoxPlayList.SelectedIndex = currentIndex - 1;
            }
        }
    }
}

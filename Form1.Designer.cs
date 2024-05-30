namespace Quinta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonStart = new Button();
            buttonPause = new Button();
            buttonOpen = new Button();
            buttonStop = new Button();
            trackBarTimer = new TrackBar();
            trackBarVolume = new TrackBar();
            labelTrackName = new Label();
            labelTimer = new Label();
            ListBoxPlayList = new ListBox();
            buttonVolume = new Button();
            buttonVolumeMute = new Button();
            buttonPrevious = new Button();
            buttonNext = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBarTimer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(272, 416);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(64, 35);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "▶";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonPause
            // 
            buttonPause.Location = new Point(272, 416);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(64, 35);
            buttonPause.TabIndex = 1;
            buttonPause.Text = "❚❚";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(20, 416);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(112, 35);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "открыть";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(138, 416);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(37, 35);
            buttonStop.TabIndex = 3;
            buttonStop.Text = "❌";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // trackBarTimer
            // 
            trackBarTimer.Location = new Point(12, 358);
            trackBarTimer.Name = "trackBarTimer";
            trackBarTimer.Size = new Size(585, 56);
            trackBarTimer.TabIndex = 4;
            trackBarTimer.TickStyle = TickStyle.None;
            trackBarTimer.Scroll += trackBarTimer_Scroll;
            // 
            // trackBarVolume
            // 
            trackBarVolume.Location = new Point(465, 393);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Size = new Size(130, 56);
            trackBarVolume.TabIndex = 5;
            trackBarVolume.TickStyle = TickStyle.None;
            trackBarVolume.Value = 100;
            trackBarVolume.Scroll += trackBarVolume_Scroll;
            // 
            // labelTrackName
            // 
            labelTrackName.AutoSize = true;
            labelTrackName.Location = new Point(20, 335);
            labelTrackName.Name = "labelTrackName";
            labelTrackName.Size = new Size(112, 20);
            labelTrackName.TabIndex = 6;
            labelTrackName.Text = "Выберите трек";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(492, 335);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(44, 20);
            labelTimer.TabIndex = 7;
            labelTimer.Text = "00:00";
            // 
            // ListBoxPlayList
            // 
            ListBoxPlayList.FormattingEnabled = true;
            ListBoxPlayList.Location = new Point(12, 12);
            ListBoxPlayList.Name = "ListBoxPlayList";
            ListBoxPlayList.Size = new Size(572, 304);
            ListBoxPlayList.TabIndex = 8;
            ListBoxPlayList.SelectedIndexChanged += ListBoxPlayList_SelectedIndexChanged;
            // 
            // buttonVolume
            // 
            buttonVolume.BackgroundImage = (Image)resources.GetObject("buttonVolume.BackgroundImage");
            buttonVolume.BackgroundImageLayout = ImageLayout.Zoom;
            buttonVolume.Location = new Point(444, 393);
            buttonVolume.Name = "buttonVolume";
            buttonVolume.Size = new Size(27, 29);
            buttonVolume.TabIndex = 9;
            buttonVolume.UseVisualStyleBackColor = true;
            buttonVolume.Click += buttonVolume_Click;
            // 
            // buttonVolumeMute
            // 
            buttonVolumeMute.BackgroundImage = (Image)resources.GetObject("buttonVolumeMute.BackgroundImage");
            buttonVolumeMute.BackgroundImageLayout = ImageLayout.Zoom;
            buttonVolumeMute.Location = new Point(444, 393);
            buttonVolumeMute.Name = "buttonVolumeMute";
            buttonVolumeMute.Size = new Size(27, 29);
            buttonVolumeMute.TabIndex = 10;
            buttonVolumeMute.UseVisualStyleBackColor = true;
            buttonVolumeMute.Click += buttonVolumeMute_Click;
            // 
            // buttonPrevious
            // 
            buttonPrevious.Location = new Point(202, 416);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(64, 35);
            buttonPrevious.TabIndex = 11;
            buttonPrevious.Text = "⏮";
            buttonPrevious.UseVisualStyleBackColor = true;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(342, 416);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(64, 35);
            buttonNext.TabIndex = 12;
            buttonNext.Text = "⏭ ";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 469);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrevious);
            Controls.Add(ListBoxPlayList);
            Controls.Add(labelTimer);
            Controls.Add(labelTrackName);
            Controls.Add(buttonStop);
            Controls.Add(buttonOpen);
            Controls.Add(buttonStart);
            Controls.Add(buttonPause);
            Controls.Add(buttonVolume);
            Controls.Add(buttonVolumeMute);
            Controls.Add(trackBarVolume);
            Controls.Add(trackBarTimer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Quinta";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)trackBarTimer).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Button buttonPause;
        private Button buttonOpen;
        private Button buttonStop;
        private TrackBar trackBarTimer;
        private TrackBar trackBarVolume;
        private Label labelTrackName;
        private Label labelTimer;
        private ListBox ListBoxPlayList;
        private Button buttonVolume;
        private Button buttonVolumeMute;
        private Button buttonPrevious;
        private Button buttonNext;
    }
}

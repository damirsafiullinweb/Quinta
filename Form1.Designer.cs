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
            buttonStart = new Button();
            buttonPause = new Button();
            buttonOpen = new Button();
            buttonStop = new Button();
            trackBarTimer = new TrackBar();
            trackBarVolume = new TrackBar();
            labelTrackName = new Label();
            labelTimer = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarTimer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(51, 112);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "старт";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonPause
            // 
            buttonPause.Location = new Point(51, 147);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(94, 29);
            buttonPause.TabIndex = 1;
            buttonPause.Text = "пауза";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(151, 112);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(94, 29);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "открыть";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(151, 147);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(94, 29);
            buttonStop.TabIndex = 3;
            buttonStop.Text = "стоп";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // trackBarTimer
            // 
            trackBarTimer.Location = new Point(51, 35);
            trackBarTimer.Name = "trackBarTimer";
            trackBarTimer.Size = new Size(330, 56);
            trackBarTimer.TabIndex = 4;
            trackBarTimer.Scroll += trackBarTimer_Scroll;
            // 
            // trackBarVolume
            // 
            trackBarVolume.Location = new Point(251, 112);
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Size = new Size(130, 56);
            trackBarVolume.TabIndex = 5;
            trackBarVolume.Value = 10;
            trackBarVolume.Scroll += trackBarVolume_Scroll;
            // 
            // labelTrackName
            // 
            labelTrackName.AutoSize = true;
            labelTrackName.Location = new Point(58, 12);
            labelTrackName.Name = "labelTrackName";
            labelTrackName.Size = new Size(112, 20);
            labelTrackName.TabIndex = 6;
            labelTrackName.Text = "Выберите трек";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(58, 71);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(44, 20);
            labelTimer.TabIndex = 7;
            labelTimer.Text = "00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 233);
            Controls.Add(labelTimer);
            Controls.Add(labelTrackName);
            Controls.Add(trackBarVolume);
            Controls.Add(trackBarTimer);
            Controls.Add(buttonStop);
            Controls.Add(buttonOpen);
            Controls.Add(buttonPause);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Quinta";
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
    }
}

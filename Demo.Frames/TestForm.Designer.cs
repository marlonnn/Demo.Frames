namespace Demo.Frames
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picFrame = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnVideoSave = new System.Windows.Forms.Button();
            this.btnVideoStop = new System.Windows.Forms.Button();
            this.btnVideoPlay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFps = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.lblRadam = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // picFrame
            // 
            this.picFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFrame.Location = new System.Drawing.Point(12, 106);
            this.picFrame.Name = "picFrame";
            this.picFrame.Size = new System.Drawing.Size(360, 360);
            this.picFrame.TabIndex = 2;
            this.picFrame.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(10, 10);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(88, 24);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnVideoSave
            // 
            this.btnVideoSave.Location = new System.Drawing.Point(393, 10);
            this.btnVideoSave.Name = "btnVideoSave";
            this.btnVideoSave.Size = new System.Drawing.Size(88, 24);
            this.btnVideoSave.TabIndex = 5;
            this.btnVideoSave.Text = "Save Video";
            // 
            // btnVideoStop
            // 
            this.btnVideoStop.Location = new System.Drawing.Point(280, 10);
            this.btnVideoStop.Name = "btnVideoStop";
            this.btnVideoStop.Size = new System.Drawing.Size(88, 24);
            this.btnVideoStop.TabIndex = 4;
            this.btnVideoStop.Text = "Stop";
            this.btnVideoStop.Click += new System.EventHandler(this.btnVideoStop_Click);
            // 
            // btnVideoPlay
            // 
            this.btnVideoPlay.Location = new System.Drawing.Point(170, 10);
            this.btnVideoPlay.Name = "btnVideoPlay";
            this.btnVideoPlay.Size = new System.Drawing.Size(88, 24);
            this.btnVideoPlay.TabIndex = 3;
            this.btnVideoPlay.Text = "Play";
            this.btnVideoPlay.Click += new System.EventHandler(this.btnVideoPlay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FPS:";
            // 
            // hScrollBar
            // 
            this.hScrollBar.Location = new System.Drawing.Point(40, 42);
            this.hScrollBar.Maximum = 200;
            this.hScrollBar.Minimum = 1;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(424, 17);
            this.hScrollBar.TabIndex = 0;
            this.hScrollBar.Value = 5;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscrFps_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOpen);
            this.groupBox3.Controls.Add(this.btnVideoSave);
            this.groupBox3.Controls.Add(this.btnVideoStop);
            this.groupBox3.Controls.Add(this.btnVideoPlay);
            this.groupBox3.Controls.Add(this.lblFps);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.hScrollBar);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 88);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // lblFps
            // 
            this.lblFps.AutoSize = true;
            this.lblFps.Location = new System.Drawing.Point(467, 44);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(13, 13);
            this.lblFps.TabIndex = 2;
            this.lblFps.Text = "5";
            // 
            // trackBar
            // 
            this.trackBar.LargeChange = 2;
            this.trackBar.Location = new System.Drawing.Point(429, 131);
            this.trackBar.Maximum = 6;
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.Size = new System.Drawing.Size(45, 324);
            this.trackBar.TabIndex = 4;
            this.trackBar.ValueChanged += new System.EventHandler(this.TraceBar_ValueChanged);
            // 
            // lblRadam
            // 
            this.lblRadam.AutoSize = true;
            this.lblRadam.Location = new System.Drawing.Point(432, 106);
            this.lblRadam.Name = "lblRadam";
            this.lblRadam.Size = new System.Drawing.Size(13, 13);
            this.lblRadam.TabIndex = 5;
            this.lblRadam.Text = "1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Frame_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Random:";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRadam);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.picFrame);
            this.MaximizeBox = false;
            this.Name = "TestForm";
            this.Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFrame;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnVideoSave;
        private System.Windows.Forms.Button btnVideoStop;
        private System.Windows.Forms.Button btnVideoPlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label lblRadam;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
    }
}
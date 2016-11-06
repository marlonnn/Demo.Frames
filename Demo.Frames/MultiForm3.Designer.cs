using System;
using System.Windows.Forms;

namespace Demo.Frames
{
    partial class MultiForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiForm3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFps = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxPanel1 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel2 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel3 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel4 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel5 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel6 = new Demo.Frames.PictureBoxPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 593);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(22, 230);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 21);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(22, 176);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 21);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(22, 126);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 21);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFps);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.hScrollBar);
            this.groupBox2.Location = new System.Drawing.Point(6, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 48);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // lblFps
            // 
            this.lblFps.AutoSize = true;
            this.lblFps.Location = new System.Drawing.Point(34, 12);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(11, 12);
            this.lblFps.TabIndex = 4;
            this.lblFps.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "FPS:";
            // 
            // hScrollBar
            // 
            this.hScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar.Location = new System.Drawing.Point(3, 28);
            this.hScrollBar.Maximum = 50;
            this.hScrollBar.Minimum = 1;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(115, 17);
            this.hScrollBar.TabIndex = 0;
            this.hScrollBar.Value = 5;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscrFps_Scroll);
            // 
            // pictureBoxPanel1
            // 
            this.pictureBoxPanel1.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel1.Frames")));
            this.pictureBoxPanel1.Location = new System.Drawing.Point(156, 6);
            this.pictureBoxPanel1.Name = "pictureBoxPanel1";
            this.pictureBoxPanel1.PlayTimer = null;
            this.pictureBoxPanel1.Size = new System.Drawing.Size(295, 295);
            this.pictureBoxPanel1.TabIndex = 13;
            // 
            // pictureBoxPanel2
            // 
            this.pictureBoxPanel2.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel2.Frames")));
            this.pictureBoxPanel2.Location = new System.Drawing.Point(457, 6);
            this.pictureBoxPanel2.Name = "pictureBoxPanel2";
            this.pictureBoxPanel2.PlayTimer = null;
            this.pictureBoxPanel2.Size = new System.Drawing.Size(295, 295);
            this.pictureBoxPanel2.TabIndex = 14;
            // 
            // pictureBoxPanel3
            // 
            this.pictureBoxPanel3.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel3.Frames")));
            this.pictureBoxPanel3.Location = new System.Drawing.Point(758, 6);
            this.pictureBoxPanel3.Name = "pictureBoxPanel3";
            this.pictureBoxPanel3.PlayTimer = null;
            this.pictureBoxPanel3.Size = new System.Drawing.Size(295, 295);
            this.pictureBoxPanel3.TabIndex = 15;
            // 
            // pictureBoxPanel4
            // 
            this.pictureBoxPanel4.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel4.Frames")));
            this.pictureBoxPanel4.Location = new System.Drawing.Point(156, 307);
            this.pictureBoxPanel4.Name = "pictureBoxPanel4";
            this.pictureBoxPanel4.PlayTimer = null;
            this.pictureBoxPanel4.Size = new System.Drawing.Size(295, 295);
            this.pictureBoxPanel4.TabIndex = 16;
            // 
            // pictureBoxPanel5
            // 
            this.pictureBoxPanel5.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel5.Frames")));
            this.pictureBoxPanel5.Location = new System.Drawing.Point(457, 307);
            this.pictureBoxPanel5.Name = "pictureBoxPanel5";
            this.pictureBoxPanel5.PlayTimer = null;
            this.pictureBoxPanel5.Size = new System.Drawing.Size(295, 295);
            this.pictureBoxPanel5.TabIndex = 17;
            // 
            // pictureBoxPanel6
            // 
            this.pictureBoxPanel6.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel6.Frames")));
            this.pictureBoxPanel6.Location = new System.Drawing.Point(758, 307);
            this.pictureBoxPanel6.Name = "pictureBoxPanel6";
            this.pictureBoxPanel6.PlayTimer = null;
            this.pictureBoxPanel6.Size = new System.Drawing.Size(295, 295);
            this.pictureBoxPanel6.TabIndex = 18;
            // 
            // MultiForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 626);
            this.Controls.Add(this.pictureBoxPanel6);
            this.Controls.Add(this.pictureBoxPanel5);
            this.Controls.Add(this.pictureBoxPanel4);
            this.Controls.Add(this.pictureBoxPanel3);
            this.Controls.Add(this.pictureBoxPanel2);
            this.Controls.Add(this.pictureBoxPanel1);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "MultiForm3";
            this.Text = "MultiForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.Label label1;
        private Timer timer;
        private PictureBoxPanel pictureBoxPanel1;
        private PictureBoxPanel pictureBoxPanel2;
        private PictureBoxPanel pictureBoxPanel3;
        private PictureBoxPanel pictureBoxPanel4;
        private PictureBoxPanel pictureBoxPanel5;
        private PictureBoxPanel pictureBoxPanel6;
    }
}
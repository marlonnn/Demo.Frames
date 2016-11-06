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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFps = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.playPanel4 = new Demo.Frames.PictureBoxPanel();
            this.playPanel3 = new Demo.Frames.PictureBoxPanel();
            this.playPanel2 = new Demo.Frames.PictureBoxPanel();
            this.playPanel1 = new Demo.Frames.PictureBoxPanel();
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            // playPanel4
            // 
            this.playPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel4.Frames = null;
            this.playPanel4.Location = new System.Drawing.Point(142, 236);
            this.playPanel4.Name = "playPanel4";
            this.playPanel4.PlayTimer = null;
            this.playPanel4.Size = new System.Drawing.Size(189, 175);
            this.playPanel4.TabIndex = 3;
            // 
            // playPanel3
            // 
            this.playPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel3.Frames = null;
            this.playPanel3.Location = new System.Drawing.Point(622, 11);
            this.playPanel3.Name = "playPanel3";
            this.playPanel3.PlayTimer = null;
            this.playPanel3.Size = new System.Drawing.Size(189, 175);
            this.playPanel3.TabIndex = 2;
            // 
            // playPanel2
            // 
            this.playPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel2.Frames = null;
            this.playPanel2.Location = new System.Drawing.Point(382, 11);
            this.playPanel2.Name = "playPanel2";
            this.playPanel2.PlayTimer = null;
            this.playPanel2.Size = new System.Drawing.Size(189, 175);
            this.playPanel2.TabIndex = 1;
            // 
            // playPanel1
            // 
            this.playPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel1.Frames = null;
            this.playPanel1.Location = new System.Drawing.Point(142, 11);
            this.playPanel1.Name = "playPanel1";
            this.playPanel1.PlayTimer = null;
            this.playPanel1.Size = new System.Drawing.Size(189, 175);
            this.playPanel1.TabIndex = 0;
            // 
            // MultiForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playPanel4);
            this.Controls.Add(this.playPanel3);
            this.Controls.Add(this.playPanel2);
            this.Controls.Add(this.playPanel1);
            this.MinimizeBox = false;
            this.Name = "MultiForm3";
            this.Text = "MultiForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private PictureBoxPanel playPanel1;
        private PictureBoxPanel playPanel2;
        private PictureBoxPanel playPanel3;
        private PictureBoxPanel playPanel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.Label label1;
        private Timer timer;
    }
}
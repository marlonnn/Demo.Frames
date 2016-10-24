using System;
using System.Windows.Forms;

namespace Demo.Frames
{
    partial class MultiForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFps = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.playPanel12 = new Demo.Frames.PlayPanel();
            this.playPanel11 = new Demo.Frames.PlayPanel();
            this.playPanel10 = new Demo.Frames.PlayPanel();
            this.playPanel9 = new Demo.Frames.PlayPanel();
            this.playPanel8 = new Demo.Frames.PlayPanel();
            this.playPanel7 = new Demo.Frames.PlayPanel();
            this.playPanel6 = new Demo.Frames.PlayPanel();
            this.playPanel5 = new Demo.Frames.PlayPanel();
            this.playPanel4 = new Demo.Frames.PlayPanel();
            this.playPanel3 = new Demo.Frames.PlayPanel();
            this.playPanel2 = new Demo.Frames.PlayPanel();
            this.playPanel1 = new Demo.Frames.PlayPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFps);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 642);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // lblFps
            // 
            this.lblFps.AutoSize = true;
            this.lblFps.Location = new System.Drawing.Point(53, 224);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(13, 13);
            this.lblFps.TabIndex = 4;
            this.lblFps.Text = "5";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(23, 131);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(23, 73);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(23, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.hScrollBar);
            this.groupBox2.Location = new System.Drawing.Point(5, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 52);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FPS:";
            // 
            // hScrollBar
            // 
            this.hScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar.Location = new System.Drawing.Point(3, 32);
            this.hScrollBar.Maximum = 30;
            this.hScrollBar.Minimum = 1;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(115, 17);
            this.hScrollBar.TabIndex = 0;
            this.hScrollBar.Value = 5;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscrFps_Scroll);
            // 
            // playPanel12
            // 
            this.playPanel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel12.Frames = null;
            this.playPanel12.Location = new System.Drawing.Point(862, 440);
            this.playPanel12.Name = "playPanel12";
            this.playPanel12.Size = new System.Drawing.Size(234, 208);
            this.playPanel12.TabIndex = 11;
            // 
            // playPanel11
            // 
            this.playPanel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel11.Frames = null;
            this.playPanel11.Location = new System.Drawing.Point(622, 440);
            this.playPanel11.Name = "playPanel11";
            this.playPanel11.Size = new System.Drawing.Size(234, 208);
            this.playPanel11.TabIndex = 10;
            // 
            // playPanel10
            // 
            this.playPanel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel10.Frames = null;
            this.playPanel10.Location = new System.Drawing.Point(382, 440);
            this.playPanel10.Name = "playPanel10";
            this.playPanel10.Size = new System.Drawing.Size(234, 208);
            this.playPanel10.TabIndex = 9;
            // 
            // playPanel9
            // 
            this.playPanel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel9.Frames = null;
            this.playPanel9.Location = new System.Drawing.Point(142, 440);
            this.playPanel9.Name = "playPanel9";
            this.playPanel9.Size = new System.Drawing.Size(234, 208);
            this.playPanel9.TabIndex = 8;
            // 
            // playPanel8
            // 
            this.playPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel8.Frames = null;
            this.playPanel8.Location = new System.Drawing.Point(862, 226);
            this.playPanel8.Name = "playPanel8";
            this.playPanel8.Size = new System.Drawing.Size(234, 208);
            this.playPanel8.TabIndex = 7;
            // 
            // playPanel7
            // 
            this.playPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel7.Frames = null;
            this.playPanel7.Location = new System.Drawing.Point(622, 226);
            this.playPanel7.Name = "playPanel7";
            this.playPanel7.Size = new System.Drawing.Size(234, 208);
            this.playPanel7.TabIndex = 6;
            // 
            // playPanel6
            // 
            this.playPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel6.Frames = null;
            this.playPanel6.Location = new System.Drawing.Point(382, 226);
            this.playPanel6.Name = "playPanel6";
            this.playPanel6.Size = new System.Drawing.Size(234, 208);
            this.playPanel6.TabIndex = 5;
            // 
            // playPanel5
            // 
            this.playPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel5.Frames = null;
            this.playPanel5.Location = new System.Drawing.Point(142, 226);
            this.playPanel5.Name = "playPanel5";
            this.playPanel5.Size = new System.Drawing.Size(234, 208);
            this.playPanel5.TabIndex = 4;
            // 
            // playPanel4
            // 
            this.playPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel4.Frames = null;
            this.playPanel4.Location = new System.Drawing.Point(862, 12);
            this.playPanel4.Name = "playPanel4";
            this.playPanel4.Size = new System.Drawing.Size(234, 208);
            this.playPanel4.TabIndex = 3;
            // 
            // playPanel3
            // 
            this.playPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel3.Frames = null;
            this.playPanel3.Location = new System.Drawing.Point(622, 12);
            this.playPanel3.Name = "playPanel3";
            this.playPanel3.Size = new System.Drawing.Size(234, 208);
            this.playPanel3.TabIndex = 2;
            // 
            // playPanel2
            // 
            this.playPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel2.Frames = null;
            this.playPanel2.Location = new System.Drawing.Point(382, 12);
            this.playPanel2.Name = "playPanel2";
            this.playPanel2.Size = new System.Drawing.Size(234, 208);
            this.playPanel2.TabIndex = 1;
            // 
            // playPanel1
            // 
            this.playPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playPanel1.Frames = null;
            this.playPanel1.Location = new System.Drawing.Point(142, 12);
            this.playPanel1.Name = "playPanel1";
            this.playPanel1.Size = new System.Drawing.Size(234, 208);
            this.playPanel1.TabIndex = 0;
            // 
            // MultiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 654);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playPanel12);
            this.Controls.Add(this.playPanel11);
            this.Controls.Add(this.playPanel10);
            this.Controls.Add(this.playPanel9);
            this.Controls.Add(this.playPanel8);
            this.Controls.Add(this.playPanel7);
            this.Controls.Add(this.playPanel6);
            this.Controls.Add(this.playPanel5);
            this.Controls.Add(this.playPanel4);
            this.Controls.Add(this.playPanel3);
            this.Controls.Add(this.playPanel2);
            this.Controls.Add(this.playPanel1);
            this.MinimizeBox = false;
            this.Name = "MultiForm";
            this.Text = "MultiForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private PlayPanel playPanel1;
        private PlayPanel playPanel2;
        private PlayPanel playPanel3;
        private PlayPanel playPanel4;
        private PlayPanel playPanel5;
        private PlayPanel playPanel6;
        private PlayPanel playPanel7;
        private PlayPanel playPanel8;
        private PlayPanel playPanel9;
        private PlayPanel playPanel10;
        private PlayPanel playPanel11;
        private PlayPanel playPanel12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.Label label1;
    }
}
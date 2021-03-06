﻿using System;
using System.Windows.Forms;

namespace Demo.Frames
{
    partial class MultiForm6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiForm6));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFast = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnLow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxPanel1 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel2 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel3 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel4 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel5 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel6 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel7 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel8 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel9 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel10 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel11 = new Demo.Frames.PictureBoxPanel();
            this.pictureBoxPanel12 = new Demo.Frames.PictureBoxPanel();
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
            this.groupBox1.Size = new System.Drawing.Size(132, 762);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(22, 379);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 21);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(22, 325);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 21);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(22, 275);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 21);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFast);
            this.groupBox2.Controls.Add(this.btnNormal);
            this.groupBox2.Controls.Add(this.btnLow);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 186);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnFast
            // 
            this.btnFast.Location = new System.Drawing.Point(16, 130);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(75, 21);
            this.btnFast.TabIndex = 8;
            this.btnFast.Text = "Fast";
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(16, 86);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 21);
            this.btnNormal.TabIndex = 7;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnLow
            // 
            this.btnLow.Location = new System.Drawing.Point(16, 41);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(75, 21);
            this.btnLow.TabIndex = 6;
            this.btnLow.Text = "Low";
            this.btnLow.UseVisualStyleBackColor = true;
            this.btnLow.Click += new System.EventHandler(this.btnLow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "FPS Speed:";
            // 
            // pictureBoxPanel1
            // 
            this.pictureBoxPanel1.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel1.Frames")));
            this.pictureBoxPanel1.Location = new System.Drawing.Point(142, 17);
            this.pictureBoxPanel1.Name = "pictureBoxPanel1";
            this.pictureBoxPanel1.PlayTimer = null;
            this.pictureBoxPanel1.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPanel1.TabIndex = 13;
            // 
            // pictureBoxPanel2
            // 
            this.pictureBoxPanel2.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel2.Frames")));
            this.pictureBoxPanel2.Location = new System.Drawing.Point(398, 17);
            this.pictureBoxPanel2.Name = "pictureBoxPanel2";
            this.pictureBoxPanel2.PlayTimer = null;
            this.pictureBoxPanel2.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPanel2.TabIndex = 14;
            // 
            // pictureBoxPanel3
            // 
            this.pictureBoxPanel3.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel3.Frames")));
            this.pictureBoxPanel3.Location = new System.Drawing.Point(654, 17);
            this.pictureBoxPanel3.Name = "pictureBoxPanel3";
            this.pictureBoxPanel3.PlayTimer = null;
            this.pictureBoxPanel3.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPanel3.TabIndex = 15;
            // 
            // pictureBoxPanel4
            // 
            this.pictureBoxPanel4.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel4.Frames")));
            this.pictureBoxPanel4.Location = new System.Drawing.Point(910, 17);
            this.pictureBoxPanel4.Name = "pictureBoxPanel4";
            this.pictureBoxPanel4.PlayTimer = null;
            this.pictureBoxPanel4.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPanel4.TabIndex = 16;
            // 
            // pictureBoxPanel5
            // 
            this.pictureBoxPanel5.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel5.Frames")));
            this.pictureBoxPanel5.Location = new System.Drawing.Point(142, 273);
            this.pictureBoxPanel5.Name = "pictureBoxPanel5";
            this.pictureBoxPanel5.PlayTimer = null;
            this.pictureBoxPanel5.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPanel5.TabIndex = 17;
            // 
            // pictureBoxPanel6
            // 
            this.pictureBoxPanel6.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel6.Frames")));
            this.pictureBoxPanel6.Location = new System.Drawing.Point(398, 273);
            this.pictureBoxPanel6.Name = "pictureBoxPanel6";
            this.pictureBoxPanel6.PlayTimer = null;
            this.pictureBoxPanel6.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPanel6.TabIndex = 18;
            // 
            // pictureBoxPanel7
            // 
            this.pictureBoxPanel7.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel7.Frames")));
            this.pictureBoxPanel7.Location = new System.Drawing.Point(654, 273);
            this.pictureBoxPanel7.Name = "pictureBoxPanel7";
            this.pictureBoxPanel7.PlayTimer = null;
            this.pictureBoxPanel7.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPanel7.TabIndex = 19;
            // 
            // pictureBoxPanel8
            // 
            this.pictureBoxPanel8.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel8.Frames")));
            this.pictureBoxPanel8.Location = new System.Drawing.Point(910, 273);
            this.pictureBoxPanel8.Name = "pictureBoxPanel8";
            this.pictureBoxPanel8.PlayTimer = null;
            this.pictureBoxPanel8.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPanel8.TabIndex = 20;
            // 
            // pictureBoxPanel9
            // 
            this.pictureBoxPanel9.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel9.Frames")));
            this.pictureBoxPanel9.Location = new System.Drawing.Point(142, 529);
            this.pictureBoxPanel9.Name = "pictureBoxPanel9";
            this.pictureBoxPanel9.PlayTimer = null;
            this.pictureBoxPanel9.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPanel9.TabIndex = 21;
            // 
            // pictureBoxPanel10
            // 
            this.pictureBoxPanel10.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel10.Frames")));
            this.pictureBoxPanel10.Location = new System.Drawing.Point(398, 529);
            this.pictureBoxPanel10.Name = "pictureBoxPanel10";
            this.pictureBoxPanel10.PlayTimer = null;
            this.pictureBoxPanel10.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPanel10.TabIndex = 22;
            // 
            // pictureBoxPanel11
            // 
            this.pictureBoxPanel11.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel11.Frames")));
            this.pictureBoxPanel11.Location = new System.Drawing.Point(654, 529);
            this.pictureBoxPanel11.Name = "pictureBoxPanel11";
            this.pictureBoxPanel11.PlayTimer = null;
            this.pictureBoxPanel11.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPanel11.TabIndex = 23;
            // 
            // pictureBoxPanel12
            // 
            this.pictureBoxPanel12.Frames = ((System.Collections.Generic.List<Demo.Frames.Frame>)(resources.GetObject("pictureBoxPanel12.Frames")));
            this.pictureBoxPanel12.Location = new System.Drawing.Point(910, 529);
            this.pictureBoxPanel12.Name = "pictureBoxPanel12";
            this.pictureBoxPanel12.PlayTimer = null;
            this.pictureBoxPanel12.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPanel12.TabIndex = 24;
            // 
            // MultiForm6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 796);
            this.Controls.Add(this.pictureBoxPanel12);
            this.Controls.Add(this.pictureBoxPanel11);
            this.Controls.Add(this.pictureBoxPanel10);
            this.Controls.Add(this.pictureBoxPanel9);
            this.Controls.Add(this.pictureBoxPanel8);
            this.Controls.Add(this.pictureBoxPanel7);
            this.Controls.Add(this.pictureBoxPanel6);
            this.Controls.Add(this.pictureBoxPanel5);
            this.Controls.Add(this.pictureBoxPanel4);
            this.Controls.Add(this.pictureBoxPanel3);
            this.Controls.Add(this.pictureBoxPanel2);
            this.Controls.Add(this.pictureBoxPanel1);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "MultiForm6";
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private Timer timer;
        private Button btnFast;
        private Button btnNormal;
        private Button btnLow;
        private PictureBoxPanel pictureBoxPanel1;
        private PictureBoxPanel pictureBoxPanel2;
        private PictureBoxPanel pictureBoxPanel3;
        private PictureBoxPanel pictureBoxPanel4;
        private PictureBoxPanel pictureBoxPanel5;
        private PictureBoxPanel pictureBoxPanel6;
        private PictureBoxPanel pictureBoxPanel7;
        private PictureBoxPanel pictureBoxPanel8;
        private PictureBoxPanel pictureBoxPanel9;
        private PictureBoxPanel pictureBoxPanel10;
        private PictureBoxPanel pictureBoxPanel11;
        private PictureBoxPanel pictureBoxPanel12;
    }
}
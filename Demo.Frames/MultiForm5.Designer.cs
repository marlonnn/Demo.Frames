using System;
using System.Windows.Forms;

namespace Demo.Frames
{
    partial class MultiForm5
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.imageBox1 = new Cyotek.Windows.Forms.ImageBox();
            this.imageBox2 = new Cyotek.Windows.Forms.ImageBox();
            this.imageBox3 = new Cyotek.Windows.Forms.ImageBox();
            this.imageBox4 = new Cyotek.Windows.Forms.ImageBox();
            this.imageBox5 = new Cyotek.Windows.Forms.ImageBox();
            this.imageBox6 = new Cyotek.Windows.Forms.ImageBox();
            this.imageBox7 = new Cyotek.Windows.Forms.ImageBox();
            this.imageBox8 = new Cyotek.Windows.Forms.ImageBox();
            this.imageBox9 = new Cyotek.Windows.Forms.ImageBox();
            this.imageBox10 = new Cyotek.Windows.Forms.ImageBox();
            this.imageBox11 = new Cyotek.Windows.Forms.ImageBox();
            this.imageBox12 = new Cyotek.Windows.Forms.ImageBox();
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
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(151, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(250, 250);
            this.imageBox1.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Stretch;
            this.imageBox1.TabIndex = 13;
            // 
            // imageBox2
            // 
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.Location = new System.Drawing.Point(407, 12);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(250, 250);
            this.imageBox2.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Stretch;
            this.imageBox2.TabIndex = 14;
            // 
            // imageBox3
            // 
            this.imageBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox3.Location = new System.Drawing.Point(663, 12);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(250, 250);
            this.imageBox3.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Stretch;
            this.imageBox3.TabIndex = 15;
            // 
            // imageBox4
            // 
            this.imageBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox4.Location = new System.Drawing.Point(919, 12);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(250, 250);
            this.imageBox4.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Stretch;
            this.imageBox4.TabIndex = 16;
            // 
            // imageBox5
            // 
            this.imageBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox5.Location = new System.Drawing.Point(151, 268);
            this.imageBox5.Name = "imageBox5";
            this.imageBox5.Size = new System.Drawing.Size(250, 250);
            this.imageBox5.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Stretch;
            this.imageBox5.TabIndex = 17;
            // 
            // imageBox6
            // 
            this.imageBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox6.Location = new System.Drawing.Point(407, 268);
            this.imageBox6.Name = "imageBox6";
            this.imageBox6.Size = new System.Drawing.Size(250, 250);
            this.imageBox6.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Stretch;
            this.imageBox6.TabIndex = 18;
            // 
            // imageBox7
            // 
            this.imageBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox7.Location = new System.Drawing.Point(663, 268);
            this.imageBox7.Name = "imageBox7";
            this.imageBox7.Size = new System.Drawing.Size(250, 250);
            this.imageBox7.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Stretch;
            this.imageBox7.TabIndex = 19;
            // 
            // imageBox8
            // 
            this.imageBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox8.Location = new System.Drawing.Point(919, 268);
            this.imageBox8.Name = "imageBox8";
            this.imageBox8.Size = new System.Drawing.Size(250, 250);
            this.imageBox8.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Stretch;
            this.imageBox8.TabIndex = 20;
            // 
            // imageBox9
            // 
            this.imageBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox9.Location = new System.Drawing.Point(151, 524);
            this.imageBox9.Name = "imageBox9";
            this.imageBox9.Size = new System.Drawing.Size(250, 250);
            this.imageBox9.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Stretch;
            this.imageBox9.TabIndex = 21;
            // 
            // imageBox10
            // 
            this.imageBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox10.Location = new System.Drawing.Point(407, 524);
            this.imageBox10.Name = "imageBox10";
            this.imageBox10.Size = new System.Drawing.Size(250, 250);
            this.imageBox10.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Stretch;
            this.imageBox10.TabIndex = 22;
            // 
            // imageBox11
            // 
            this.imageBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox11.Location = new System.Drawing.Point(663, 524);
            this.imageBox11.Name = "imageBox11";
            this.imageBox11.Size = new System.Drawing.Size(250, 250);
            this.imageBox11.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Stretch;
            this.imageBox11.TabIndex = 23;
            // 
            // imageBox12
            // 
            this.imageBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox12.Location = new System.Drawing.Point(919, 524);
            this.imageBox12.Name = "imageBox12";
            this.imageBox12.Size = new System.Drawing.Size(250, 250);
            this.imageBox12.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Stretch;
            this.imageBox12.TabIndex = 24;
            // 
            // MultiForm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 796);
            this.Controls.Add(this.imageBox12);
            this.Controls.Add(this.imageBox11);
            this.Controls.Add(this.imageBox10);
            this.Controls.Add(this.imageBox9);
            this.Controls.Add(this.imageBox8);
            this.Controls.Add(this.imageBox7);
            this.Controls.Add(this.imageBox6);
            this.Controls.Add(this.imageBox5);
            this.Controls.Add(this.imageBox4);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "MultiForm5";
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
        private Cyotek.Windows.Forms.ImageBox imageBox1;
        private Cyotek.Windows.Forms.ImageBox imageBox2;
        private Cyotek.Windows.Forms.ImageBox imageBox3;
        private Cyotek.Windows.Forms.ImageBox imageBox4;
        private Cyotek.Windows.Forms.ImageBox imageBox5;
        private Cyotek.Windows.Forms.ImageBox imageBox6;
        private Cyotek.Windows.Forms.ImageBox imageBox7;
        private Cyotek.Windows.Forms.ImageBox imageBox8;
        private Cyotek.Windows.Forms.ImageBox imageBox9;
        private Cyotek.Windows.Forms.ImageBox imageBox10;
        private Cyotek.Windows.Forms.ImageBox imageBox11;
        private Cyotek.Windows.Forms.ImageBox imageBox12;
    }
}
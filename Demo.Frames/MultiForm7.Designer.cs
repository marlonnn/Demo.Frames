using System;
using System.Windows.Forms;

namespace Demo.Frames
{
    partial class MultiForm7
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFast = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnLow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressPanel = new Demo.Frames.ProgressPanel();
            this.richImageBox12 = new Demo.Frames.RichImageBox();
            this.richImageBox11 = new Demo.Frames.RichImageBox();
            this.richImageBox10 = new Demo.Frames.RichImageBox();
            this.richImageBox9 = new Demo.Frames.RichImageBox();
            this.richImageBox8 = new Demo.Frames.RichImageBox();
            this.richImageBox7 = new Demo.Frames.RichImageBox();
            this.richImageBox6 = new Demo.Frames.RichImageBox();
            this.richImageBox5 = new Demo.Frames.RichImageBox();
            this.richImageBox4 = new Demo.Frames.RichImageBox();
            this.richImageBox3 = new Demo.Frames.RichImageBox();
            this.richImageBox2 = new Demo.Frames.RichImageBox();
            this.richImageBox1 = new Demo.Frames.RichImageBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressPanel);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 762);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFast);
            this.groupBox2.Controls.Add(this.btnNormal);
            this.groupBox2.Controls.Add(this.btnLow);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 186);
            this.groupBox2.TabIndex = 6;
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
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(22, 150);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 21);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(22, 90);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 21);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(22, 34);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 21);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // progressPanel
            // 
            this.progressPanel.Location = new System.Drawing.Point(8, 537);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(126, 32);
            this.progressPanel.TabIndex = 17;
            // 
            // richImageBox12
            // 
            this.richImageBox12.Bitmap = null;
            this.richImageBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richImageBox12.ImagePath = null;
            this.richImageBox12.Location = new System.Drawing.Point(1060, 571);
            this.richImageBox12.Name = "richImageBox12";
            this.richImageBox12.Position = Demo.Frames.RichImageBox.AnchorPosition.Top;
            this.richImageBox12.Size = new System.Drawing.Size(300, 277);
            this.richImageBox12.TabIndex = 24;
            // 
            // richImageBox11
            // 
            this.richImageBox11.Bitmap = null;
            this.richImageBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richImageBox11.ImagePath = null;
            this.richImageBox11.Location = new System.Drawing.Point(754, 571);
            this.richImageBox11.Name = "richImageBox11";
            this.richImageBox11.Position = Demo.Frames.RichImageBox.AnchorPosition.Top;
            this.richImageBox11.Size = new System.Drawing.Size(300, 277);
            this.richImageBox11.TabIndex = 23;
            // 
            // richImageBox10
            // 
            this.richImageBox10.Bitmap = null;
            this.richImageBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richImageBox10.ImagePath = null;
            this.richImageBox10.Location = new System.Drawing.Point(448, 571);
            this.richImageBox10.Name = "richImageBox10";
            this.richImageBox10.Position = Demo.Frames.RichImageBox.AnchorPosition.Top;
            this.richImageBox10.Size = new System.Drawing.Size(300, 277);
            this.richImageBox10.TabIndex = 22;
            // 
            // richImageBox9
            // 
            this.richImageBox9.Bitmap = null;
            this.richImageBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richImageBox9.ImagePath = null;
            this.richImageBox9.Location = new System.Drawing.Point(142, 571);
            this.richImageBox9.Name = "richImageBox9";
            this.richImageBox9.Position = Demo.Frames.RichImageBox.AnchorPosition.Top;
            this.richImageBox9.Size = new System.Drawing.Size(300, 277);
            this.richImageBox9.TabIndex = 21;
            // 
            // richImageBox8
            // 
            this.richImageBox8.Bitmap = null;
            this.richImageBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richImageBox8.ImagePath = null;
            this.richImageBox8.Location = new System.Drawing.Point(1060, 289);
            this.richImageBox8.Name = "richImageBox8";
            this.richImageBox8.Position = Demo.Frames.RichImageBox.AnchorPosition.Top;
            this.richImageBox8.Size = new System.Drawing.Size(300, 277);
            this.richImageBox8.TabIndex = 20;
            // 
            // richImageBox7
            // 
            this.richImageBox7.Bitmap = null;
            this.richImageBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richImageBox7.ImagePath = null;
            this.richImageBox7.Location = new System.Drawing.Point(754, 289);
            this.richImageBox7.Name = "richImageBox7";
            this.richImageBox7.Position = Demo.Frames.RichImageBox.AnchorPosition.Top;
            this.richImageBox7.Size = new System.Drawing.Size(300, 277);
            this.richImageBox7.TabIndex = 19;
            // 
            // richImageBox6
            // 
            this.richImageBox6.Bitmap = null;
            this.richImageBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richImageBox6.ImagePath = null;
            this.richImageBox6.Location = new System.Drawing.Point(448, 289);
            this.richImageBox6.Name = "richImageBox6";
            this.richImageBox6.Position = Demo.Frames.RichImageBox.AnchorPosition.Top;
            this.richImageBox6.Size = new System.Drawing.Size(300, 277);
            this.richImageBox6.TabIndex = 18;
            // 
            // richImageBox5
            // 
            this.richImageBox5.Bitmap = null;
            this.richImageBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richImageBox5.ImagePath = null;
            this.richImageBox5.Location = new System.Drawing.Point(142, 289);
            this.richImageBox5.Name = "richImageBox5";
            this.richImageBox5.Position = Demo.Frames.RichImageBox.AnchorPosition.Top;
            this.richImageBox5.Size = new System.Drawing.Size(300, 277);
            this.richImageBox5.TabIndex = 17;
            // 
            // richImageBox4
            // 
            this.richImageBox4.Bitmap = null;
            this.richImageBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richImageBox4.ImagePath = null;
            this.richImageBox4.Location = new System.Drawing.Point(1060, 6);
            this.richImageBox4.Name = "richImageBox4";
            this.richImageBox4.Position = Demo.Frames.RichImageBox.AnchorPosition.Top;
            this.richImageBox4.Size = new System.Drawing.Size(300, 277);
            this.richImageBox4.TabIndex = 16;
            // 
            // richImageBox3
            // 
            this.richImageBox3.Bitmap = null;
            this.richImageBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richImageBox3.ImagePath = null;
            this.richImageBox3.Location = new System.Drawing.Point(754, 6);
            this.richImageBox3.Name = "richImageBox3";
            this.richImageBox3.Position = Demo.Frames.RichImageBox.AnchorPosition.Top;
            this.richImageBox3.Size = new System.Drawing.Size(300, 277);
            this.richImageBox3.TabIndex = 15;
            // 
            // richImageBox2
            // 
            this.richImageBox2.Bitmap = null;
            this.richImageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richImageBox2.ImagePath = null;
            this.richImageBox2.Location = new System.Drawing.Point(448, 6);
            this.richImageBox2.Name = "richImageBox2";
            this.richImageBox2.Position = Demo.Frames.RichImageBox.AnchorPosition.Top;
            this.richImageBox2.Size = new System.Drawing.Size(300, 277);
            this.richImageBox2.TabIndex = 14;
            // 
            // richImageBox1
            // 
            this.richImageBox1.Bitmap = null;
            this.richImageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richImageBox1.ImagePath = null;
            this.richImageBox1.Location = new System.Drawing.Point(142, 6);
            this.richImageBox1.Name = "richImageBox1";
            this.richImageBox1.Position = Demo.Frames.RichImageBox.AnchorPosition.Top;
            this.richImageBox1.Size = new System.Drawing.Size(300, 277);
            this.richImageBox1.TabIndex = 13;
            // 
            // MultiForm7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 796);
            this.Controls.Add(this.richImageBox12);
            this.Controls.Add(this.richImageBox11);
            this.Controls.Add(this.richImageBox10);
            this.Controls.Add(this.richImageBox9);
            this.Controls.Add(this.richImageBox8);
            this.Controls.Add(this.richImageBox7);
            this.Controls.Add(this.richImageBox6);
            this.Controls.Add(this.richImageBox5);
            this.Controls.Add(this.richImageBox4);
            this.Controls.Add(this.richImageBox3);
            this.Controls.Add(this.richImageBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richImageBox1);
            this.MinimizeBox = false;
            this.Name = "MultiForm7";
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
        private Timer timer;
        private RichImageBox richImageBox1;
        private RichImageBox richImageBox2;
        private RichImageBox richImageBox3;
        private RichImageBox richImageBox4;
        private RichImageBox richImageBox5;
        private RichImageBox richImageBox6;
        private RichImageBox richImageBox7;
        private RichImageBox richImageBox8;
        private RichImageBox richImageBox9;
        private RichImageBox richImageBox10;
        private RichImageBox richImageBox11;
        private RichImageBox richImageBox12;
        private GroupBox groupBox2;
        private Button btnFast;
        private Button btnNormal;
        private Button btnLow;
        private Label label1;
        private ProgressPanel progressPanel;
    }
}
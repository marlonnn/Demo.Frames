using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.Frames
{
    public partial class PictureBoxPanel1 : UserControl
    {
        private Object thisLock = new Object();

        public PictureBox PictureBox
        {
            get { return this.pictureBox; }
            set
            {
                this.pictureBox = value;
            }
        }

        public PictureBoxPanel1()
        {
            InitializeComponent();
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Size = new System.Drawing.Size(this.Width, this.Height);
            //this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        protected override void OnResize(EventArgs e)
        {
            this.Width = this.Height;
            this.pictureBox.Width = this.Width;
            this.pictureBox.Height = this.Width;
        }
    }
}

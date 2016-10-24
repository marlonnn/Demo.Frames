using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.Frames
{
    public partial class TestForm : Form
    {
        private Object thisLock = new Object();

        private List<Frame> _frames;

        private List<Frame> Frames
        {
            get
            {
                return this._frames;
            }
            set
            {
                lock (thisLock)
                {
                    _frames = value;
                }
            }
        }
        private int _currentNumber;
        public TestForm()
        {
            InitializeComponent();
            _frames = new List<Frame>();
            _currentNumber = 0;
            this.picFrame.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void hscrFps_Scroll(object sender, ScrollEventArgs e)
        {
            timer.Interval = 1000 / hScrollBar.Value;
            lblFps.Text = hScrollBar.Value.ToString();
        }

        private void TraceBar_ValueChanged(object sender, EventArgs e)
        {
            int value = this.trackBar.Value;
            long tick = DateTime.Now.Ticks;
            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));

            Random random = new Random();
            this.lblRadam.Text = ran.Next(1, 5).ToString();
            Frames = GetFrames(this.lblRadam.Text);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                _frames.Clear();
                ofd.InitialDirectory = System.Environment.CurrentDirectory + "\\Images";
                ofd.Multiselect = true;
                ofd.Filter = "All Files|*.*|Image Files|*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in ofd.FileNames)
                    {
                        _frames.Add(new Frame(fileName, ""));
                    }
                }
            }
        }

        private void btnVideoPlay_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = true;
            if (this._frames != null && this._frames.Count > 0)
            {

            }

        }

        private void btnVideoStop_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = false;
        }

        private void Frame_Tick(object sender, EventArgs e)
        {
            if (this._frames != null && this._frames.Count > 0)
            {
                _currentNumber = ++_currentNumber % _frames.Count;
                picFrame.ImageLocation = _frames[_currentNumber].FileFullName;
            }
        }


        private List<Frame> GetFrames(string index)
        {
            List<Frame> frames = new List<Frame>();
            string folder = System.Environment.CurrentDirectory + "\\Frames" + index;
            DirectoryInfo dir = new DirectoryInfo(folder);
            FileInfo[] fileInfo = dir.GetFiles();
            Array.Sort(fileInfo, delegate (FileInfo x, FileInfo y) 
            {
                return Int32.Parse(Path.GetFileNameWithoutExtension(x.Name)).CompareTo
                (Int32.Parse(Path.GetFileNameWithoutExtension(y.Name)));
            });
            foreach (FileInfo info in fileInfo)
            {
                var v = Path.GetFileNameWithoutExtension(info.Name);
                Frame frame = new Frame(info.FullName, folder);
                frames.Add(frame);
            }
            return frames;
        }
    }
}

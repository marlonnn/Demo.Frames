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
        private List<Frame> _frames;
        private int _currentNumber;
        public TestForm()
        {
            InitializeComponent();
            _frames = new List<Frame>();
            _currentNumber = 0;
        }

        private void hscrFps_Scroll(object sender, ScrollEventArgs e)
        {
            timer.Interval = 1000 / hScrollBar.Value;
            lblFps.Text = hScrollBar.Value.ToString();
        }

        private void TraceBar_ValueChanged(object sender, EventArgs e)
        {
            var value = this.trackBar.Value;
            if (value > 0)
            {

            }
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
    }

    public class Frame
    {
        private string _fileFullName;

        private string _folder;

        public string FileFullName
        {
            get
            {
                return this._fileFullName;
            }
            set
            {
                this._fileFullName = value;
            }
        }

        public string Folder
        {
            get
            {
                return this._folder;
            }
            set
            {
                this._folder = value;
            }
        }

        public Frame(string fileFullName, string folder)
        {
            this._fileFullName = fileFullName;
            this._folder = folder;
        }
    }
}

using Cyotek.Windows.Forms;
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
    public partial class MultiForm7 : Form
    {

        private List<RichImageBox> _imageBoxs;

        private List<Frame> _frames;

        private int _currentNumber;

        public MultiForm7()
        {
            InitializeComponent();
            _frames = new List<Frame>();
            _imageBoxs = new List<RichImageBox>();
            InitializePlayPanels();
            this.timer.Interval = 200;
            this.timer.Tick += PlayTimer_Tick;
        }

        public void InitializePlayPanels()
        {
            foreach (var control in this.Controls)
            {
                RichImageBox playPanel = control as RichImageBox;
                if (playPanel != null)
                {
                    this._imageBoxs.Add(playPanel);
                }
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                ofd.Description = "请选择将要播放帧图的文件夹";
                ofd.RootFolder = Environment.SpecialFolder.Desktop;
                ofd.SelectedPath = System.Environment.CurrentDirectory + "\\Images";

                _frames.Clear();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileFolder = ofd.SelectedPath;
                    DirectoryInfo folder = new DirectoryInfo(fileFolder);
                    try
                    {
                        FileInfo[] fileInfos = folder.GetFiles();
                        Array.Sort(fileInfos, delegate (FileInfo x, FileInfo y)
                        {
                            return Int32.Parse(Path.GetFileNameWithoutExtension(x.Name)).CompareTo
                            (Int32.Parse(Path.GetFileNameWithoutExtension(y.Name)));
                        });
                        foreach (FileInfo info in fileInfos)
                        {
                            var v = Path.GetFileNameWithoutExtension(info.Name);
                            Frame frame = new Frame(info.FullName, fileFolder);
                            _frames.Add(frame);
                        }
                    }
                    catch (Exception ee)
                    {
                    }
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = true;
            this.timer.Interval = 200;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = false;
        }

        private void PlayTimer_Tick(object sender, EventArgs e)
        {
            var v = this.timer.Interval;
            if (this._frames != null && this._frames.Count > 0)
            {
                _currentNumber = ++_currentNumber % _frames.Count;
                //this.pictureBox.ImageLocation = _frames[_currentNumber].FileFullName;
                foreach (var imagebox in _imageBoxs)
                {
                    imagebox.ImagePath = this._frames[_currentNumber].FileFullName;
                }
            }
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.timer.Interval = 200;
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            this.timer.Interval = 500;
        }

        private void btnFast_Click(object sender, EventArgs e)
        {
            this.timer.Interval = 25;
        }
    }
}

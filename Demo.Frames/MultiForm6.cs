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
    public partial class MultiForm6 : Form
    {

        private List<PictureBoxPanel> _playPanels;

        private List<Frame> _frames;

        private int _currentNumber;

        public MultiForm6()
        {
            InitializeComponent();
            _frames = new List<Frame>();
            _playPanels = new List<PictureBoxPanel>();
            InitializePlayPanels();
        }

        public void InitializePlayPanels()
        {
            foreach (var control in this.Controls)
            {
                PictureBoxPanel playPanel = control as PictureBoxPanel;
                if (playPanel != null)
                {
                    this._playPanels.Add(playPanel);
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
            foreach (var playPanel in this._playPanels)
            {
                if (playPanel != null)
                {
                    playPanel.Frames = this._frames;
                    this.timer.Enabled = true;
                    this.timer.Interval = 200;
                    playPanel.PlayTimer = this.timer;
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = false;
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
            this.timer.Interval = 50;
        }
    }
}

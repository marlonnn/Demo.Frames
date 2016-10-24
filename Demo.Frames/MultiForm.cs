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
    public partial class MultiForm : Form
    {

        private List<PlayPanel> _playPanels;

        private List<Frame> _frames;

        public MultiForm()
        {
            InitializeComponent();
            _frames = new List<Frame>();
            _playPanels = new List<PlayPanel>();
            InitializePlayPanels();
        }

        public void InitializePlayPanels()
        {
            foreach (var control in this.Controls)
            {
                PlayPanel playPanel = control as PlayPanel;
                if (playPanel != null)
                {
                    playPanel.TraceBarChangedHandler += TraceBarChangedHandler;
                    this._playPanels.Add(playPanel);
                }
            }
        }

        private void TraceBarChangedHandler(PlayPanel playPanel, int value)
        {
            this._frames = GetFrames(value.ToString());
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                ofd.Description = "请选择将要播放帧图的文件夹";
                ofd.RootFolder = Environment.SpecialFolder.Desktop;
                ofd.SelectedPath = System.Environment.CurrentDirectory;

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
                    playPanel.Play(true);
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            foreach (var playPanel in this._playPanels)
            {
                if (playPanel != null)
                {
                    playPanel.Play(false);
                }
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

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
    public partial class MultiForm5 : Form
    {

        private List<ImageBox> _imageBoxs;

        private List<Frame> _frames;

        private int _currentNumber;

        public MultiForm5()
        {
            InitializeComponent();
            _frames = new List<Frame>();
            _imageBoxs = new List<ImageBox>();
            InitializePlayPanels();

            this.timer.Tick += PlayTimer_Tick;
        }

        public void InitializePlayPanels()
        {
            foreach (var control in this.Controls)
            {
                ImageBox playPanel = control as ImageBox;
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
            //foreach (var playPanel in this._imageBoxs)
            //{
            //    if (playPanel != null)
            //    {
            //        this.timer.Enabled = true;
            //        this.timer.Interval = 200;
            //        playPanel.PlayTimer = this.timer;
            //    }
            //}
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
                    //imagebox.ImageLocation = _frames[_currentNumber].FileFullName;
                    loadImage(_frames[_currentNumber].FileFullName, imagebox);
                }
            }
        }

        private void hscrFps_Scroll(object sender, ScrollEventArgs e)
        {
            //timer.Interval = 1000 / hScrollBar.Value;
            this.timer.Interval = 1000 / hScrollBar.Value;
            lblFps.Text = hScrollBar.Value.ToString();
        }

        private void loadImage(string path, ImageBox imageBox)
        {
            using (var srce = new Bitmap(path))
            {
                var dest = new Bitmap(imageBox.Width, imageBox.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                using (var gr = Graphics.FromImage(dest))
                {
                    gr.DrawImage(srce, new Rectangle(Point.Empty, dest.Size));
                }
                //if (pictureBox.Image != null) pictureBox.Dispose();
                imageBox.Image = dest;
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

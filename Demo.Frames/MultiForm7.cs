using Cyotek.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private List<Bitmap> _bitmaps;

        private BackgroundWorker _openFramesTask;

        private int _interval;

        public MultiForm7()
        {
            InitializeComponent();
            _frames = new List<Frame>();
            _bitmaps = new List<Bitmap>();
            _imageBoxs = new List<RichImageBox>();
            InitializePlayPanels();
            this.timer.Interval = _interval = 200;
            this.timer.Tick += PlayTimer_Tick;
            EnablePlayButton(false);
            this.progressPanel.IsVisible(false);
            InitilizeTask();
        }

        private void InitilizeTask()
        {
            _openFramesTask = new BackgroundWorker();
            _openFramesTask.WorkerReportsProgress = true;
            _openFramesTask.WorkerSupportsCancellation = true;
            _openFramesTask.DoWork += OpenFramesTask_DoWork;
            _openFramesTask.ProgressChanged += OpenFramesTask_ProgressChanged;
            _openFramesTask.RunWorkerCompleted += OpenFramesTask_RunWorkerCompleted;
        }

        private void LoadFrames()
        {
            if (!_openFramesTask.IsBusy)
            {
                this.progressPanel.LabelInfo.Text = "正在打开帧图，请稍等......";
                this.progressPanel.ProgressBar.Value = 0;
                this.progressPanel.IsVisible(true);
                _openFramesTask.RunWorkerAsync();
            }
        }

        private void OpenFramesTask_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i=0; i<_frames.Count; i++)
            {
                if (_openFramesTask.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                try
                {
                    loadImage(_frames[i].FileFullName, 300, 277);
                }
                catch (Exception ee)
                {
                }
                _openFramesTask.ReportProgress(100 * (i + 1) / _frames.Count);
            }
        }

        private void OpenFramesTask_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressPanel.ProgressBar.Value = e.ProgressPercentage;
        }

        private void OpenFramesTask_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.progressPanel.ProgressBar.Value = 100;
            //this.progressPanel1.ProgressBar.Visible = false;
            this.progressPanel.IsVisible(false);
            if (e.Cancelled)
            {
                return;
            }

            MessageBox.Show("成功加载全部帧图！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EnablePlayButton(true);
        }

        private void EnablePlayButton(bool enable)
        {
            this.btnPlay.Enabled = enable;
            this.btnStop.Enabled = enable;
        }

        private void GetImages()
        {
            foreach(Frame frame in _frames)
            {
                loadImage(frame.FileFullName, 300, 277);
            }
        }

        private void loadImage(string path, int width, int height)
        {
            using (var srce = new Bitmap(path))
            {
                var dest = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                using (var gr = Graphics.FromImage(dest))
                {
                    gr.DrawImage(srce, new Rectangle(Point.Empty, dest.Size));
                }
                //if (pictureBox.Image != null) pictureBox.Dispose();
                this._bitmaps.Add(dest);
            }
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
                        LoadFrames();
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
            this.timer.Interval = _interval;
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
                //foreach (var imagebox in _imageBoxs)
                //{
                //    imagebox.ImagePath = this._frames[_currentNumber].FileFullName;
                //}
                foreach (var imagebox in _imageBoxs)
                {
                    imagebox.Bitmap = this._bitmaps[_currentNumber];
                }
            }
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.timer.Interval = _interval = 200;
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            this.timer.Interval = _interval = 500;
        }

        private void btnFast_Click(object sender, EventArgs e)
        {
            this.timer.Interval = _interval = 25;
        }
    }
}

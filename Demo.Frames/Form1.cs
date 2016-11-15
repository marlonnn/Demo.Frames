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
    public partial class Form1 : Form
    {
        private List<Frame> _frames;
        private int _currentNumber;
        private Graphics graphics;
        private Bitmap _currentImage;
        public Form1()
        {
            _frames = new List<Frame>();
            _currentImage = new Bitmap(500, 600);
            InitializeComponent();
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
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = false;
        }

        private void hscrFps_Scroll(object sender, ScrollEventArgs e)
        {
            //timer.Interval = 1000 / hScrollBar.Value;
            this.timer.Interval = 1000 / hScrollBar.Value;
            lblFps.Text = hScrollBar.Value.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this._frames != null && this._frames.Count > 0)
            {
                _currentNumber = ++_currentNumber % _frames.Count;
                this.richImageBox.ImagePath = this._frames[_currentNumber].FileFullName;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = Graphics.FromImage(_currentImage);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}

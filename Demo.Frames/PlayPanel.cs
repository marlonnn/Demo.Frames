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
    public partial class PlayPanel : UserControl
    {
        private Object thisLock = new Object();

        private List<Frame> _frames;

        public delegate void TraceBarChangedDelegate(PlayPanel playPanel,int value);

        public TraceBarChangedDelegate TraceBarChangedHandler;
        public List<Frame> Frames
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

        public PlayPanel()
        {
            InitializeComponent();

            _frames = new List<Frame>();
            _currentNumber = 0;
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.playTimer.Interval = 1000 / 5;
        }

        public void Play(bool play)
        {
            this.playTimer.Enabled = play;
        }

        private void TraceBar_ValueChanged(object sender, EventArgs e)
        {
            int value = this.trackBar.Value;
            long tick = DateTime.Now.Ticks;
            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));

            Random random = new Random();
            int ranValue = ran.Next(1, 5);
            if (TraceBarChangedHandler != null)
            {
                TraceBarChangedHandler(this, ranValue);
            }
        }

        private void PlayTimer_Tick(object sender, EventArgs e)
        {
            if (this._frames != null && this._frames.Count > 0)
            {
                _currentNumber = ++_currentNumber % _frames.Count;
                this.pictureBox.ImageLocation = _frames[_currentNumber].FileFullName;
            }
        }
    }
}

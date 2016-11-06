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
    public partial class PictureBoxPanel : UserControl
    {
        private Object thisLock = new Object();

        private Timer timer;
        public Timer PlayTimer
        {
            get
            {
                return timer;
            }
            set
            {
                timer = value;
                if (timer != null)
                    value.Tick += new EventHandler(PlayTimer_Tick);
            }
        }

        private List<Frame> _frames;

        private int _currentNumber;

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

        public PictureBoxPanel()
        {
            InitializeComponent();
            _frames = new List<Frame>();
            _currentNumber = 0;
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PlayTimer_Tick(object sender, EventArgs e)
        {
            var v = timer.Interval;
            if (this._frames != null && this._frames.Count > 0)
            {
                _currentNumber = ++_currentNumber % _frames.Count;
                this.pictureBox.ImageLocation = _frames[_currentNumber].FileFullName;
            }
        }
    }
}

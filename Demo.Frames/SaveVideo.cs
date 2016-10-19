using AviFile;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Frames
{
    public class SaveVideo
    {
        private VideoStream _aviStream;
        private GrabFrames _grabFrames;
        private AviManager _aviManager;

        public delegate void SaveVideoProgress(double progress);
        public SaveVideoProgress SaveVideoProgressHandler;


        private Thread _thread;

        public SaveVideo(GrabFrames grabFrames, AviManager aviManager)
        {
            this._grabFrames = grabFrames;
            this._aviManager = aviManager;
            this._aviStream = aviManager.AddVideoStream(false, this._grabFrames.MediaInfo.FPS, (Bitmap)this._grabFrames.Frames[0].Image);
        }

        public void ExportVideo()
        {
            _thread = new Thread(new ThreadStart(this.Save));
            _thread.Start();
        }

        private void Save()
        {

            for (int i = 1; i < this._grabFrames.Frames.Count; i++)
            {
                _aviStream.AddFrame((Bitmap)this._grabFrames.Frames[i].Image);
                if (SaveVideoProgressHandler != null)
                {
                    SaveVideoProgressHandler(i);
                }

            }
            _aviManager.Close();
        }

    }
}

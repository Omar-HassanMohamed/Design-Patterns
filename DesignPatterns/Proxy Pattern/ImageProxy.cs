using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy_Pattern
{
    public class ImageProxy
    {
        private bool done;
        private Timer timer;
        public ImageProxy()
        {
            //create a timer thread and start it 
            timer = new Timer(new TimerCallback(timerCall), this, 5000, 0);
        }

        //called when timer completes 
        private void timerCall (object obj)
        {
            done = true;
            timer.Dispose();
        }

        public Image GetImage()
        {
            Imager imager;
            if (done)
                imager = new FinalImage();
            else
                imager = new QuickImage();

            return imager.GetImage();
        }
    }
}

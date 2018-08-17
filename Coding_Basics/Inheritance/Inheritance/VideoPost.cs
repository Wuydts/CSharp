using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inheritance
{
    class VideoPost:Post
    {
        //member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        protected string VideoURL { get; set; }
        protected int length { get; set; }

        public VideoPost() { } // calls the default one

        public VideoPost(string title, string sendByUsername, string videoURL, bool ISpublic, int Length)
        {
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            isPublic = ISpublic;

            VideoURL = videoURL;
            length = Length;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - by {4}", ID, Title, VideoURL, length, SendByUsername);
        }


        public void Play()
        {
            if(!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000); // 1000 miliseconds
            }
          
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < length)
            {
                isPlaying = false;
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else if(currDuration >= length)
            {
                Console.WriteLine("Video has ended");
                isPlaying = false;
                Stop();
            }
            else
            {
                Stop();
            }
        }


        public void Stop()
        {
            if(isPlaying && currDuration < length)
            {
                Console.WriteLine("Stopping at {0}s", currDuration);
                currDuration = 0;
                isPlaying = false;
                timer.Dispose();
            }
            else
            {
                currDuration = 0;
                isPlaying = false;
                timer.Dispose();
            }
        }



    }
}

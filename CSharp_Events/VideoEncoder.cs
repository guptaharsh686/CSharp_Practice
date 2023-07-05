using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharp_Events
{
    public class VideoEncoder
    {
        //public delegate void videoEncodedEventHandler(Object source, VideoEventArgs args);
        //public event videoEncodedEventHandler videoEncoded;
        //By using built in EventHandler type we can skip declaring delegate and declaring event and directly use EventHandler 

        public event EventHandler<VideoEventArgs> videoEncoded;
        public event EventHandler videoEncodedWithoutArgs; //<- This is for event without any arguements
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding the video");
            Thread.Sleep(3000);
            OnVideoEncoded(new VideoEventArgs() { Video = video });
            OnVideoEncodedWithoutArgs();
        }


        protected virtual void OnVideoEncoded(VideoEventArgs args)
        {
            if(videoEncoded != null) // check if there are any subscribers to this event
            {
                videoEncoded(this, args);
            }
        }

        //for eventhandler method without args
        protected virtual void OnVideoEncodedWithoutArgs()
        {
            if(videoEncodedWithoutArgs != null)
            {
                videoEncodedWithoutArgs(this,EventArgs.Empty);
            }
        }
    }
}

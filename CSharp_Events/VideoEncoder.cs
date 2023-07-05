using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharp_Events
{
    public class VideoEncoder
    {
        public delegate void videoEncodedEventHandler(Object source, VideoEventArgs args);
        public event videoEncodedEventHandler videoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding the video");
            Thread.Sleep(3000);
            OnVideoEncoded(new VideoEventArgs() { Video = video});
        }


        protected virtual void OnVideoEncoded(VideoEventArgs args)
        {
            if(videoEncoded != null) // check if there are any subscribers to this event
            {
                videoEncoded(this, args);
            }
        }
    }
}

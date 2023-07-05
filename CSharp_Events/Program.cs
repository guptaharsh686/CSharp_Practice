using System;

namespace CSharp_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var video = new Video("Video 1");
            var encoder = new VideoEncoder();//publisher
            var mailserv = new MailService();//subscriber
            var messerv = new MessageService();//subscriber



            encoder.videoEncoded += mailserv.OnVideoEncoded; // subscribing to the event by regestering an event handler method 
            //passing the pointer/refrence so whenever videoEncoded event happens it is published and envokes the method so that subscribers can be notified
            encoder.videoEncoded += messerv.OnVideoEncoded;


            //using build in event handler without event args
            encoder.videoEncodedWithoutArgs += mailserv.OnVideoEncodedWithoutArgs;
            encoder.videoEncodedWithoutArgs += messerv.OnVideoEncodedWithoutArgs;

            encoder.Encode(video);
        }
    }
}

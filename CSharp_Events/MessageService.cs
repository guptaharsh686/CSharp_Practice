using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Events
{
    public class MessageService
    {
        public void OnVideoEncoded(Object source,VideoEventArgs args)
        {
            Console.WriteLine("Sending a message..." + args.Video.Title);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Events
{
    public class MessageService
    {
        public void OnVideoEncoded(Object source,EventArgs args)
        {
            Console.WriteLine("Sending a message");
        }
    }
}

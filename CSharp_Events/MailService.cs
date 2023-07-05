using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Events
{
    public class MailService
    {
        public void OnVideoEncoded(Object source,VideoEventArgs e)
        {
            Console.WriteLine("Sending an email..." + e.Video.Title);
        }

        public void OnVideoEncodedWithoutArgs(Object s, EventArgs args)
        {
            Console.WriteLine("Sending an email without args");
        }
    }
}

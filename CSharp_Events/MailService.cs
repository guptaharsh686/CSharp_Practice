﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Events
{
    public class MailService
    {
        public void OnVideoEncoded(Object source,EventArgs e)
        {
            Console.WriteLine("Sending an email");
        }
    }
}

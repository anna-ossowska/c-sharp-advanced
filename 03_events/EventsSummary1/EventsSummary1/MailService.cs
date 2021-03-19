using System;
using System.Collections.Generic;
using System.Text;

namespace EventsSummary1
{
    // Subscriber 1
    // responsible for sending an email once the video is encoded
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MailService: Sending an email...");
        }
    }
}

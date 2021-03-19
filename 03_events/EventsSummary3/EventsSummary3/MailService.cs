using System;
using System.Collections.Generic;
using System.Text;

namespace EventsSummary3
{
    // Subscriber 1
    // responsible for sending an email once the video is encoded
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"MailService: Sending an email... {args.Video.Title}");
        }
    }
}

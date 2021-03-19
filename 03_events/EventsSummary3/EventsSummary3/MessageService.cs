using System;
using System.Collections.Generic;
using System.Text;
 
namespace EventsSummary3
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"MessageService: Sending a message... {args.Video.Title}");
        }
    }
}

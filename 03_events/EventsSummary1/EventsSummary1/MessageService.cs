using System;
using System.Collections.Generic;
using System.Text;

namespace EventsSummary1
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MessageService: Sending a message...");
        }
    }
}

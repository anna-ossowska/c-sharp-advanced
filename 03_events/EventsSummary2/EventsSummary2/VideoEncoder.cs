using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsSummary2
{
    // Class containing the data about video that was encoded
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // 1. Define a delegate
        // 2. Define an event based on that delegate
        // 3. Raise the event

        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding...");
            Thread.Sleep(3000);

            // Notifying Subscribers
            OnVideoEncoded(video);
        }

        virtual protected void OnVideoEncoded(Video video)
        {
            // Checking if there are any subscribers to the event
            // Behind the scenes this is a list of pointers to methods
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}

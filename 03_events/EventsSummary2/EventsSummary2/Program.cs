using System;

namespace EventsSummary2
{
    class Program
    {
        static void Main()
        {
            var video = new Video() { Title = "Title1" };
            var videoEncoder = new VideoEncoder(); // Publisher
            var mailService = new MailService(); // Subscriber 1
            var messageService = new MessageService(); // Subscriber 2

            // Registering a handler for the event by using +=
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;


            videoEncoder.Encode(video);
        }
    }
}
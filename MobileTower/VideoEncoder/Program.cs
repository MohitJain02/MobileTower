using System;

namespace VideoEncoder
{
    // create a custom evetnArgs

  
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video()
            {
                Id = 1,
                Title = "New Video"
            };

            var videoEncoder = new VideoEncoder(); // instance of the publisher
            var mailService = new MailService(); // instance of the subscriber
            var messageService = new MessageService(); // instance of the subscriber


            // register the subscriber to the event

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encoder(video);

            Console.ReadLine();
        }
    }

    class MailService // subscriber
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Send the mail to the system" + args.Video.Title);
        }
    }

    class MessageService // subscriber
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Send the message Service" + args.Video.Title);
        }
    }
}

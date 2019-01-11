using System;
using System.Threading;

namespace VideoEncoder
{

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    // its is the publisher
    public class VideoEncoder
    {

        // 1. Define a delegate
        // 2. Define an event based on that delegate
        // 3. Raise that event

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //public event VideoEncodedEventHandler VideoEncoded;

        public event EventHandler<VideoEventArgs> VideoEncoded; // latest way of doing it


        public void Encoder(Video video)
        {
            Console.WriteLine("Encoding Video...");

            Thread.Sleep(3000);

            OnVideoEncoded(video); // calling the event
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs { Video = video});
        }
    }
}

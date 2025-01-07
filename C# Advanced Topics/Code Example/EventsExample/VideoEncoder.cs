using System.Security.Cryptography.X509Certificates;

namespace EventsExample
{

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        //1. Define a delegate
       // public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);

        //Define an event based on that delegate
        //public event VideoEncoderEventHandler VideoEncoded;

        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        //Raise the event
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video});
        }
    }
}

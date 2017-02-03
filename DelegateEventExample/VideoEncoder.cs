using System;
using System.Threading;

namespace DelegateEventExample
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        //Define event
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encoded(Video v)
        {
            Console.WriteLine("Encoding video... ");
            Thread.Sleep(3000);

            OnVideoEncoded(v);
        }

        protected virtual void OnVideoEncoded(Video v) {
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = v});
        }
    }
}

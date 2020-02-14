using System;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {
        //old method making your own delegate
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;


        //default delegates from .net
        //EventHandler
        //EventHandler<TEventArgs>

        //using the default delegate
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(string video) {
            Console.WriteLine("Encoding...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(string video) //protected virtual void On___()
        {
            //virtual allows overriding
            if (VideoEncoded != null) //this is a list of the subscribers as delegated methods
                VideoEncoded(this, new VideoEventArgs(){Info = video});
                //You can have info as args instead of empty if you want
        }
    }
}
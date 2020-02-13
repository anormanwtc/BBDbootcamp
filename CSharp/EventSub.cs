using System;
namespace Events
{
    public class Program
    {
        static void Main() {
            string video = "Video name";
            var VideoEncoder = new VideoEncoder(); //publisher
            var _mailService = new MailService(); //subscriber
            var _textService = new TextService();

            VideoEncoder.VideoEncoded += _mailService.OnVideoEncoded; //adding it to 
            VideoEncoder.VideoEncoded += _textService.OnVideoEncoded; //subscriber list
            VideoEncoder.Encode(video);
        }
    }

    public class MailService {
        public void OnVideoEncoded(object source, VideoEventArgs e) {
            Console.WriteLine("mailservice sending email " + e.Info);
        }
    }

    public class TextService {
        public void OnVideoEncoded(object source, VideoEventArgs e) {
            Console.WriteLine("textservice sending text " + e.Info);
        }
    }
}
using System.Reflection;

namespace EventsExample
{

    public class Program
    {
        static void Main(string[] args)
        {
            var video = new Video()
            {
                Title = "Video 1"
            };
            var videEncoder = new VideoEncoder();
            var mailService = new MailService();

            videEncoder.VideoEncoded += mailService.OnVideoEncoded;

            var smsService = new SmsService();
            videEncoder.VideoEncoded += smsService.OnVideoEncoded;
            videEncoder.Encode(video);
        }
    }
}

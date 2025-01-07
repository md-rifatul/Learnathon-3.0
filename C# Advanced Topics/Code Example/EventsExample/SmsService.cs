namespace EventsExample
{
    public class SmsService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine("SMS Service: Sending am SMS..."+e.Video.Title);
        }
    }
}

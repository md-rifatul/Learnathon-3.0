namespace EventsExample
{

    public class MailService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sendin an email..."+e.Video.Title);
        }
    }
}

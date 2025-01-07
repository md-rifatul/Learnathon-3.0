namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //using (var streamReader = new StreamReader(@"c:\file.zip"))
                //{
                //    var content = streamReader.ReadToEnd();

                //}

                //var calculator = new Calculator();
                //var result = calculator.Divide(5, 0);

                var api = new YoutubeApi();
                var videos = api.GetVideos("rifatul");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

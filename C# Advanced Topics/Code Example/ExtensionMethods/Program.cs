namespace ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            string message = "This is supposed to be a very long .....";
            var sortenedPost = message.Shorten(5);

            Console.WriteLine(sortenedPost);
        }
    }
}

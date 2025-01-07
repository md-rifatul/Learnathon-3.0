namespace ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long .....";
            var sortenedPost = post.Shorten(5);

            Console.WriteLine(sortenedPost);
        }
    }
}

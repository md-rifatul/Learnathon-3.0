namespace Indexers
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Rifatul";
            Console.WriteLine(cookie["name"]);
        }
    }
}

namespace random
{
    public class Program
    {
        static void Main(string[] args)
        {
           var random = new Random();

            var words = new char[10];

            for (var i = 0; i < 10; i++)
            {
                words[i] = (char)random.Next(97, 122);
                Console.WriteLine(words[i]);
            }

            var password = new string(words);
            Console.WriteLine(password);


        }
    }
}

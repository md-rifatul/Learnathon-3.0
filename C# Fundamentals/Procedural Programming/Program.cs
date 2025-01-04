namespace Procedural_Programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name : ");

            var name = Console.ReadLine();
            var reverse = ReverseName(name);
            Console.WriteLine(reverse);
           
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length - 1; i >= 0; i--)
            {
                array[name.Length -1 - i] = name[i];

            }
            return new string(array);
        }
    }
}

using System.Text;

namespace String_Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder
                .Append('-',15)
                .AppendLine("Hello")
                .Append("Hi")
                .Remove(0, 10) //Remove
                .Insert(0, new string('*', 5));  //Insert

            Console.WriteLine(stringBuilder);
            //First char
            Console.WriteLine("First char : "+stringBuilder[0]);



        }
    }
}

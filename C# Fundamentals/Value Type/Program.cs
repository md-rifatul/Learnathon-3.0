namespace Value_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number1 = 20;
            var number2 = number1;
            number1++;
            Console.WriteLine($"Number1 = {number1}  Number2 = {number2}");
        }
    }
}

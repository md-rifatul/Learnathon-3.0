namespace Boxing___Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Boxing
            var number = 10;
            object obj = number;
            Console.WriteLine(obj);

            //Unboxing
            object obj1 = 50;
            var number2 = (int)obj1;
            Console.WriteLine(number2);

        }
    }
}

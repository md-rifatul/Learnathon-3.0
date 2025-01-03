namespace Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[5];   //{1,2,3,4,5};

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine();

            var flags = new bool[5];
            flags[0] = true;
            flags[1] = true;

            foreach (var flag in flags)
            {
                Console.WriteLine(flag);
            }

            Console.WriteLine();

            var names = new string[2] {"Rifatul","Roki"};

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


        }
    }
}

namespace Array_Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 4, 5, 64, 3, 2, 0, 1 };

            //Length
            Console.WriteLine("Array length is: "+numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers,3);
            Console.WriteLine("Effect of InfexOf(): ");
            Console.WriteLine(index);

            //Clear()
            Array.Clear(numbers, 0, 3);
            Console.WriteLine("Effect of clear: ");
            foreach(var number in numbers)
                Console.WriteLine(number);

            //Copy()
            var number2 = new int[] { 3, 5, 6, 43, 2 };
            Array.Copy(numbers, number2, 3);
            Console.WriteLine("Effect of copy(): ");
            foreach (var number in numbers)
                Console.WriteLine(number);

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of sort(): ");
            foreach( var number in numbers)
                Console.WriteLine(number);

            //reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of reverse: ");
            foreach(var number in numbers)
                Console.WriteLine(number);
        }
    }
}

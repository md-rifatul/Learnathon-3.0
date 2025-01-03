namespace List_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1,5,2,6};
            numbers.Add(1);


            numbers.AddRange(new int[] { 8, 7});
            foreach (var number in numbers)
                Console.WriteLine(number);

            //IndexOf()
            Console.WriteLine("The first index of 1 : "+ numbers.IndexOf(1));

            //LastIndexOf()
            Console.WriteLine("The last index of 1 : "+ numbers.LastIndexOf(1));


            //Remove first 1
            numbers.Remove(1);
            Console.WriteLine("After remove operation: ");
            foreach (var number in numbers)
                Console.WriteLine(number);

            //Remove all 1
            for(var i =0;i < numbers.Count;i++)
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            Console.WriteLine("After remove all 1: ");
            foreach (var number in numbers)
                Console.WriteLine(number);

            //RemoveAt()
            numbers.RemoveAt(2);
            Console.WriteLine("Effect of RemoveAt() : ");
            foreach (var number in numbers)
                Console.WriteLine(number);

            //Clear()
            numbers.Clear();
            Console.WriteLine("Count : "+numbers.Count);


        }
    }
}

namespace BubbleSortWithGeneric
{
}

namespace BubbleSortWithGeneric
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bubbleSort1 = new BubbleSort<int>();
            var results1 = bubbleSort1.Sort(new int[] { 2, 4, 43, 2, 1, 3 });

            foreach (var result in results1)
                Console.WriteLine(result);
        }
    }
}

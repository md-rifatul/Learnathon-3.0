using System.Collections;

namespace Generic_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lists = new List<int>();
            lists.Add(1);
            lists.Add(2);
            lists.Add(3);
            lists.Add(4);
            lists.Add(5);

            foreach (var list in lists)
                Console.WriteLine(list);

        }
    }
}

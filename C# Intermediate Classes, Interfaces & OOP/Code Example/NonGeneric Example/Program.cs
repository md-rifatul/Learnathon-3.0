using System.Collections;

namespace NonGeneric_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Two");
            arrayList.Add(2.56);
            arrayList.Add(new DateTime(2015,5,15));

            foreach (var array in arrayList)
                Console.WriteLine(array);

        }
    }
}

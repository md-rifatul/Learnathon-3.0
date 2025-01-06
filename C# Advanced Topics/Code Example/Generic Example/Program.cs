namespace Generic_Example
{
    public class Utilities<T> where T : IComparable
    {
        public T GetMaxNumber(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a:b ;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var utilities = new Utilities<int>();
            
            Console.WriteLine(utilities.GetMaxNumber(10, 20));
        }
    }
}

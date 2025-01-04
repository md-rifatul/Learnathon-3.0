namespace Out_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            var calculation = new Calculation();
            calculation.Calculate(out x);
            Console.WriteLine(x);
        }
    }
}

namespace Method_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            calculator.Add(10, 20);
            calculator.Add(20,10.5, 30);
            calculator.Add(10.5, 20);
            calculator.Add(new int[] {1,2,3,4,5});
        }
    }
}

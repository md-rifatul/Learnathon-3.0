using Calculator;

class Program
{
    static void Main(string[] args)
    {
        var calculation = new Calculation();

        calculation.Sum(20,10);
        calculation.Sub(20, 10);
        calculation.Div(20, 10);
        calculation.Multi(20, 10);
    }
}
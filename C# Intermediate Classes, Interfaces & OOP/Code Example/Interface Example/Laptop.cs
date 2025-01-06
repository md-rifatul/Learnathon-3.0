namespace Interface_Example
{
    public class Laptop : IProduct
    {
        public double CalculateServiceCharge()
        {
            return 10;
        }

        public double CalculteDiscount()
        {
            return 50;
        }
    }
}

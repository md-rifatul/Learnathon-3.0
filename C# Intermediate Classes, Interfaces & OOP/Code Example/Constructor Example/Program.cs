namespace Constructor_Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new Customer();
            var customer2 = new Customer(1);

            var customer3 = new Customer
            {
                Id = 1,
                Name = "Test",
            };


        }
    }
}

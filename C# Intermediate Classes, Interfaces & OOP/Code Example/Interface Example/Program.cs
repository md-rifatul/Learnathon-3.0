namespace Interface_Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            void Demo1(IProduct item)
            {
                Console.WriteLine("Service charge of Camera : "+item.CalculateServiceCharge());
                Console.WriteLine("Discount of Camera : " + item.CalculteDiscount());
            }
            Demo1(new Camera());


            void Demo2(IProduct item2)
            {
                Console.WriteLine("Service charge of Laptop : " + item2.CalculateServiceCharge());
                Console.WriteLine("Discount of Laptop : " + item2.CalculteDiscount());
                
            }
            Demo2(new Laptop());
        }
    }
}

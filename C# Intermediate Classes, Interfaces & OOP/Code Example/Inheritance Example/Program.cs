namespace Inheritance_Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Price = 100000;
            car.Brand = "Mercedes";
            car.start();
            car.stop();
            car.openTrunk();
            Console.WriteLine(car.Price);
            Console.WriteLine(car.Brand);

            var bike = new Bike();
            bike.Price = 50000;
            bike.Brand = "Yamaha";
            bike.start();
            bike.stop();
            bike.KickStart();
            Console.WriteLine(bike.Price);
            Console.WriteLine(bike.Brand);

        }
    }
}

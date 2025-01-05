namespace Constructor___Inheritance
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle");
        //}
        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
            Console.WriteLine($"Vicle registration number is : {registrationNumber}");
        }
    }
}

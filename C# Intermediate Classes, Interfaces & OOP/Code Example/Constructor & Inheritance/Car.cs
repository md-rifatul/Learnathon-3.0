namespace Constructor___Inheritance
{
    public class Car : Vehicle
    {

        public Car(string registrationNumber):base(registrationNumber)
        {
            
            Console.WriteLine($"Car registration number is : {registrationNumber}");

        }
    }
}

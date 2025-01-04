namespace Properties
{

    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Birthdate = new DateTime(2015,5,15);
            Console.WriteLine(person.Age);
        }
    }
}

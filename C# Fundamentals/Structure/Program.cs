namespace Structure
{
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.name = "Rifatul";
            person.age = 23;

            Console.WriteLine(person.name);
            
        }
    }
}

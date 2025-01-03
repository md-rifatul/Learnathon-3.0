namespace dowhile_Loop
{
    public class Program
    {
        static void Main(string[] args)
        {
            var number = 1;

            do
            {
                Console.WriteLine(number);
                number++;
            } while (number == 1);
        }
    }
}

namespace While_Loop
{
    public class Program
    {
        static void Main(string[] args)
        {

            var number = 1;

            while(number < 10)
            {
                if(number %2  == 0)
                    Console.WriteLine(number);
                number++;
            }


            while (true)
            {
                Console.WriteLine("Enter your name: ");
                var input = Console.ReadLine();

                if(String.IsNullOrEmpty(input))
                    break;
                Console.WriteLine($"Your name is {input}");
            }
            
        }
    }
}

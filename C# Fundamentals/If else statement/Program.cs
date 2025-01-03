namespace If_else_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var time = 10;

            if (time > 0 && time < 12)
                Console.WriteLine("It's morning");
            else if (time >= 12 && time < 18)
                Console.WriteLine("It's afternoon");
            else
                Console.WriteLine("It's evening");



            var isGold = true;
            var ans = (isGold) ? "Yes" : "No";
            Console.WriteLine(ans);
        }
    }
}

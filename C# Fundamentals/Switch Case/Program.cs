namespace Switch_Case
{
    public class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Winter;

            switch(season)
            {
                case Season.Winter:
                case Season.Spring:
                    Console.WriteLine("We've got promotion");
                    break;

                default:
                    Console.WriteLine("I dont understand that season");
                    break;
            }
        }
    }
}

namespace Live_Coding_Summarising_Text
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sentance = "Bangladesh is a South Asian country known for its rich history, vibrant culture, and diverse landscapes. It has a large population, with Dhaka as its bustling capital. The country faces challenges like overpopulation and climate change but is also recognized for its strong textile industry and rapid economic growth";
            var summary = StringUtility.SummerizeText(sentance,25);
            Console.WriteLine(summary);
        }
    }
}


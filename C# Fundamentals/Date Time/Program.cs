namespace Date_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var datetime = new DateTime(2002, 12, 5);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(now);
            Console.WriteLine(today);

            Console.WriteLine("Hour : "+now.Hour);
            Console.WriteLine("Minute : "+now.Minute);

            var tomrrow = now.AddDays(1);
            Console.WriteLine("Tomorrow : "+tomrrow);

            var yesterday = now.AddDays(-1);
            Console.WriteLine("Yesterday : "+yesterday);


            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine(now.ToString("yyyy-MM-dd HH:MM"));
        }
    }
}

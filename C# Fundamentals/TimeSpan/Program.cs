﻿namespace Time_Span
{
    public class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = TimeSpan.FromHours(1);

            Console.WriteLine(timeSpan1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddDays(2);
            var duration = end - start;
            Console.WriteLine("Duration : "+ duration);

            //Properties
            Console.WriteLine("Minutes : "+timeSpan.Minutes);
            Console.WriteLine("Total Minutes : "+timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add Example : "+timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example : "+timeSpan.Subtract(TimeSpan.FromMinutes(2)));


            //ToString
            Console.WriteLine("ToString : "+timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse : "+TimeSpan.Parse("01:02:03"));
        }
    }
}

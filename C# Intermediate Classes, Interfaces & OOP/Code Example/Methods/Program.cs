﻿using System.Drawing;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse("abc");

            try
            {
                var num = int.Parse("abc");
            }
            catch(Exception ex)
            {
                Console.WriteLine("conversion faild");
            }
            int number;
            var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("conversion faild");
;        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));

        }


        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})",point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class Calculator
    {

        public void Add(int n1, int n2)
        {
            Console.WriteLine("The answer is : "+(n1+n2));
        }
        public void Add(int n1, double n2,int n3)
        {
            Console.WriteLine("The answer is : "+(n1+n2+n3));
        }
        public void Add(double n1, int n2)
        {
            Console.WriteLine("The answer is : "+(n1+n2));
        }

        public void Add(params int[] numbers)
        {
            int sum = 0;
            foreach(var number in numbers)
                sum += number;
            Console.WriteLine(sum);
        }
    }
}

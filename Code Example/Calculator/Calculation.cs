using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation
    {

        public void Sum(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }
        public void Sub(int number1, int number2)
        {
            if (number1 > number2)
            {
                Console.WriteLine(number1 - number2);
            }
            else
            {
                Console.WriteLine(number2 - number1);
            }
        }
        public void Div(int number1, int number2)
        {
            if(number2 < number1)
            {
                Console.WriteLine(number1 / number2);
            }
            else
            {
                Console.WriteLine(number2 / number1);
            }
        }
        public void Multi(int number1, int number2)
        {
            Console.WriteLine(number2 * number1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    public class Vehicle
    {
        public int Price { get; set; }
        public string Brand { get; set; }

        public void start()
        {
            Console.WriteLine("Vehicle is starting");
        }
        public void stop()
        {
            Console.WriteLine("Vehicle has stopped");
        }
    }
}

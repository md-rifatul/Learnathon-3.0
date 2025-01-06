using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    public class Camera : IProduct
    {
        public double CalculateServiceCharge()
        {
            return 20;
        }

        public double CalculteDiscount()
        {
            return 60;
        }
    }
}

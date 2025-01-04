using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Modifier
{
    public class Geometry
    {
        public void Calculate(ref int x)
        {
            Console.WriteLine(x);
            x = 9;
        }
    }
}

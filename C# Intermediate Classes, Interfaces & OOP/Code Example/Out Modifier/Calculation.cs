using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Modifier
{
    public class Calculation
    {
        public void Calculate(out int x)
        {
            x = 9;
            Console.WriteLine(x);
        }
    }
}

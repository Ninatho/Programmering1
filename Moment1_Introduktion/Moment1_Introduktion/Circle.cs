using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    internal class Circle
    {
        public void Calculate()
        {
            double radie = 30;
            Console.WriteLine("Omkretsen för denna cirkel är: " + (2 * Math.PI * radie));
            Console.WriteLine("Arean för denna cirkel är: " + (Math.PI * radie * radie));
            Console.WriteLine("Arean för denna cirkel är: " + (Math.PI * Math.Pow(radie, 2)));
        }
    }
}
 
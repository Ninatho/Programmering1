using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment6.Uppgift4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kefftNamn = { "Stockholm", "Malmö", "Göteborg" };

            try
            {
                Console.WriteLine(kefftNamn[4]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Det är förfan utanför index");
            }
        }
    }
}

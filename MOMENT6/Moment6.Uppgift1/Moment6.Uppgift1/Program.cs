using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment6.Uppgift1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange din inkomst: ");
            int inkomst = int.Parse(Console.ReadLine()); //Testa med att mata in något annat än Int och läs felkoden
            Console.Write("Ange antal timmar: ");
            int timmar = int.Parse(Console.ReadLine()); //Testa med att mata in något annat än Int och läs felkoden

            Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");

            Console.ReadKey();

            //Dom tre olika typer av exception är - overflow, divided by zero och format.
        }
    }
}

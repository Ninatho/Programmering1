using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMENT3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange teperaturen för Östersund: ");
            string ötemp = Console.ReadLine();
            Console.Write("Ange temperaturen för Åmål: ");
            string åtemp = Console.ReadLine();
            if (int.TryParse(ötemp, out int tempö) && int.TryParse(åtemp, out int tempå))
            //Console.Write så vi kan skriva in våran text. En string med namn och Console.Readline så vi kan mata in temperatur.
            //if med int.TryParse (ötemp, out int tempö) så att string koverteras till heltal, string ötemp till int tempö.
            //I if satsen så skriver vi in int namnen eftersom string namnen konvererats och < så koden ska veta vart det är kallast.
            //beroende på vad vi skriver in för temperatur.
            if (tempö < tempå)
            {
                    Console.Write("Det är kallare i Östersund.");
            }
            else
            {
                Console.Write("Det är kallre Åmål.");
            }
            Console.ReadLine();
          
        }
    }
}

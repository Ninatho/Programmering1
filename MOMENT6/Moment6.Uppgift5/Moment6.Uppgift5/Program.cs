using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Moment6.Uppgift5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Mata in start: ");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mata in stop: ");
                int tal2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mata in steg: ");
                int tal3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                if (tal2 < tal1)
                {
                    Console.WriteLine("Stop kan inte vara mindre än start.");
                }
                else if (tal3 <= 0)
                {
                    Console.WriteLine("steg får inte börja på noll");
                    return;
                }

                for (int i = tal1; i <= tal2; i += tal3)
                {
                    Console.Write(i + " ");
                }
            }
            catch (FormatException error)
            {
                Console.WriteLine("Inga bokstäver");
            }
            catch (OverflowException error)
            {
                Console.WriteLine("För stort tal");
            }
                Console.ReadLine();
            //för att det inte ska bli fel i inmarning av tall så gör vi en for loop där vi lägge in att stop inte kan vara mindre än start så att
            //om man skulle skriva in det så så kommer det ut text att stop inte får vara mindre än start. sen för att det inte ska kunna bli en
            //oändlig loop så gör vi en else if där steg inte får börja på 0. lägger vi till try catch där den fånfar format exeception om man
            //skriver in en bokstav och då istället skriver ut inga bokstäver och sen samma på overflow exception om man skriver in ett för stort
            //tall så skriver den ut det också.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] städer = new string[5];

            for (int i = 0; i < städer.Length; i++)
            {
                Console.Write($"Ange stad: ");
                städer[i] = Console.ReadLine();
            }
            Console.WriteLine();

            foreach (string stad in städer)
            {
                Console.WriteLine($"{stad} ");
            }
            Console.WriteLine();
            //först en string med en array och sedan new string med antalet arrayer vi skapat, sendan en for loop där vi lägger int i så vi
            //kan hålla reda på hur många gåner den körs. i = 0 för att den ska veta att vi börjar på noll, i < städer.length för att den ska
            //köras så länge det fins "boxar" i arrayen, och i++ för att den ska lägga till en efter varje gång. Console.WriteLine för att kunna
            //skriva ut text och string[i] för att dom städerna vi skriver in ska lagras i arrayen, Console.ReadLine för att den ska vänta på
            //att vi skriver in. Console-WriteLine för att det ska bli en rad brytning eller vad man ska säga. foreach loop som går igenom varje
            //värde vi skrivit in och sedan skriver ut dom med hjälp av Console.WriteLine$"{stad}".
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMENT3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in tal 1: ");
            string tal1 = Console.ReadLine();
            Console.Write("Mata in tal 2: ");
            string tal2 = Console.ReadLine();
            if (decimal.TryParse(tal1, out decimal talet1) && decimal.TryParse(tal2, out decimal talet2))
            //Console.Write för att mata in text på samma rad
            //En string med namn och Console.ReadLine så vi kan mata in valfri siffra.
            //Man lägger if framför decimal.Tryparse för att TryParse retunerar ett sant eller falskt värde.
            //decimal.TryParse(tal1, out decimal talet1) skriver man för att konvertera en sträng till ett decimal-tal.
            //out används för att modifiera som skickar en referens till en variabel till en metod, metoden ändrar värdet
            //i variabeln och skickar sen tillbaka det till anroparen. 

                if (talet1 > talet2)
            {
                Console.WriteLine("Tal 1 är störst");
            }
            else if (talet1 < talet2)
            {
                Console.WriteLine("Tal 2 är störst");
            }
            else
            {
                Console.WriteLine("Talen är lika");
            }

            Console.ReadLine();
            //Sedan gör man en if-sats där man lägger in det som har med att koden ska kunna förstå med hjälp av (if decimal m.m.)
            //och skriva ut vilket tal som är störst eller om det är lika stora.







        }
    }
}

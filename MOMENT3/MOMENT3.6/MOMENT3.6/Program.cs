using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMENT3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange temperatur för Östersund: ");
            string östersund = Console.ReadLine();
            Console.Write("Ange temperatur för Åmål: ");
            string åmål = Console.ReadLine();
            Console.Write("Ange temperatur för Arboga: ");
            string arboga = Console.ReadLine();
            if (int.TryParse(östersund, out int ö) && int.TryParse(åmål, out int å) && int.TryParse(arboga, out int a))
            if (ö < å && ö < a)
            {
                Console.WriteLine("Det är kallast i Östersund ");
            }
            else if (å < ö && å < a)
            {
                Console.WriteLine("Det är kallast i Åmål");
            }
            else
            {
                Console.WriteLine("Det är kallast i Arboga");
            }
            //Console.Write så vi kan skriva in temperstur för att städer. string med namn och Console.ReadLine så att programmet väntar på att vi ska
            //skriva in temp för att städer. 
            //if med int.tryparse för att konvertera till heltal - string med namn till int med namn, 3st och då kan man använda sig av &&.
            //if sats där vi skriver in och jämför dom olika temperaturerna för städerna som vi matat in tidigare, så att koden i slutändan vet beroende på vilken
            //temperatur man har skrivit in är kallast.

        }
    }
}

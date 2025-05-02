using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMENT3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in mönsterdjup: ");
            double mönsterdjup = Convert.ToDouble(Console.ReadLine());
            

            if (mönsterdjup < 1.6)
            {
                Console.WriteLine("Olagliga däck!");

            }

            else
            { 
                Console.WriteLine("Lagliga däck!");

            }// Console.Writeline för att skriva våran text. jag använder mig av variabel double med namn mönsterdjup och sedan 
            // Convert.ToDouble och Console.ReadLine så vi kan skriva våra decimal tal som man oftast gör när man kollar mönsterdjup. dock med 
            // Convert.ToDouble så kan man inte skriva decimaltalet med punkt utan det går endast med kommatecken.
            // senda anväder jag mig av if och else som är vilkorssatser där man matar in om det är sant i if eller falskt i else,
            // koden skrivs in mella {}. 
            

        }
    }
}

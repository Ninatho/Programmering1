using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMENT4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in heltal: ");
            int heltal = Convert.ToInt32(Console.ReadLine());

            bool hittatal = false;

            for (int i = 1; i < heltal; i++) 
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("Talet " + i + " är jämn delbart med både 3 och 7");
                    
                    hittatal = true;
                }
              
 
            }
            if (!hittatal)
            {
                Console.WriteLine("Hittade inga heltal.");
            }
            Console.ReadLine();
        }   //Console.Write så man kan skriva in text på samma rad, sedan int med namn och Convert så den konverterar till 32 bitars heltal.
            //Sedan en bool med namn hittatal som känner av om det finns ett heltal eller inte. En for lopp där i ska börja på 1, i < heltal så att loopen
            //körs så länge i är mindre än heltalet vi skrivit in, i++ som ökar i med 1 efter varje varv. sedan skriver vi in if där vi förklara för
            //programet att den ska kolla om vårat heltal är jämnt delbart med 3 eller 7, i if så skriver vi Console.WriteLine där heltalet skrivs ut på
            //raden under OM det är delbart med 3 och 7 med hjälp av bool. Annars som vi kan se nedan i andra if med !hittatal och senda Console.WriteLine
            //så kommer det skriva ut att den inte hittat något heltal.
    }
}

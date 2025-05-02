using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMENT4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Mata in start: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mata in stop: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mata in steg: ");
            int tal3 = Convert.ToInt32(Console.ReadLine());
            int summan = 0;
            
            for (int i = tal1; i <= tal2; i += tal3) 
            {
                Console.Write(i + " ");
                summan += i;
              
            }
            Console.WriteLine();
            Console.Write($"Summan av alla tal med start från {tal1} med steg {tal2} till stop {tal3} blir: {summan}");
            Console.ReadLine();


        }// Console.Write för att kunna skriva in text på samma rad. variabel int med namn och Convert.ToInt32 så den konverterar vårat tal 
        // som vi skriver in till 32 bitars heltal. Sedan gör jag en for loop där vi behöver förklara hur programet ska läsa våra tal som skrivits in.
        // tal1 som ska som i ska börja med, tal2 som i ska avsluta med och tal3 som i ska hoppa med. I for loopen skrkiver vi in Console.Write
        // med i + " " som gör så att talen skrivs ut med hopp och mellanslag mellan varje. summan += i så att slut summan av dom talen som skrivs ut
        // med hopp jag precis nämnde skrivs ut. 
    }
}

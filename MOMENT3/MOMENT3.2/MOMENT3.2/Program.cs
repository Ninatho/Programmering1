using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMENT3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in din ålder: ");
            int ålder = Convert.ToInt32(Console.ReadLine());

            //Console.Write för att skriva in text men just .Write så texten kommer på samma rad.
            //variabel int med namn ålder så progrmet vet vad vi skriver in och kan ge oss rätt färg.
            //Convert.ToInt32 så att det converterar till 32 bitars heltal.

            if(ålder >= 0 && ålder <= 12)
            {
                Console.WriteLine("Din färg är: Vit");
                
            }
            else if(ålder >= 13 && ålder <= 18)
            {
                Console.WriteLine("Din färg är: Grön");
                
            }
            else if(ålder >= 19 && ålder <= 25)
            {
                Console.WriteLine("Din färg är: Röd");
            }
            else if(ålder >= 26 && ålder <= 99)
            {
                Console.WriteLine("Din färg är: Blå");
            }
            else
            {
                Console.WriteLine("Ogiltig ålder");
            }
            Console.Read();
            
            //Här använder jag mig av if sats med else if mellan if och else så jag kan få olika svar beroende på vilken ålder jag skriver in. 
            //else if är till för att lägga till flera vilkor i en if sats, Det jag har skrivit mellan () är att koden ska veta vad den ska skriva
            //ut för färg beroende på vilken ålder så att den  vet att den siffran jag skriver är i just det spannet.

            
        }   
    }
}

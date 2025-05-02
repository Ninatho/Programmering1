using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in en mening: ");
            string mening = Console.ReadLine();

            string[] ordArray = mening.Split(' ');
            Console.WriteLine();

            Console.WriteLine("Orden i din mening: ");
            foreach (string ord in ordArray)
            {
                Console.WriteLine(ord);
            }
            //Console.WriteLine för at kunna skriva in våran text. en string med namn och ConsoleReadLine så den väntar på att vi skriver in.
        }   //en ny string array med namnet ordarray och mening.split(' ') som delar upp varje ord vid varje mellanslag. Console.WriteLine för
            //rad brytning. Console.WriteLine så man kan skriva i text. en foreach loop som gåt igenom arrayen. Console.WriteLine(ord) så att den
            //skriver ut alla ord från meningnen på egna rader.
    }
}

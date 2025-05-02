using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMENT4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tal = 39;
            int gissningar = 0;

            int gissatalet = -1;
            while (gissatalet != tal)
            {
                Console.Write("Gissa ett tal mellan 1 till 100: ");
                gissatalet = int.Parse(Console.ReadLine());
                gissningar++;
                if (gissatalet > tal)
                {
                    Console.WriteLine("För högt!");


                }
                else if (gissatalet < tal)
                {
                    Console.WriteLine("För lågt!");
                }
                else 
                {
                    
                    Console.WriteLine($"Grattis det tog dig {gissningar} gissningar");
                }
            }//int med namn gissatalet där värdet börjar med -1 så att man kan gissa på 0. En while loop med gissatalet != tal så att loopen ska köras så
            //länge det rätta talet inte skrivits in. I while loopen så skriver vi Console.Write så vi kan lägga text på samma rad. gissataled = int.parse så
            //att det vi skiver in konverteras till ett heltal. gissningar++ räknar antal gissningar som vi gör. En if sats där if är om gissningarna är för
            //höga än talet man matat in, Console.WriteLine där det står om det är för högt. else if där gissningarna är mindre än  talet och Console.WriteLine
            //som skriver ut om det är för lågt. else när man skrivit in rätt gissning med ConsoleWriteLine med en grattis text som berättar hur många gissningar
            //man gjort. För att kunna mata in ett variabel namn i text aå begöver man lägga in det mellan måsvingar och lägga till $ i början av texten.
                
            

              
        }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hur många heltal vill du skriva in?");
            int heltal = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] antal = new int[heltal];

            Console.WriteLine($"Okej skriv in {heltal} heltal");

            for (int i = 0; i < heltal; i++)
            {
                antal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Här är talen du skrev in:");
            for (int i = 0; i < heltal; i++)
            {
                Console.WriteLine($"Tal {i + 1}: {antal[i]}");
            }
            //Console.WriteLine för att kunna skriva in text. int[] antal är en "tom" array men med new int[]heltal så skapar vi en array.
            //Console.WriteLine för att skriva in text och dollartecken för att kunna lägga in variabel namn i texten så programmet kan läsa den.
            //for loop men int i = 0 för att den ska börja på noll, i < heltal så att loopen körs så länge i är mindre än heltal, i++ så att den
            //lägger till en efter varje gång. i for loopen lägger vi antal[i] som lagrar heltalen i arrayen, int.Parse för att omvandla strängen
            //till heltal, Console.ReadLine för att vänta på det vi skriver in. Console.WriteLine för rad brytning. Console.WriteLine för att kunna
            //skriva in text. for loop men int i = 0 för att det ska börja på noll, i < heltal för att loppen ska fortsätta så länge i är mindre än
            //heltal och i++ för att den ska lägga till en efter varje gång. i loopen skriver vi Console.WriteLine för att lägga till text men i
            //texten har vi {i + 1} som innebär att nummreringen som radar upp det vi skrivit in börjar på 1 istället för noll, {antal[i]} för att heltalen ska börja på plats 1.
            
        }
    }
}

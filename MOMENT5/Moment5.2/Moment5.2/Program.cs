using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] heltal = new int[5];

            for (int i = 0; i < heltal.Length; i++)
            {
                Console.Write("Skriv in heltal: ");
                heltal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            int summa = 0;  

            foreach (int tal in heltal)
            {
                summa += tal;
            }
            Console.WriteLine($"Summan av alla heltal blir: {summa}");
            Console.WriteLine();
            //först int med en array och new int med antal arrayer. for loop med int i = 0 för att det ska börja på noll. i < heltal.length så att
            //koden förstår att den ska fråga så många gånger som antal arrayer finns. i++ för att plussa på en efter varje gång. i loopen skriver vi
            //Console.Writeline så vi kan mata in text och sedan int[i] = int.parse för att den ska omvandla strängen till heltal och Console.ReadLine
            //för att den ska vänta på att vi skriver in heltalet. Console.WrileLine för en radbrytning. int summa = 0 för att skapa en variabel som
            //börjar på noll. en foreach loop som går igenom arrayen och lägger till varje heltal vi matat in på summan.
        }
    }   
}

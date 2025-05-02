using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> namnLista = new List<string>();
            string svar;

            Console.WriteLine("Skriv in namn (max 200). Skriv 'stop' när du vill avsluta");

            while (namnLista.Count <200)
            {
                Console.Write("skriv namn: ");
                svar = Console.ReadLine().Trim();

                if (svar.ToLower() == "stop")
                {
                    break;
                }
                
                namnLista.Add(svar);

            }
            Console.WriteLine();

            Console.Write("Skriv ett namn att söka efter: ");
            string söknamn = Console.ReadLine().Trim();

            int antal = 0;
            foreach (string namn in namnLista)
            {
                if (namn.Equals(söknamn, StringComparison.OrdinalIgnoreCase))
                { 
                    antal++;
                }

            }
            Console.WriteLine($"\nNamnet '{söknamn}' förekommer {antal} gånger i listan.");

            //först skriver vi List<string> namnLista = new List<string>() som är en tom lista och där sparas dom namn vi skriver in. string med
            //namn svar för att spara det vi skriver in. Console.WriteLine för att skriva in text. en while loop där den ska fortsätta så länge som
            //namnLista.Count är mindre än 200, i while loppen skriver vi Console.Write så vi kan skriva text, svar = Console.ReadLine.Trim för att
            //spara det vi skriver in i svar och trimmar bort omödiga mellansalg om det görs när man skriver. if sats där den förstår att oavsät hur
            //vi skriver in stop med små eller stora bokstäver och det är tack vare if (svar.ToLower() = stop. break är stopet som gör så att loopen
            //stoppas. namnLista.Add(svar) är att den lägger till namn i listan om man inte skriver stop. Console.WriteLine för rad brytning.
            //Console.WriteLine så vi kan skriiva in text. string med namn och Console.ReadLine för att den ska vänta på att vi skriver in och 
            //Trim för att ta bort onödiga mellanslag. int med namn antal = 0 för att den ska börja från 0 eller första namn. en foreach loop med 
            //string namn in namnLista för att kunna gå igenom listan där alla sparade namnen finns, i loopen gör vi en if sats med namn.Equals
            //(söknamn, StringComparison.OrdinalIgnoreCase som jämnför om namnen och söknamnet är lika och så att de inte spelar nån roll om vi
            //skrivit olika, alltså men små på ena eller stora på andra. antal++ för att den ska lägga till fler om ett namn nämns flera gånger.
            //Console.WriteLine för att kunna skriva in text men även på raden under och \n gör så att det blir en radbrytning, lägger även till
            //dollartecken så vi kan få in sträng namnen i texten.


        }
    }
}

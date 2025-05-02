using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
      

            string[,] karta = new string[4, 2];
            karta[0, 0] = "Ö";
            karta[1, 0] = "Hav";
            karta[2, 0] = "Hav";
            karta[3, 0] = "Skog";
            karta[0, 1] = "Hav";
            karta[1, 1] = "Hav";
            karta[2, 1] = "Skog";
            karta[3, 1] = "Skog";
            


            for (int y = 0; y < 2; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    Console.Write(karta[x, y] + "\t");
                }
                Console.WriteLine();
            }

            int xKoordinat, yKoordinat;

            while (true)
            {
                Console.Write("\nAnge en X-koordinat (0-3): ");
                if (int.TryParse(Console.ReadLine(), out xKoordinat) && xKoordinat >= 0 && xKoordinat < 4)
                    break;
                Console.WriteLine("Fel ange rätt nummer");
            }

            while (true)
            {
                Console.WriteLine("Ange en Y-koordinat (0-1) ");
                if (int.TryParse(Console.ReadLine(),out yKoordinat) && yKoordinat >= 0 && yKoordinat < 2)
                    break;
                Console.WriteLine("Fel ange rätt nummer");
            }
            Console.WriteLine($"\nPå plats ({xKoordinat}, {yKoordinat}) finns: {karta[xKoordinat, yKoordinat]}");

            Console.ReadLine();
            
            
        }
        //string[,] karta = new string[4, 2] menas med att det är en tvådimensionell array av stränger och en matris med 4 rader och 2 kolumner,
        //under är där själva matrisen är som vi fyller i med värden. yttre for loop med int y = 0 där y ska börja på 0, forsätta så länge y är
        //mindre än 0 och lägga till en efter vatrje gång. inre for loop där int x = 0 ska också börja med 0, forsätta så länge x är mindre än 4
        //och lägga till en efter varje gång. Console.WriteLine med (karta[x, y] så att värdet kan hämtas från rad y och kolumn x, \t är ett tabb
        //tecken så att värdena seppareras när koden körs. rad brytning med Console.WriteLine. int xKoordinat, yKoordinat för att göra 2
        //heltalsvariabler som lagrar koordinaterna som matas in. en while true loop som forsätter att fråga om användaren skrivit in fel
        //x-koordinat. Console.Write för att skriva in text och \n för en rad brytning. if sats med int.TryParse så inmatningen konverteras till
        //ett heltal, Console.ReadLine för att den ska vänta på att vi skriver in, xKoordinat >= 0 && xKoordinat < 4 kontrollerar avv användaren
        //har anget rätt siffra, om allt stämmer med rätt siffra så blir det break; så att loopen avsluttas och vi kan gå vidare. Console.WriteLine
        //med text där vi visar användaren om den skrivit fel koordinat. samma process med ykoordinat. Console.WriteLine med radbrytning och text
        //där vi lagt in alla variabelnamn så att vi kan visa var någonstans i kartan dom inmatade koordinaterna tar användaren. Console.Read för
        //att programmet ska vänta tills man trycker på en valfri knapp innan den stänger sig. 
    }
}

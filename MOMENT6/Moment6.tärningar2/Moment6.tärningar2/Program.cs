using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment6.tärningar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange tärningens antal sidor: ");
            int kast = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange antal tärningskast: ");
            int kasta = int.Parse(Console.ReadLine());

            int summan = KastaTärning(kasta, kast);

            Console.Write($"\nSumman blir: {summan}");

        }

        static int KastaTärning(int kast, int antalSidor)
        {
            Random tärning = new Random();
            int summa = 0;

            for (int i = 0; i < kast; i++)
            {
                int tal = tärning.Next(1, antalSidor + 1);
                summa += tal;
                Console.WriteLine($"kast {i + 1} blir: {tal}");

            }
            return summa;

            //Console.WriteLine så vi kan skriva in text. variabel int med namn kast och int.Parse omvandlar text till heltal, Console.ReadLine för att
            //programmet ska vänta på att vi skriver in nått som sedan lagras i variabel namnet kast. samma procedur under. variabel int med namn
            //summan. methoden KastaTärning skickar in kast och kasta som den sedan retunerar alla kast och sparar i summan. Console.WriteLoine med
            //dollar tecken så vi får in variabel namn i text och \n som gör en radbrytning. static int KastaTärning(int kast, int antalSidor) här
            //skapar vi en metod för att kasta tärning och tar emot två argument vilket är kast och antalsidor, den retunerar sedan int vilket är
            //summan av alla kast. Random tärning = new Random här skapar vi en slumpgenerator som slumpar vilket tal som kommer ut beroende på hur
            //många sidor tärningen har. int summa = 0 för att summan ska börja på noll. for loop där int i = 0 för att i ska börja på noll, i < kast
            //så länge som i är mindre än kast, i++ för att den ska lägga på en efter vaje gång, och i slutet return summa som retunerar summan av alla
            //kast.
        }
    }
}

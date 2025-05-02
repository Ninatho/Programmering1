using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment6.tärningar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ange tärningskast: ");
            

            int summan = KastaTärning(Console.ReadLine());

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

        }
        static int KastaTärning(string sträng)
        {
            string[] array = sträng.Split('T');
            return KastaTärning(int.Parse(array[0]), int.Parse(array[1]));
        }
    }   //Console.Write för att kunna mata in text. variabel int med namn summan där returvärdet från metoden sparas, KastaTärning(Console.ReadLine())
        //anropar metoden KastaTärning och skickar in det vi matat in. Console.Write med dollar tecken så vi får in variabel namnet summan i texten och
        //en \n för rad brytning. skapar en metod där vi anropar KastaTärning där vi lägger int kast som retunerar heltal och variabel namn som anger
        //hur många gånger täningen ska kastas och hur många sidor tärningen har. Random tärning = new Random är en slumpgenerator som genererar
        //tärningskast. int summa = 0 så att summan börjar räkna från noll och den håller koll på den slutgiltiga summan. for loop med int i = 0 för
        //att i ska börja på noll, i < kast körs så länge som i är mindre än kast, i++ lägger på en efter varje gång. int tal = tärning.Next(1,
        //antalSidor + 1 slumpar ett tall mellan 1 och antalsidor. summa += tal lägger till tal i summan så summan sen kan räknas ut. Console.WriteLine
        //med dollar tecken så vi kan få in vilken plats varje kast kommer i och vilket talet av tärnngen som skrivs ut. return summa som retunerar den
        //totala summan av tärningskasten. skapar metoden static int KastaTärning(string sträng) som tar en sträng från formatet xTy som bryter isär
        //den för att få ut antalet kast och antalsidor. string[] array = sträng.Split('T') delar upp strängen vid bokstaven T. int.Parse(array[0]),
        //int.Parse(array[1] konverterar tillexempel 5 till int 5. return KastaTärning anropar den andra metoden med kastatärningar som tar in två
        //heltal istället för en träng.
}

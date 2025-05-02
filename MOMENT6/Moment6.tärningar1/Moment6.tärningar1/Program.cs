using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment6.tärningar1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ange tärningskast: ");
            int kast = int.Parse(Console.ReadLine());

            int summan = KastaTärning(kast);

            Console.Write($"\nSumman blir: {summan}");

        }
        
        static int KastaTärning(int kast)
        {
            Random tärning = new Random();
            int summa = 0;
          
            for (int i = 0; i < kast; i++)
            {
                int tal = tärning.Next(1, 7);
                summa += tal;
                Console.WriteLine($"kast {i + 1} blir: {tal}");
                
            }
            return summa;

            //Jag vet att jag har gjort fel på ett sätt men ändå rätt på ett annat, har gjort dom andra 2 på ordentligt sätt, tänker att det här va
            //ändå mitt sätt att "lösa uppgiften".
            //Console.WriteLine som innehåller text där användaren uppmanas att skriva in tärningskast(siffra).
            //int.Parse för att konvertera siffran till heltal och Console.ReadLinne för att den ska vänta på oss. int summan = KastaTärning(kast)
            //däe KastaTärning(kast) anroppar värdet vi skrev in och lagras i int summa. Console.Write med dollar tecken så vi kan skriva in
            //variabel namnet i texten och \n för att det ska bli en rad brytning. static int KastaTärning(int kast) är metoden som utför själva
            //tärnings kasten. Random tärning = new Random är en slumpgenerator som slumpar antalet på varje sida beroende på hur många sidor
            //tärningen har. int summa = 0 för att den ska räkna från noll. en for loop med int i = 0 ska börja på 0, i < kast för att den ska gå så
            //länge som i är mindre än kast, i++ för att den ska lägga på en efter varje gång. i for loopen har vi int tal = tärning.Next(1, 7) som
            //genererar ett slumpmässigt tal mellan 1 och 6 efterosn vi ger tärningen 6 sidor med en. summa += tal lägger på det slumpade talet i summa. Console.WriteLine me dollar tecken för att kunna få in variabel namn i texten, {i + 1} för att den ska börja på 1 när den visar vilket kast vi gjort. sist ner till return summa för att loppen är klart och retunerar summan till main. 


        }

    }
}

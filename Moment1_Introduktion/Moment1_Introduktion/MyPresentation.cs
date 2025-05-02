using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namnrymdens namn SKALL skilja sig från klassens / filens namn;
namespace Presentation
{
    internal class MyPresentation
    {
        // PUBLIC innebär att metoden blir synlig överallt;
        public void RunMyPresentation()
        {
            // String: Datatypen - text, kan bestå av bokstäver, tecken, tal;
            /* Namnet Peter Svensson
             * tilldelas till variabeln name;
             */
            string name = "Peter Svensson";
            Console.WriteLine("Hej På Dig, " + name);
            // INT- Datatypen heltal: 3, 7, 9, 56;
            int age = 30;
            Console.WriteLine("Du är " + age + " år gammal");

            // Personens ålder om 50 år;
            int futureage = age + 50;
            Console.WriteLine("Om 50 år är Du " + futureage + " år gammal");

            name = "Maria Eriksson";
            Console.WriteLine("Hej På Dig, " + name);
            age = 24;
            Console.WriteLine("Du är " + age + " år gammal");
            futureage = age + 50;
            Console.WriteLine("Om 50 år är Du " + futureage + " år gammal");

            // Flyttal eller decimaltal;
            double weight = 67.5;
            Console.WriteLine("Din vikt är " + weight + " kg");
            double length = 1.75;
            Console.WriteLine("Du är " + length + " meter lång");

            // VAR - betyder vilken datatyp som helst;
            var price = 100.0;
            Console.WriteLine("Varans pris är " + price + " kronor");
            price = 45.78;

            // KONSTANTER: Variabler som tilldelats ett värde EN gång och behåller detta värde hela tiden;
            const string occupation1 = "ingenjör";
            Console.WriteLine("Peter arbetar som " + occupation1);
            const string occupation2 = "lärare";
            Console.WriteLine("Maria arbetar som " + occupation2);
        }
    }
}

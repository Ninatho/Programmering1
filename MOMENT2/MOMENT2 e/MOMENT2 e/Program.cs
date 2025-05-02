using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMENT2_e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in radie för cirkel:");
            string radie = Console.ReadLine();
            double radie1 = double.Parse(radie);
            Console.WriteLine("Cirkelns radie är " + radie);
            double area = Math.PI * radie1;
            Console.WriteLine("Arean för denna cirkel är: " + area);
            double omkrets = 2 * Math.PI * radie1;
            Console.WriteLine("Omkretsen för denna cirkel är: " + omkrets);
            //vi använder oss av Console.WriteLine för att mata in vår text, sedan en string med namn och Console.ReadLine
            //så vi kan mata in en siffra, även en double med double.parse som konverterar double till flyttal 
            //för att kunna få fram cirkelns area så behöver vi Math.PI som är en konstant som visar värdet av PI * tecknet som är gånger 
            //och sedan variabel namnet radie1 så koden vet vad den ska gångra med.
            //sedan för att få ut omkrets så lägger man till 2 * Math.PI * radie1. gångra PI med 2 och gånger radien. vi skapade en double med namnet radie1 så programmet vet vad vi skrivit in för radie.
            //Coonsole.Writeline med text med våra vaiabel namn så slutsatsen kan räkna ut area och omkrets. 



            //Snälla Åke va kvar med oss sen i dom andra kurserna, jag kan baka godsaker till dig varje vecka :)
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMENT2_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ditt förnamn:");
            string dittNamn = Console.ReadLine();
            Console.WriteLine("Mata in ditt efternamn:");
            string dittEfternamn = Console.ReadLine();
            Console.WriteLine();
            string space = " ";
            Console.WriteLine($"Hej {dittNamn + space + dittEfternamn}!");
            //här använder vi oss utav Console.Writeline för att skriva in text som kommer upp när programmet körs.
            //och för att kunna skriva in vilket namn och efternamn som helst så behöver vi en variabel som är string med ett namn.
            //Console.ReadLine skriver man i slutet så koden kan vänta på att man skriver in något.
            //eftersom koden inte gör ett mellanslag själv så man kan lägga till en string med namn och lika med tecken till två dubbel
            //duttar med mellanslag mellan dom.
            // sen för att programmet ska kunna göra en hälsning så blir det Console.Writeline med hälsninsfras och variabel namnen innanför måsvingarna och plus emellan så programmet kan plusa ihop namn, mellanslag och efternamn. $ tecknet behöver man så att koden känner igen att det är namnen i variabel
            // namnen som ska skrivas ut, tar man bort $ tecknet så blir slutsatsen bara "Hej {dittNamn + space + dittEfternamn}!" 
        }
    }
}

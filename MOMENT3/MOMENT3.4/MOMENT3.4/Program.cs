using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMENT3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in ett tal: ");
            string ettTal = Console.ReadLine();
            if (int.TryParse(ettTal, out int talEtt)) ;
            int rest = talEtt % 7;

            if (rest == 0)
            {
                Console.WriteLine("Talet är delbart med 7!");
            }
            else
            {
                 Console.WriteLine($"Talet är ej delbart med 7. Resten blir: {rest}.");
            }
            Console.ReadLine();
            //Console.Write så vi kan skriva in text. En string med namn och Console.ReadLine så den kan vänta på oss
            //if med int.TryParse för att konvertera en string till ett heltal. out int för att variabeln talEtt kommer att lagra
            //resultatet av koverteringen. int rest med talEtt % 7 är till för att koden ska kunna beräkna resten när ett tal delas.
            //rest == 0 skriver man så at koden vet on det blir någon rst över eller inte och om inte, då är det delbart.
        }
    }
}

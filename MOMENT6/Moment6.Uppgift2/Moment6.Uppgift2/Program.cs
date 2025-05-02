using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment6.Uppgift2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ange din inkomst: ");
                int inkomst = int.Parse(Console.ReadLine());
                Console.Write("Ange antal timmar: ");
                int timmar = int.Parse(Console.ReadLine());
                if(inkomst > timmar)
                {
                    Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");

                }
                else
                {
                    break;
                }

                Console.ReadKey();
                //denna lopp forsätter så länge som ens lön är högre än antal timmar man skriver in.
                //när du skriver in att du har fler timmar än lön så bryts loopen.
            }
        }
    }
}

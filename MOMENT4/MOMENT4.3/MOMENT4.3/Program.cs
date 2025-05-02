using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MOMENT4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int y = 10; y > 0; y--)
            {
                for (int x = 0; x < y; x++) 
                {
                    Console.Write("#");
                    Thread.Sleep(100);
                }

                Console.WriteLine();
            }
            
        }//En yttre for loop med int där y börjar med 10 rader, y > 0 så det fortsätter så länge y är större än 0, y-- gör så att det minskas med 1 varje varv.
         //En inre for loop med int där x ska börja med 0, x styr hur många gånger # ska skrivas ut i raden som y styr, x++ gör så att det ökas med 1 varge gång.
         //I den inre for loopen skriver man Console.Write där vi lägger # så våran nässlade loop kan skrivas ut.
         //Thread.Sleep så att när programet körs så skriver den ut lite saktare än allt på en gång.
    }
}
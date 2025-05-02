using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMENT2_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Mata in tal 1:");                 
            string tal1 = Console.ReadLine();                     
            double talet1 = double.Parse(tal1);                   
            Console.WriteLine("Mata in tal 2:");                  
            string tal2 = Console.ReadLine();
            double talet2 = double.Parse(tal2);
             //i Console.WriteLine så matar man in tillexempel text som kommer upp när man test kör programmet.
             // sen lägger vi in en string med namnet tal1 så vi kan skriva in ett tal oavsätt vad det är.
             //sen lägger man till double med ett nytt namn och sedan double.Parse och det tidigare nämnda tal1 som konverterar double till ett flyttal,
             //nu vet koden att talet1 är lika med tal1 och samma med dom andra talen som vi matar in sjävla.
             //sedan gör vi om processen så vi kan skriva in ett till tal.
              
           

            double summan = talet1 + talet2;
            Console.WriteLine("Summan blir: " + summan);
            double produkten = talet1 * talet2;
            Console.WriteLine("Produkten blir: " + produkten);
            double divisionen = talet1 / talet2;
            Console.WriteLine("Divisionen blir: " + divisionen);
            // för att programmet ska kunna skriva ut summan, produkten och divisionen så behöver vi en variabel och i detta fall double
            // med namnen summan, produkten och divisionen och ett lika med tecken till talet1 och talet2.
            // sist men inte minst så skriver vi in Console.WriteLine med text plus variabel namnen så att programmet kan skriva ut resultatet.
            
        
           
            
            


            


        }
    }
}

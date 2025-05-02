using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMENT2_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in grader i celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5 + 32);
            Console.WriteLine($"Temperaturen i fahrenheit blir:{fahrenheit}");
            //för att kunna mata in text i programmet så behövs Console.WriteLine 
            // sedan en variable i form av double med namnet celsius och Convert.ToDouble som konverterar värdet till flyttal och sedan Console.ReadLine
            //för att programmet ska kunna vänta på inmatning 
            //för att kunna omvandla celsius till fahrenheit så behövs celsius * fahrenheit formeln matas in
            //och sendan kan vi mata in våran text med $ i Console.WriteLine och sedan variabel namnet Fahrenheit så
            //programmet vet vad den ska skriva ut.




        }
    }
}

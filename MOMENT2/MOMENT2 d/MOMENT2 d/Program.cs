using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMENT2_d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in grader i celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5 + 32);
            Console.WriteLine($"Temperaturen i fahrenheit blir:{fahrenheit}");
            // här är allt nästan lika dant som den innan, skullnaden är bra att vi skrivit Console.Write istället för Console.Writeline 
            // vad det gör är att när vi ska mata in våran grad så hamnar det på samma rad som texten istället för under texten 
            //som ber oss att mata in grader i celsius.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameOfTheWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Weekday = "Lunes";
            string Weekend = "Sabado";
            string Answer;

            Console.WriteLine("Es dia de semana? ");
            Answer = Console.ReadLine();

            if (Answer == "si")
            {
                Console.WriteLine("Hoy es: " + Weekday);
                Console.Read();
            }
            else { 
            Console.WriteLine("Hoy es: " + Weekend);
                Console.Read();
            }
        }
    }
}

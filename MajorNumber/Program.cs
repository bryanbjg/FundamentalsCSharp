using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int num1;
			int num2;


			Console.WriteLine("Digita el primer numero: ");
			num1 = Convert.ToInt16(Console.ReadLine());

			Console.WriteLine("Digita el segundo numero: ");
			num2 = Convert.ToInt16(Console.ReadLine());
			
			if (num1 > num2)
			{

				Console.WriteLine("El numero mayor es: " + num1);
				Console.Read();


			}
			else
			{
				Console.WriteLine("El numero mayor es: " + num2);
				Console.Read();
			}
		}
    }
}

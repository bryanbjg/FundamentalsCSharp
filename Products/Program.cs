using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string computer = "Dell Inspiron 15";
            string smartphone = "Iphone 12 Pro max";
            string PaymentMethod;
            long AccountNumber;
            int price;

            Console.WriteLine("Cual es el precio de la " + computer + "?");
            price = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Su precio es: " + price);

            Console.WriteLine("Cual sera su metodo de pago: (Efectivo o tarjeta)");
            PaymentMethod = Console.ReadLine();

            if (PaymentMethod == "Efectivo") {

                Console.WriteLine("Gracias por su compra!!");
                Console.Read();
                
            }
            else
            {
                Console.WriteLine("Ingrese el numero de cuenta: ");
                AccountNumber = Convert.ToInt64 (Console.ReadLine());
                Console.WriteLine("Gracias por su compra!!");
                Console.Read();
            }


        }
    }
}

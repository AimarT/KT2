using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Taco Palenque");
            Console.WriteLine("1200 Main ST.");

            Double TotalPrice = 0;

            while (true) 

            {
                Console.WriteLine(" ");
                Console.WriteLine("Enter price of food item [-1 to quit]: ");
                Double enteredPrice = Double.Parse(Console.ReadLine());
                if (enteredPrice == -1)
                {
                    break;
                }
                TotalPrice += enteredPrice;
            }
            Console.WriteLine("-------------------------------------");

            Console.WriteLine($"Subtotal: €{TotalPrice:F2}");
            var gratuity = 0.15 * TotalPrice;
            Console.WriteLine($"15.00 % Gratuity: €{gratuity:F2}");
            var total = TotalPrice - gratuity;
            Console.WriteLine($"Total: € {total:F2}");

        }
    }
}
            


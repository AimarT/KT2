using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltöö nr3
{
    public class Tab
    {
       
        public List<double> lst;

        public void Add(double x)
        {
            lst.Add(x);
        }
    }

    public class Receipt
    {
        public Restaurant restaurant;
        public List<double> lst;

        public Receipt(List<double> lst_, Restaurant restaurant_)
        {
            restaurant = restaurant_;
            lst = lst_;
        }

        public override string ToString()
        {
            Console.WriteLine(restaurant.name);
            Console.WriteLine(restaurant.address);
            Console.WriteLine("----------------------------------------");

            double subtotal = 0;

            foreach (double x in lst)
            {
                Console.WriteLine("Price of food item: " + x.ToString());
                subtotal += x;
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Subtotal: €" + subtotal.ToString());
            double gratuity = 0.15 * subtotal;
            Console.WriteLine("15,00 % Gratuity: €" + gratuity.ToString());
            double total = subtotal - gratuity;
            Console.WriteLine("Total: €" + total.ToString());
        }
    }

    public class Restaurant
    {
        public String name;
        public String address;

        public Restaurant(String name_, String address_)
        {
            name = name_;
            address = address_;
        }

        public Receipt GetReceipt(Tab tab)
        {
            Receipt r(tab.lst, this);
            return r;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Restaurant restaurant = new Restaurant("Taco Palenque", "1200 Main ST.");

            Tab tab = new Tab();

            tab.Add(7.99);
            tab.Add(6.55);
            tab.Add(2.345);

            Receipt receipt = restaurant.GetReceipt(tab);

            Console.Write(receipt);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
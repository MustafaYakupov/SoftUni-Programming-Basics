using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            //var result = 
            if (town == "Sofia" && product == "coffee")
            {
                Console.WriteLine(quantity * 0.50);
            }
            if (town == "Sofia" && product == "water")
            {
                Console.WriteLine(quantity * 0.80);
            }
            if (town == "Sofia" && product == "beer")
            {
                Console.WriteLine(quantity * 1.20);
            }
            if (town == "Sofia" && product == "sweets")
            {
                Console.WriteLine(quantity * 1.45);
            }
            if (town == "Sofia" && product == "peanuts")
            {
                Console.WriteLine(quantity * 1.60);
            }


            if (town == "Plovdiv" && product == "coffee")
            {
                Console.WriteLine(quantity * 0.40);
            }
            if (town == "Plovdiv" && product == "water")
            {
                Console.WriteLine(quantity * 0.70);
            }
            if (town == "Plovdiv" && product == "beer")
            {
                Console.WriteLine(quantity * 1.15);
            }
            if (town == "Plovdiv" && product == "sweets")
            {
                Console.WriteLine(quantity * 1.30);
            }
            if (town == "Plovdiv" && product == "peanuts")
            {
                Console.WriteLine(quantity * 1.50);
            }


            if (town == "Varna" && product == "coffee")
            {
                Console.WriteLine(quantity * 0.45);
            }
            if (town == "Varna" && product == "water")
            {
                Console.WriteLine(quantity * 0.70);
            }
            if (town == "Varna" && product == "beer")
            {
                Console.WriteLine(quantity * 1.10);
            }
            if (town == "Varna" && product == "sweets")
            {
                Console.WriteLine(quantity * 1.35);
            }
            if (town == "Varna" && product == "peanuts")
            {
                Console.WriteLine(quantity * 1.55);
            }
        }
    }
}

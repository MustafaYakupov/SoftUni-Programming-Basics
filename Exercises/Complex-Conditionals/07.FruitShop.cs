using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine().ToLower();
            decimal quantity = decimal.Parse(Console.ReadLine());

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                switch (fruit)
                {
                    case "banana": Console.WriteLine(Math.Round(quantity * 2.50m, 2)); break;
                    case "apple": Console.WriteLine(Math.Round(quantity * 1.20m, 2)); break;
                    case "orange": Console.WriteLine(Math.Round(quantity * 0.85m, 2)); break;
                    case "grapefruit": Console.WriteLine(Math.Round(quantity * 1.45m, 2)); break;
                    case "kiwi": Console.WriteLine(Math.Round(quantity * 2.70m, 2)); break;
                    case "pineapple": Console.WriteLine(Math.Round(quantity * 5.50m, 2)); break;
                    case "grapes": Console.WriteLine(Math.Round(quantity * 3.85m, 2)); break;
                    default: Console.WriteLine("error"); break;
                }

            }
            else if (day == "saturday" || day == "sunday")
            {
                switch (fruit)
                {
                    case "banana": Console.WriteLine(Math.Round(quantity * 2.70m, 2)); break;
                    case "apple": Console.WriteLine(Math.Round(quantity * 1.25m, 2)); break;
                    case "orange": Console.WriteLine(Math.Round(quantity * 0.90m, 2)); break;
                    case "grapefruit": Console.WriteLine(Math.Round(quantity * 1.60m, 2)); break;
                    case "kiwi": Console.WriteLine(Math.Round(quantity * 3.00m, 2)); break;
                    case "pineapple": Console.WriteLine(Math.Round(quantity * 5.60m, 2)); break;
                    case "grapes": Console.WriteLine(Math.Round(quantity * 4.20m, 2)); break;
                    default: Console.WriteLine("error"); break;
                }

            }
            else { Console.WriteLine("error"); }
        }
        }
    }

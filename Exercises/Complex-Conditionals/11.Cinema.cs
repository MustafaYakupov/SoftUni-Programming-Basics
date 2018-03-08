using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int colons = int.Parse(Console.ReadLine());
            var room = rows * colons;
            var price = 0.00;
            



            switch (type)
            {
                case "premiere":
                    price = 12.00;
                    var money = room * price;
                    Console.WriteLine($"{money:f2}");break;
                case "normal":
                    price = 7.50;
                    var nMoney = room * price;
                    Console.WriteLine($"{nMoney:f2}"); break;
                case "discount":
                    price = 5.00;
                    var dMoney = room * price;
                    Console.WriteLine($"{dMoney:f2}"); break;
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfRectBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            bool checkYRange = y >= y1 && y <= y2;
            bool checkXRange = x >= x1 && x <= x2;
            bool isOnYSides = (y == y1 && checkXRange) || (y == y2 && checkXRange);
            bool isOnXSides = (x == x1 && checkYRange) || (x == x2 && checkYRange);



            if (isOnXSides || isOnYSides)
            {
                Console.WriteLine("Border");
            }
        
           
           
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            var insideHorisontalRectangular = (x > 0 && x < 3 * h) && (y > 0 && y < h);
            var insideVerticalRectangular = (x > h && x < 2 * h) && (y > h && y < 4 * h);
            var onMiddleSide = (x > h && x < 2 * h) && y == h;
            var onBorder1 = ((x == 0 || x == 3 * h) && (y >= 0 && y <= h)) ||
                             ((y == 0 || y == h) && (x >= 0 && x <= 3 * h));
            var onBorder2 = ((x == h || x == 2 * h) && (y >= h && y <= 4 * h)) ||
                             ((y == 4 || y == 4 * h) && (x >= h && x <= 2 * h));



            if (insideHorisontalRectangular || insideVerticalRectangular || onMiddleSide)
            {
                Console.WriteLine("inside");
            }
            else if (onBorder1 || onBorder2)
            {
                Console.WriteLine("border");
            }
            else 
            {
                Console.WriteLine("outside");
            }
        }
    }
}

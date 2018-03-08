using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int celebrations = int.Parse(Console.ReadLine());
            int weekendsHome = int.Parse(Console.ReadLine());

            var weekendsInSofia = 48 - weekendsHome;
            var gamesInSofia = weekendsInSofia * (3.0/4);
            var gamesInHome = weekendsHome;
            var gamesInCelebrationDays = celebrations * (2.0/3);
            var allGames = gamesInSofia + gamesInHome + gamesInCelebrationDays;

            if (year == "leap")
            {
                allGames = allGames + (0.15 * allGames);
                Console.WriteLine("{0}", Math.Truncate(allGames));
            }
            else if (year == "normal")
            {
                Console.WriteLine(Math.Truncate(allGames));
            }
        }
    }
}

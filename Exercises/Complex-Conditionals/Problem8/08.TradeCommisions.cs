using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCommisions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            var commision = 0.0;

            if (town != "sofia" && town != "varna" && town != "plovdiv" || sales < 0) { }
            else
            {


                if (sales >= 0 && sales <= 500)
                {
                    if (town == "sofia") commision = 0.05;

                    commision = sales * 0.05;
                    Console.WriteLine($"{commision}:f2");
                }



                else if (town == "varna") commision = 0.045;
            }
                    commision = sales * 0.05;
                    Console.WriteLine($"{commision}:f2");
                } 
                else if (town == "plovdiv") commision = 0.055;
                }
                else if (sales < 0 && sales <= 1000)
                {
                    if (town == "sofia") commision = 0.07;
                    else if (town == "varna") commision = 0.075;
                    else if (town == "plovdiv") commision = 0.08;
                }
                else if (sales < 0 && sales <= 10000)
                {
                    if (town == "sofia") commision = 0.08;
                    else if (town == "varna") commision = 0.10;
                    else if (town == "plovdiv") commision = 0.12;
                }
                else if (sales > 10000)
                {
                    if (town == "sofia") commision = 0.12;
                    else if (town == "varna") commision = 0.13;
                    else if (town == "plovdiv") commision = 0.145;
                }

            }
        }


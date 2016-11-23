using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose part of homework:\n1)Taxi\n2)Extra");
            int q = int.Parse(Console.ReadLine());
             switch(q) 
            {
                case (1) :
                    {
                        Console.WriteLine("Please enter distance in km");
                        double dist = double.Parse(Console.ReadLine()),tar;
                        if (dist <= 10) tar = 5;
                        else 
                           if (dist <= 20) tar = 4;
                           else tar = 3;
                        const int call = 30;
                        double rez = call + (dist * tar);
                        Console.WriteLine("Please enter part of day (day/night)");
                        string day = Console.ReadLine();
                        day.ToUpper();
                        if (day == "NIGHT") rez /= 2;
                        Console.WriteLine("Rezult for your trip is:" + rez);
                    }
                    break;
                case (2):
                    {
                        Console.WriteLine("Enter number of lines");
                        int k = int.Parse(Console.ReadLine());
                        int left, right,buttom;
                        buttom = 1 + (k - 1) * 2;
                        if (buttom % 2 == 0) left = (buttom / 2) + 1;
                        else left = (buttom / 2);
                        right = left;
                        for (int i = 0; i < k; i++)
                        {
                            for (int y = 0; y <= right; y++)
                            {
                                if (y >= left && y <= right)
                                {
                                    Console.Write("^");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.WriteLine();
                            left -= 1;
                            right += 1;
                        }
                    }
                    break;
            }
        }
    }
}

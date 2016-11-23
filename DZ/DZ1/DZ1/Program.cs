using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choise;
            Console.WriteLine("Please enter number of homework:");
            Console.WriteLine("1)Averange mark for 3 subjects");
            Console.WriteLine("2)Length of circle ");
            choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    {
                        Console.WriteLine("Please enter mark for first subject");
                        int mark1, mark2, mark3;
                        mark1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter mark for second subject");
                        mark2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter mark for third subject");
                        mark3 = int.Parse(Console.ReadLine());
                        float aver;
                        aver = (float)(mark1 + mark2 + mark3) / 3;
                        Console.WriteLine("Averange mark for this subjects is " + aver);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Please enter radius of circle");
                        int rad = int.Parse(Console.ReadLine());
                        const double pi = 3.14159;
                        float dov = (float)(rad * pi * 2);
                        Console.WriteLine("Length of circle is " + dov);
                    }
                    break;
            }

        }
    }
}
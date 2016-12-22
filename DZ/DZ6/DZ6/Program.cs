using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 5, 3, 7, 8, 3, 6, 5, 9, 11 };
            Student st1=new Student("Ivan Bondar", "Some adress 99", mas);
            float avg= st1.CalcAvg();
            st1.PrintInfo();
            Runner[] run1 = GetInfo();
            Console.WriteLine(run1[FindBest(run1)]);
        }

        static Runner[] GetInfo()
        {
            Runner[] p1 = new Runner[0];
            Console.WriteLine("If you don`t want to write informatoin enter 0\nIf you want to write new runner, enter 1");
            int action = int.Parse(Console.ReadLine());
            int i = 0;
            while (action != 0)
            {
                if (action == 1)
                {
                    Console.WriteLine("Please enter full name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please enter age");
                    float time = float.Parse(Console.ReadLine());
                    Array.Resize(ref p1, p1.Length + 1);
                    p1[i] = new Runner(name, time);
                    i++;
                }
                Console.WriteLine("If you don`t want to write informatoin enter 0\nIf you want to write new runner, enter 1");
                action = int.Parse(Console.ReadLine());
            }
            return p1;
        }

        static void PrintForArr(Runner[] mas )
        {
            foreach(Runner el in mas)
            {
                Console.WriteLine(el);
            }
        }

        static int FindBest(Runner[] mas)
        {
            float minTime = float.MaxValue;
            int minInd=0;
            for(int i=0;i<mas.Length;i++)
            {
                if(mas[i].Time<minTime)
                {
                    minTime = mas[i].Time;
                    minInd = i;
                }
            }
            return minInd;
        }

    }
}

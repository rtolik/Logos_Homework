using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7
{
    class Program
    {
        static void Main(string[] args)
        {
            Fractions num = new Fractions(12, 3.14f);
            Console.WriteLine(num);
            Fractions num2 = new Fractions(10, 4.2f);
            Console.WriteLine(num2);
            Fractions result = Fractions.Sum(num, num2);
            Console.WriteLine("Result of sum: " + result);
            result = Fractions.Difference(num, num2);
            Console.WriteLine("Result of difference: " + result);
            result = Fractions.Multiplication(num, num2);
            Console.WriteLine("Result of multiplaction: " + result);
            Fractions.Equal(num, num2);
           Trapeze[] tr1 = new Trapeze[0];
            int action = 5;
            int i = 0;
            float avgArea = 0;
            while (action != 0)
            {
                Console.WriteLine("If you want to add new trapeze, enter \"1\" If you want to stop, enter \"0\"");
                action = int.Parse(Console.ReadLine());
                if (action == 1)
                {
                    Dot lup = new Dot(6, 9);
                    Dot rup = new Dot(12, 9);
                    Dot ldn = new Dot(2, 5);
                    Dot rdn = new Dot(16, 5);
                    Array.Resize<Trapeze>(ref tr1, tr1.Length + 1);
                    tr1[i] = new Trapeze(lup, rup, ldn, rdn);
                    avgArea += tr1[i].Area;
                    i++;
                }
                if (action == 0)
                    break;
            }
            avgArea = avgArea / i;
            for(int y=0;y<tr1.Length;y++)
            {
                Console.WriteLine("Trapeze № " + (y + 1));
                Console.WriteLine(tr1[y]);
            }
            Console.WriteLine("All trapezes, where area is more than avarange");
            for (int y = 0; y < tr1.Length; y++)
            {
                if (tr1[y].Area > avgArea)
                {
                    Console.WriteLine("Trapeze № " + (y + 1));
                    Console.WriteLine(tr1[y]);
                }
            }
            Vector[] v1 = new Vector[0];
            i = 0;
            action=5; 
            while (action != 0)
            {
                Console.WriteLine("If you want to add new trapeze, enter \"1\" If you want to stop, enter \"0\"");
                action = int.Parse(Console.ReadLine());
                if (action == 1)
                {
                    Array.Resize(ref v1, v1.Length + 1);
                    Console.WriteLine("Enter X");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Y");
                    int y = int.Parse(Console.ReadLine());
                    v1[i] = new Vector(x, y);
                    i++;
                }
                if(action==0)
                {
                    break;
                }
            }
            Console.WriteLine("All vectors:");
            for(int y=0;y<v1.Length;y++)
            {
                Console.WriteLine("Vector № " + (y + 1));
                Console.WriteLine(v1[y]);
            }
            Console.WriteLine("Vectors, where length > 5");
            for (int y = 0; y < v1.Length; y++)
            {
                if (v1[y].VLength > 5)
                {
                    Console.WriteLine("Vector № " + (y + 1));
                    Console.WriteLine(v1[y]);
                }
            }
        }
    }
}

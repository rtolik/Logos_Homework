using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose part of programm: \n 1) Part1 \n 2) Part2 \n 3) Part3");
            int q = int.Parse(Console.ReadLine());
            switch (q)
            {
                case (1):
                    {

                        Console.WriteLine("Please enter size of array");
                        int size = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter elements in array");
                        int[] arr = new int[size];
                        for (int i = 0; i < size; i++)
                        {
                            arr[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Plaese enter number to serch");
                        int num = int.Parse(Console.ReadLine());
                        int ind = SearchIndex(arr, num);
                        if (ind == -1)
                            Console.WriteLine("Sorry, there is no such element");
                        else
                            Console.WriteLine("The plase of this elemnt is: " + (ind + 1));
                    }
                    break;
                case (2):
                    {
                        Console.WriteLine("Plase enter some phrase");
                        string phr = Console.ReadLine();
                        Console.WriteLine("Please enter amount numbers to count sum:");
                        int size=int.Parse(Console.ReadLine());
                        int[] numbers = new int[size];
                        Console.WriteLine("Please enter arguments");
                        for(int i=0;i<size;i++)
                        {
                            numbers[i] = int.Parse(Console.ReadLine());
                        }
                        OutText(phr, numbers);
                    }
                    break;
                case (3):
                    {
                        Console.WriteLine("Pelase enter size of array:XxY");
                        int row = int.Parse(Console.ReadLine());
                        int col = int.Parse(Console.ReadLine());
                        int[,] arr= new int[row, col];
                        Progression(ref arr, row, col);
                        Console.WriteLine("This array`s elements are:");
                        for (int i = 0; i < row; i++)
                        {
                            for (int y = 0; y < col; y++)
                            {
                                Console.Write(arr[i, y] + "\t");

                            }
                            Console.WriteLine();
                        }
                        break;
                    }
            }
        }

        static int SearchIndex(int[] mas, int n)
        {
            for(int i=0;i<mas.Length;i++)
            {
                if (mas[i] == n) return i;
            }
            return -1;
        } 

        static void OutText(string phrase, params int []nums)
        {
            int sum = 0;
            for(int i=0;i<nums.Length;i++)
            {
                sum += nums[i];
            }
            if (sum > 20)
                Console.WriteLine(phrase);
            else
                Console.WriteLine("Surry, sum is " + sum);
        }

        static void Progression(ref int[,]mas,int row,int col)
        {
            for(int i=0;i<row;i++)
            {
                for(int y=0;y<col;y++)
                {
                    mas[i, y] = i * y;
                }
            }
        }
    }
}

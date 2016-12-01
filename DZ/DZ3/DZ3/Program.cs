using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose part of programm: \n 1) Part1 \n 2) Part2 \n 3) Part3");
            int q=int.Parse(Console.ReadLine());
            switch (q)
            {
                case (1):
                    {
                        Console.WriteLine("Please enter size of matrix");
                        int size =int.Parse(Console.ReadLine());
                        int[,] matrix = new int[size,size];
                        Console.WriteLine("Please enter elements to this matrix");
                        for (int i=0;i<size;i++)
                        {
                            for (int y=0;y<size;y++)
                            {
                                matrix[i,y]=int.Parse(Console.ReadLine());
                            }
                        }
                        int main=0, diag=0;
                        for (int i = 0; i < size; i++)
                        {
                            for (int y = 0; y < size; y++)
                            {
                                Console.Write("\t" + matrix[i, y]);

                                if (i==y)
                                {
                                    main += matrix[i, y];
                                }
                               
                                if (i == (size) - (y + 1))
                                {
                                    diag += matrix[i, y];
                                }
                            
                            }
                            Console.WriteLine();
                        }
                      
                        Console.WriteLine("Sum of elements on the main diagonal is: {0}", main);
                        Console.WriteLine("Sum of elements on the secondary diagonal is: {0}", diag);
                    }
                    break;
                case (2):
                    {
                        string word;
                        Console.WriteLine("Please enter word to check it");
                        word=Console.ReadLine();
                        int end = word.Length -1,mid;
                        mid = (int)(Math.Round((double)(end/2)));
                        bool check=true;
                        for(int i=0;i<mid;i++)
                        {
                            if (word[i] == word[end])
                            {
                                check = true;
                            }
                            else
                            {
                                check = false;
                                break;
                            }
                            end--;
                        }
                        if (check)
                        {
                            Console.WriteLine("This word is polindrom");
                        }
                        else
                        {
                            Console.WriteLine("This word is not polindrom");
                        }
                    }
                    break;
                case (3):
                    {
                        Console.WriteLine("Please enter size of two matrix:\n1) Array1:XxY");
                        int row = int.Parse(Console.ReadLine());
                        int col = int.Parse(Console.ReadLine());
                        int[,] arr1 = new int[row,col];
                        Console.WriteLine("Please enter elements for matrix");
                        for(int i=0;i<row;i++)
                        {
                            for(int y=0;y<col;y++)
                            {
                                arr1[i,y]=int.Parse(Console.ReadLine());
                            }
                        }
                        Console.WriteLine("2) Array2:XxY");
                        int row2 = int.Parse(Console.ReadLine());
                        int col2 = int.Parse(Console.ReadLine());
                        int[,] arr2 = new int[row2, col2];
                        for (int i = 0; i < row; i++)
                        {
                            for (int y = 0; y < col; y++)
                            {
                                arr2[i, y] = int.Parse(Console.ReadLine());
                            }
                        }
                        if (col==col2 && row==row2)
                        {
                            int pers = 100 / (row * col), equel = 0;
                            for(int i=0;i<row;i++)
                            {
                                for(int y=0;y<col;y++)
                                {
                                    if (arr1[i, y] == arr2[i, y]) equel += pers;
                                }
                            }
                            Console.WriteLine("This arrays are equel in {0}%", equel);
                        }
                        else
                        {
                            Console.WriteLine("This arrays are equel in 0%");
                        }
                    }
                    break;
            }
        }
    }
}

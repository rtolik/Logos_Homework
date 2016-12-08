using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose part of programm: \n 1) Part1 \n 2) Part2 \n 3) Part3");
            int choise=int.Parse(Console.ReadLine());
            switch (choise)
            {
                case (1):
                    {

                        House flat1 = new House(2, 3200f, 65.3f);
                        Console.WriteLine("Info for flat1");
                        flat1.PrintInfo();
                        flat1.PrintM2();
                        House flat2 = new House(1200f, 32.3f);
                        Console.WriteLine("Info for flat2");
                        flat2.PrintInfo();
                        flat2.PrintM2();
                    }
                    break;

                case (2):
                    {
                        Product[] products = new Product[3];
                        Console.WriteLine("Please enter 6 products");
                        for(int i=0;i<3;i++)
                        {
                            Console.WriteLine("Please enter category");
                            string category = Console.ReadLine();
                            category = category.ToLower();
                            Console.WriteLine("Please enter name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Please enter price");
                            float price = float.Parse(Console.ReadLine());
                            products[i] = new Product(name, category, price);
                        }
                        Console.WriteLine("Information for category 'for children':");
                        for(int i=0;i<3;i++)
                        {
                            if(products[i].category=="for children")
                            {
                                products[i].PrintInfo();
                            }
                        }
                    }
                    break;

                case (3):
                    {
                        Person man1 = new Person("John", "Malevich", 1.25f, 13, "Male", true);
                        man1.PrintInfo();
                    }
                    break;
            }
        }
    }
}

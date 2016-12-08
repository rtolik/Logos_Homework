using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    class Product
    {
        public float price;
        public string category;
        public string name;

        public Product (string newName="unknown",string newCategory="unknown",float newPrice=0f)
        {
            price = newPrice;
            category = newCategory;
            name = newName;
        }

        public void PrintInfo ()
        {
            Console.WriteLine("Product category : {0}\nProduct name: {1}\nPrice: {2}", category, name, price);
        } 
    }
}

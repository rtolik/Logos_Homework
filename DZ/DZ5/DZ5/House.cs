using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    class House
    {
        private int numOfRooms;
        private float price;
        private float area;

        int  cRoom = 1;
        float cPrice = 1f;
        float carea = 1f;

        public House (int newRoom=1,float newPrice=0,float newArea=0 )
        {
            numOfRooms = newRoom;
            price = newPrice;
            area = newArea;
        }

        public House (float newPrice=0,float newArea=0)
        {
            numOfRooms = cRoom;
            price = newPrice;
            area = newArea;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Number of rooms: {0}\nPrice: {1}\nArea: {2}", numOfRooms, price, area);
        }

        public void PrintM2()
        {
            Console.WriteLine("Price for 1 m2: {0}", area / price);
        }

    }
}

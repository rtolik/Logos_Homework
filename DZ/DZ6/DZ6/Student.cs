using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6
{
    class Student
    {
        private string FullName { get; set; }
        private string HomeAdr { get; set; }
        private float Avg { get; }
        public int[] Marks { get; }

        public Student(string name,string homeAdres,int [] nMarks)
        {
            Marks = nMarks;
            FullName = name;
            HomeAdr = homeAdres;
        }

        public float CalcAvg()
        {
            int sum = 0;
            for(int i=0;i<Marks.Length;i++)
            {
                sum += Marks[i];
            }
            return sum/Marks.Length;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + FullName + "\nHome adress: " + HomeAdr + "\nMarks: ");
            foreach(int el in Marks)
            {
                Console.Write(el + "\t");
            }
            Console.WriteLine("\nAvarage for these marks: " + CalcAvg()); 
        }
    }
}

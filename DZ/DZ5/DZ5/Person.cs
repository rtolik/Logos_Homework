using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    class Person
    {
        public string name;
        public string surname;
        public float heigh;
        public int age;
        public bool male;
        public bool isAlive;

        const string cNameSur = "Unknown";
        const float cHeigh = 1f;
        const int cAge=1;
        const bool cMale = true;
        const bool cAlive = true;

        public Person (string nName,string nSurname,float nHeigh, int nAge,string nMale,bool nIsAlive)
        {
            name = nName;
            surname = nSurname;
            heigh = nHeigh;
            age = nAge;
            if (nMale == "Male")
                male = true;
            else
                male = false;
            isAlive = nIsAlive;
        }

        public Person(string nSurname, float nHeigh, int nAge) : this(cNameSur, nSurname, nHeigh, nAge, "Male", cAlive)
        { }

        public void PrintInfo()
        {
            Console.WriteLine("Name: {0}\nSurname: {1}\nHeigh: {2}\nAge: {3}\nMale: {4}\nIs alive: {5}", name, surname, heigh, age, male == true ? "Male" : "Female", isAlive);
        } 
    }
}

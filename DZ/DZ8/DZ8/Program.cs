using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DZ8
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            int act = 3;
            while(act!=0)
            {
                Console.WriteLine("If you want to add new number, enter \"1\" If you want to stop, enter \"0\"");
                act = int.Parse(Console.ReadLine());
                if(act==1)
                {
                    Console.WriteLine("Please enter the number");
                    s.Push(int.Parse(Console.ReadLine()));
                }
                if (act == 0)
                    break;
            }
            int numOfOne=0;
            while(s.Count>0)
            {
                if (s.Pop() == 1)
                    numOfOne++;
            }
            if (numOfOne % 2 == 0)
                Console.WriteLine("There is pair number of 1 in your stack");
            else
                Console.WriteLine("There is not pair number of 1 in your stack");
            List<string> words = new List<string>();
            act = 3;
            int numOfIF=0;
            while (act != 0)
            {
                Console.WriteLine("If you want to add new word, enter \"1\" If you want to stop, enter \"0\"");
                act = int.Parse(Console.ReadLine());
                if(act==1)
                {
                    Console.WriteLine("Please enter word:");
                    string word = Console.ReadLine();
                    words.Add(word);
                    if (word == "IF")
                        numOfIF++;
                }
                if(act==0)
                {
                    break;
                }
            }
            foreach(string el in words)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine("Word 'IF' is in this List : {0} times", numOfIF);
        }
    }
}

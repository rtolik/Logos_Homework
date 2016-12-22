using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6
{
    class Runner
    {
        public string FullName { get; }
        public float Time { get; }

        public Runner(string nName,float nTime)
        {
            FullName = nName;
            Time = nTime;
        }

        public override string ToString()
        {
            return "Name: " + FullName + "\nTime for distanse: " + Time;
        }
    }
}

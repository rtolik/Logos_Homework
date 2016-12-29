using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7
{
    class Vector
    {
        public int X { get; }
        public int Y { get; }
        public float VLength { get; }

        public Vector (int x,int y)
        {
            X = x;
            Y = y;
            VLength = (float)Math.Sqrt(X * X + Y * Y);
        }

        public override string ToString()
        {
            return "("+X+";"+Y+")"+"\nLength: "+VLength;
        }
    }
}

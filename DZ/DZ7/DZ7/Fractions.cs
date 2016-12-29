using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7
{
    class Fractions
    {
        int BefDot { get; set; }
        float AftDot { get; set; }

        public Fractions (int bd,float ad)
        {
            if(ad>1)
            {
                int more = (int)ad;
                ad -= more;
                bd += more;
            }
            BefDot = bd;
            AftDot = ad;
        }

        static public Fractions Sum(Fractions num1,Fractions num2)
        {
            int bd;
            float ad;
            ad = num1.AftDot + num2.AftDot;
            bd = num1.BefDot + num2.BefDot;
            if(ad>1)
            {
                bd++;
                ad--;
            }
            Fractions result = new Fractions(bd, ad);
            return result;
        }

        public override string ToString()
        {
            return "Before dot  " + BefDot + "   After dot   " + AftDot;
        }
        static public Fractions Difference(Fractions num1, Fractions num2)
        {
            int bd;
            float ad;
            ad = num1.AftDot - num2.AftDot;
            bd = num1.BefDot - num2.BefDot;
            if (ad < 0)
            {
                bd--;
                ad++;
            }
            Fractions result = new Fractions(bd, ad);
            return result;
        }

        static public Fractions Multiplication (Fractions num1,Fractions num2)
        {
            int bd;
            float ad;
            ad = num1.AftDot * num2.AftDot;
            bd = num1.BefDot * num2.BefDot;
            Fractions result = new Fractions(bd, ad);
            return result;
        }
        
        static public void Equal(Fractions num1, Fractions num2)
        {
            Fractions check = Difference(num1, num2);
            if (check.BefDot > 0)
                Console.WriteLine("Number 1 > number 2");
            if (check.BefDot < 0)
                Console.WriteLine("Number 1 < number 2");
            if (check.BefDot == 0 && check.AftDot > 0)
                Console.WriteLine("Number 1 > number 2");
            if(check.BefDot==0 && check.AftDot<0)
                Console.WriteLine("Number 1 < number 2");
            if(check.BefDot==0 && check.AftDot==0)
                Console.WriteLine("Number 1 = number 2");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7
{
    class Trapeze:Figure
    {
        private Dot leftUp, rightUp, leftDown, rightDown;
        public float Area { get; set; }
        public float Perimeter { get; set; }
        private float up, buttom, left, right;

        public Trapeze(Dot leftUp,Dot rightUp,Dot leftDown,Dot rightDown)
        {
            this.leftUp = leftUp;
            this.rightUp = rightUp;
            this.leftDown = leftDown;
            this.rightDown = rightDown;
            FindSides(out up, out buttom, out left, out right);
            float h=FindHeigh();
            Area = ((up + buttom) / 2) * h;
            Perimeter = up + buttom + left + right;
        }

        public override string ToString()
        {
            return "Left Up: "+leftUp+"\nRight Up: " +rightUp+"\nLeft down: "+leftDown+"\nRight down: "+rightDown+ "\nSides of trapeze: \nup: "+ up+"\nbuttom: "+ buttom+"\nleft: "+ left+"\nright: " +right+"\nArea: "+Area+"\nPerimeter"+Perimeter;
        }
        
        public void FindSides(out float upBase,out float buttom,out float left,out float right)
        {
            upBase = rightUp.X - leftUp.X;
            buttom = rightDown.X - leftDown.X;
            Dot leftH = new Dot(leftUp.X, leftDown.Y);
            left = (float)Math.Sqrt(Math.Pow((leftH.X - leftDown.X), 2) + Math.Pow((leftUp.Y - leftDown.Y), 2));
            Dot rightH = new Dot(rightUp.X, rightDown.Y);
            right = (float)Math.Sqrt(Math.Pow((rightDown.X -rightH.X), 2) + Math.Pow((rightUp.Y - rightDown.Y), 2));
        }

        public float FindHeigh()
        {
            Dot leftH = new Dot(leftUp.X, leftDown.Y);
            return leftH.X - leftDown.X;
        }

        public bool IsIsosceles()
        {
            float up, buttom, left, right;
            FindSides(out up, out buttom, out left, out right);
            if (leftUp.Y - leftDown.Y == rightUp.Y - rightDown.Y)
            {
                if (left == right)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}

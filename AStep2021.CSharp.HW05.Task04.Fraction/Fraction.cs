using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW05.Task04.Fraction
{
    
    class Fraction
    {
        private int x;
        private int y;

        public Fraction(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            Reduction();
            string valStr = x +"/" + y;
            return valStr;
        }

        public void Reduction()
        {
            int nod = Nod();
            Console.WriteLine(this);
            if (nod != 0) {
                x /= nod;
                y /= nod;             
                Reduction();
            }           
        }
        private int Nod()
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            while (y != 0 && x != 0)
            {
                if (x % y > 0)
                {
                    var temp = x;
                    x = y;
                    y = temp % y;
                }
                else break;
            }
            if (y != 0 && x != 0) return y;
            return 0;
        }



        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(
                a.x * b.x,
                a.y * b.y
                );
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(
               a.x * b.y,
               a.y * b.x
               );
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(
                a.x * b.y - b.x * a.y,
                a.y * b.y);
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(
               a.x * b.y + b.x * a.y,
               a.y * b.y);
        }

        public static Fraction operator *(double a, Fraction b)
        {
            Fraction f = new Fraction(b.y, b.y);
            return f * b;
             
        }
        public static Fraction operator *(Fraction b, double a)
        {
            return a * b;
        }

        public static Fraction operator -(Fraction a, double b)
        {
            Fraction f = new Fraction(a.y, a.y);
            return a - f;
        }
        public static Fraction operator -(double b, Fraction a)
        {          
            Fraction f = new Fraction(a.y, a.y);
            return f - a;
        }

        public static Fraction operator +(Fraction a, double b)
        {
            Fraction f = new Fraction(a.y, a.y);
            return a + f;
        }
        public static Fraction operator +( double b, Fraction a)
        {
            Fraction f = new Fraction(a.y, a.y);
            return f + a;
        }


    }
}

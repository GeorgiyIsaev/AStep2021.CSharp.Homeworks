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
            string valStr = "("+x + "/" + y+")";
            return valStr;
        }
        public void Reduction()
        {
            int nod = Nod();          
            if (nod > 1)
            {
                x /= nod;
                y /= nod;
                Reduction();
            }
        }
        private int Nod()
        {
            int a = Math.Abs(x);
            int b = Math.Abs(y);
            int min;
            if (a > b) min = b;
            else min = a;
            int i = min;
            int c = 0;
            while (i > 0 && c == 0)
            {
                if ((a % i == 0) && (b % i == 0))
                    c = i;
                i--;
            }
            return c;          
        }


        /*Математика*/
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

        //public static Fraction operator *(int a, Fraction b)
        //{
        //    Fraction f = new Fraction(b.y, b.y);
        //    return f * b;

        //}
        //public static Fraction operator *(Fraction b, int a)
        //{
        //    return a * b;
        //}

        //public static Fraction operator -(Fraction a, int b)
        //{
        //    Fraction f = new Fraction(a.y, a.y);
        //    return a - f;
        //}
        //public static Fraction operator -(int b, Fraction a)
        //{
        //    Fraction f = new Fraction(a.y, a.y);
        //    return f - a;
        //}

        //public static Fraction operator +(Fraction a, int b)
        //{
        //    Fraction f = new Fraction(a.y, a.y);
        //    return a + f;
        //}
        //public static Fraction operator +(int b, Fraction a)
        //{
        //    Fraction f = new Fraction(a.y, a.y);
        //    return f + a;
        //}
        public static implicit operator Fraction(int x)
        {
            return new Fraction(x, 1);
        }
        public static implicit operator Fraction(double x)
        {        
            return new Fraction (Convert.ToInt32(1000 * x),1000);
        }
        /*Сравнения*/

        public static bool operator ==(Fraction a, Fraction b)
        {
            return ((a.x * b.y) == (b.x * a.y));
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            return ((a.x * b.y) > (b.x * a.y));
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            return !(a > b);
        }
        public static bool operator <=(Fraction a, Fraction b)
        {
            return ((a.x * b.y) <= (b.x * a.y));
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            return !(a <= b);
        }

        /*Оператор true и false (Будит true  если число положительное)*/
        public static bool operator false(Fraction a)
        {
            return ((a.x <= 0 && a.y >= 0) || (a.x >= 0 && a.y <= 0));
        }
        public static bool operator true(Fraction a)
        {
            return ((a.x >= 0 && a.y >= 0) || (a.x <= 0 && a.y <= 0));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW05.Task03.Complex
{
    class Complex
    {
        private double x;
        private double y;

        public Complex(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            string valStr = Math.Round(x, 2) + " i" + y;
            return valStr;
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(
                a.x * b.x - a.y * b.y, 
                a.y * b.x + a.x * b.y
                );
        }
        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex(
                (a.x * b.x + a.y * b.y) / (b.x * b.x + b.y * b.y), 
                (a.y * b.x - a.x * b.y) / (b.x * b.x + b.y * b.y)
                );
        }

        public static Complex operator *(double a, Complex b)
        {
            return new Complex(a * b.x, a * b.y);
        }
        public static Complex operator *(Complex b, double a)
        {
            return a * b;
        }             

        public static Complex operator -(Complex a, double b)
        {
            return new Complex(a.x - b, a.y - b);
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.x - b.x, a.y - b.y);
        }

        public static Complex operator +(Complex a, double b)
        {
            return new Complex(a.x + b, a.y + b);
        }
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.x + b.x, a.y + b.y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

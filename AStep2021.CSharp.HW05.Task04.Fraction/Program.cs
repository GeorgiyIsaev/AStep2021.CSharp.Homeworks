using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW05.Task04.Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(3, 4);
            Console.WriteLine("Дробь f: " + f);
            int a = 10;
            Fraction f1 = f * a;
            Console.WriteLine($"{f} * {a} = {f1}");
            Fraction f2 = a * f;
            Console.WriteLine($"{a} * {f1} = {f2}");
            double d = 1.5;
            Fraction f3 = f + d;
            Console.WriteLine($"{f} * {d} = {f3}");



            Fraction f4 = new Fraction(1, 2);
            Console.WriteLine("\nДробь f: " + f4);        
            Console.WriteLine($"{f4} * {f1} = {f4 * f1}");
            Console.WriteLine($"{f4} / {f1} = {f4 / f1}");
            Console.WriteLine($"{f1} / {f4} = {f1 / f4}");
            Console.WriteLine($"{f1} / 0.5 = {f1 / 0.5}");
            Console.WriteLine($"{f1} / 0.2 = {f1 / 0.2}");


            Fraction f5 = new Fraction(1, 1);
            Console.WriteLine("\nДробь f: " + f5);
            Console.WriteLine($"{f5} / 0.5 = {f5 / 0.5}");
            Console.WriteLine($"{f5} / 0.2 = {f5 / 0.2}");
            Console.WriteLine($"{f5} / 2 = {f5 / 2}");
            Console.WriteLine($"{f5} / 5 = {f5 / 5}");
        }
    }
}

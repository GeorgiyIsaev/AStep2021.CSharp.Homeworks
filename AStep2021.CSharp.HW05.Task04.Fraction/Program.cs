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
            Console.WriteLine("Дробь f:" + f);
            int a = 10;
            Fraction f1 = f * a;
            Console.WriteLine("Дробь f1:" + f1);
            Fraction f2 = a * f;
            Console.WriteLine("Дробь f2:" + f2);
            double d = 1.5;
            Fraction f3 = f + d;
            Console.WriteLine("Дробь f3:" + f3);


            Fraction f4 = new Fraction(100, 10);
            Console.WriteLine("Дробь f4:" + f4);
        
            Console.WriteLine($"Дробь {f4} * {f1} = {f4 * f1}");
            Console.WriteLine($"Дробь {f4} / {f1} = {f4 / f1}");
            Console.WriteLine($"Дробь {f1} / {f4} = {f1 / f4}");
        }
    }
}

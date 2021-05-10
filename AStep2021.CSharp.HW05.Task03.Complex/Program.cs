using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW05.Task03.Complex
{

    class Program
    {
        static void Main(string[] args)
        {
            Complex complexA = new Complex(2, 2);        
            Complex complexB = new Complex(3, 3);     

            Console.WriteLine($"({complexA})+({complexB})={complexA + complexB}");
            Console.WriteLine($"({complexA})-({complexB})={complexA - complexB}");

            Complex complex = new Complex(5, 9);
            Complex complexResult;
            Console.WriteLine($"\nСупер Урвнение:");
            Console.WriteLine($"(({complex}) - (({complex}) * ({complex}) * ({complex}) - 1)" +
               $"  / (3 * ({complex}) * ({complex}))");

            complexResult = complex - (complex * complex * complex - 1)
                / (3 * complex * complex);

            Console.WriteLine("Результат = " + complexResult);
            Console.ReadKey();
        }
    }
}

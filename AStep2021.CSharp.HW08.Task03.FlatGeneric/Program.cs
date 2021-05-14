using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW08.Task03.FlatGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D<int> p1 = new Point2D<int>(4, 3);
            Point2D<int> p2 = new Point2D<int>(9, 9);

            Line<int> line1 = new Line<int>(p1, p2);
            Console.WriteLine(line1);

            Line<int> line2 = new Line<int>(1, 2, 3, 4);
            Console.WriteLine(line2);
            Console.ReadKey();

        }
    }
}

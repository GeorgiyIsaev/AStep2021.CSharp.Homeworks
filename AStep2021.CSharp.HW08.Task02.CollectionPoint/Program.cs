using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW08.Task02.CollectionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Точка2D с целочисленными значениями:");
            Point2D<int> p1 = new Point2D<int>(1, 3);
            Console.WriteLine(p1);
            Console.WriteLine("GetType(): " + p1.GetType().FullName);
            Console.WriteLine("typeof: " + typeof(Point2D<int>).ToString());

            Console.WriteLine("\nТочка2D с вещественными значениями:");
            Point2D<double> p2 = new Point2D<double>(1.2, 3.4);
            Console.WriteLine(p2);
            Console.WriteLine("GetType(): " + p2.GetType().FullName);
            Console.WriteLine("typeof: " + typeof(Point2D<double>).ToString());

            Console.WriteLine("\nТочка3D с целочисленными значениями:");
            Point3D w1 = new Point3D(4, 7, 9);
            Console.WriteLine(w1);
            Console.WriteLine("GetType(): " + w1.GetType().FullName);
            Console.WriteLine("typeof: " + typeof(Point3D).ToString());

            Console.ReadKey();
        }
    }
}

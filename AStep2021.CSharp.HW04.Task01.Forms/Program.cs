using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW04.Task01.Forms
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(10, 10, 10);
            triangle.PForm();
            triangle.SForm();
            Console.WriteLine("Треугольник S="+ Math.Round(triangle.SForm(),2) //обрезаем цифры после запятой
                + " P=" + triangle.PForm());
        }
    }
}

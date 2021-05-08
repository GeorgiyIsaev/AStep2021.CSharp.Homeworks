using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW04.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Forms.CompositeForm triangle = new Forms.CompositeForm();

            triangle.addForm(new Forms.Circle(10)); 
            triangle.addForm(new Forms.Ellipse(10,10));
            triangle.addForm(new Forms.Parallelogram(10,10,2));
            triangle.addForm(new Forms.Rectangle(10,10));
            triangle.addForm(new Forms.Rhombus (10,5));
            triangle.addForm(new Forms.Square (10));
            triangle.addForm(new Forms.Trapezoid(10,10,10,10));
            triangle.addForm(new Forms.Triangle (10,10,10));

            triangle.Print();

            triangle.PForm();
            triangle.SForm();
            Console.WriteLine(triangle.Name + " S=" + Math.Round(triangle.SForm(),2) //обрезаем цифры после запятой
                + " P=" + triangle.PForm());
        }
    }
}

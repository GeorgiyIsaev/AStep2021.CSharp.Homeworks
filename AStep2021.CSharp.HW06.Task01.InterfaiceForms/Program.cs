﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.Forms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Form> forms = new List<Form>();
            forms.Add(new Circle(10));
            forms.Add(new Ellipse(10, 10));
            forms.Add(new Parallelogram(10, 10, 2));
            forms.Add(new Rectangle(10, 10));
            forms.Add(new Rectangle(10, 10));
            forms.Add(new Square(10));
            forms.Add(new Trapezoid(10, 10, 10, 10));
            forms.Add(new Triangle(10, 10, 10));

            foreach (Form form in forms)
            {
                form.Print();
            }


            Console.ReadKey();
        }
    }
}

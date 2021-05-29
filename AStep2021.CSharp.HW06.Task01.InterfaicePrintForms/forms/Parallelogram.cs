using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.Forms
{
    class Parallelogram : Form
    {
        /*Треугольник, / * Triangle,
       
         * Квадрат, * Square,
      
         * Ромб,    * Rhombus,
     
         * Прямоугольник,    * Rectangle,
     
         * Параллелограмм,    * Parallelogram,
     
         * Трапеция,    * Trapezoid, 
      
         * Круг,   * Circle,
   
         * Эллипс     * Ellipse*/

        int AB;
        int CD;
        int h;
        public Parallelogram()
        {
             h = ReadInt("Введите высоту паралелограмма: ");
            AB = ReadInt("Введите сторону АВ: ");
            CD = ReadInt("Введите сторону CD: ");

            if (AB < 0 || CD < 0) throw new ApplicationException("Значения для сторон паралелограмма должны быть больше нуля!");
            if (h < 0) throw new ApplicationException("Высота паралелограмма должна быть больше нуля");
            name = "Параллелограмм";
            ColorInit();
        }
        public override void Point()
        {
            Console.WriteLine("        ********* "); 
            Console.WriteLine("     *********    ");
            Console.WriteLine("  *********       ");
            Console.WriteLine("*********         ");       
        }

        public Parallelogram(int AB,int CD, int h)
        {
            if (AB < 0 || CD < 0) throw new ApplicationException("Значения для сторон паралелограмма должны быть больше нуля!");
            if (h < 0) throw new ApplicationException("Высота паралелограмма должна быть больше нуля");


            this.AB = AB;
            this.CD = CD;
            this.h= h;
            name = "Параллелограмм";
        }

        public override double PForm()
        {
            //P=2(a+b)
            double perimeter = (AB + CD)*2;
            return perimeter;           
        }

        public override double SForm()
        {
           //S=a⋅h         
            double square = AB * h;
            return square;
        }
    }
}

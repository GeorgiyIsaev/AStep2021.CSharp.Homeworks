using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.Forms
{
    class Rhombus : Form
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
        int h;
        public Rhombus()
        {
            Console.WriteLine("Укажите значения для ромба:");
            AB = ReadInt("Введите сторону АВ: ");
            h = ReadInt("Введите высоту ромба: ");
            if (AB < 0) throw new ApplicationException("Значения для сторон ромба должны быть больше нуля!");
            if (h < 0) throw new ApplicationException("Высота ромба должна быть больше нуля");
            name = "Ромб";
        }
        public Rhombus(int AB,int h)
        {
            if (AB < 0 ) throw new ApplicationException("Значения для сторон ромба должны быть больше нуля!");
            if (h < 0) throw new ApplicationException("Высота ромба должна быть больше нуля");

            this.AB = AB;
            this.h= h;
            name = "Ромб";          
        }

        public override double PForm()
        {
            //P=4a
            double perimeter = AB * 4;
            return perimeter;           
        }

        public override double SForm()
        {
            //S=ah
            double square = AB *h;
            return square;
        }
    }
}

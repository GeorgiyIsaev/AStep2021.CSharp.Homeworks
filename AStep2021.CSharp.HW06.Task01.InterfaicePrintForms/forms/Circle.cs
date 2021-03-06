using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.Forms
{
    class Circle : Form
    {
        /*Треугольник, / * Triangle,
       
         * Квадрат, * Square,
      
         * Ромб,    * Rhombus,
     
         * Прямоугольник,    * Rectangle,
     
         * Параллелограмм,    * Parallelogram,
     
         * Трапеция,    * Trapezoid, 
      
         * Круг,   * Circle,
   
         * Эллипс     * Ellipse*/

        int R;  
        public Circle()
        {
            R = ReadInt("Введите радиус круга: ");
            if (R < 0) throw new ApplicationException("Радиус круга не может быть меньше нуля");
            name = "Круг";
            ColorInit();
        } 

        public Circle(int R)
        {
            if (R<0) throw new ApplicationException("Радиус круга не может быть меньше нуля");

            this.R = R;
            name = "Круг";
        }
        public override void Point()
        {
            Console.WriteLine("    ****    ");
            Console.WriteLine("  ********  ");
            Console.WriteLine("  ********  ");
            Console.WriteLine("    ****    ");
        }


        public override double PForm()
        {
            //2πR
            double perimeter = 2*3.14 * R;
            return perimeter;           
        }

        public override double SForm()
        {
            //S=πR²
            double p = PForm() / 2;
            double square = Math.Pow(3.14 * R,2);
            return square;
        }
    }
}

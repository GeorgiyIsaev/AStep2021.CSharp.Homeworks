using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW04.Task01.Forms
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
        public Circle(int R
        {
            this.R = R; 
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

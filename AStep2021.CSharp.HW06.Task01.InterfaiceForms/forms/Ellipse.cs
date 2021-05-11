using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW04.Task01.Forms
{
    class Ellipse : Form
    {
        /*Треугольник, / * Triangle,
       
         * Квадрат, * Square,
      
         * Ромб,    * Rhombus,
     
         * Прямоугольник,    * Rectangle,
     
         * Параллелограмм,    * Parallelogram,
     
         * Трапеция,    * Trapezoid, 
      
         * Круг,   * Circle,
   
         * Эллипс     * Ellipse*/

        int halfAxisA;
        int halfAxisB;     
        public Ellipse(int halfAxisA, int halfAxisB)
        {
            this.halfAxisA = halfAxisA;
            this.halfAxisB = halfAxisB;
            name = "Элипс";
        }

        public override double PForm()
        {
            //P= 2π√(A^2+B^2)/8
            double perimeter = 2 *3.14 * Math.Sqrt((halfAxisA* halfAxisA+ halfAxisA * halfAxisB)/8);
            return perimeter;           
        }

        public override double SForm()
        {
            //S= πAB         
            double square = 3.14 * halfAxisA* halfAxisA;
            return square;
        }
    }
}

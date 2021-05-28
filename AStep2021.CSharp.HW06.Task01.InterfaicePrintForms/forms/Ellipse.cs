using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.Forms
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
        public Ellipse()
        {
            halfAxisA = ReadInt("Введите радиус первой полуОси элипса: ");
            halfAxisB = ReadInt("Введите радиус второй полуОси элипса: ");
            if (halfAxisA < 0 || halfAxisB < 0) throw new ApplicationException("Значения полурадиусов для овала не могут быть меньше нуля");
            name = "Элипс";
        }

        public Ellipse(int halfAxisA, int halfAxisB)
        {
            if (halfAxisA < 0 || halfAxisB <0) throw new ApplicationException("Значения полурадиусов для овала не могут быть меньше нуля");
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

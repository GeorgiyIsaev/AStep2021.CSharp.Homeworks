using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW04.Task01.Forms
{
    class Square : Form
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


        public Square(int AB)
        {
            this.AB = AB;
        }

        public override double PForm()
        {
            double perimeter = 4 *AB;
            return perimeter;           
        }

        public override double SForm()
        {
            //S=a²
            double square = AB *AB;
            return square;
        }
    }
}

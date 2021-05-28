using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.Forms
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
            if (AB < 0) throw new ApplicationException("Значения для сторон квадрата должны быть больше нуля!");
            this.AB = AB;
            name = "Квадрат";
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

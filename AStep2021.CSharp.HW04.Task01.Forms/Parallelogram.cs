using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW04.Task01.Forms
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
        public Parallelogram(int AB,int CD, int h)
        {
            this.AB = AB;
            this.CD = CD;
            this.h= h;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW04.Task01.Forms
{
    class Rectangle : Form
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
        int CA;
        public Rectangle(int AB,int CD,int CA)
        {
            this.AB = AB;
            this.CD = CD;
            this.CA= CA;
        }

        public override double PForm()
        {
            //P=2(a+b)
            double perimeter = (AB + CD) *2;
            return perimeter;           
        }

        public override double SForm()
        {      
            //S = a*b      
            double square =AB *CD;
            return square;
        }
    }
}

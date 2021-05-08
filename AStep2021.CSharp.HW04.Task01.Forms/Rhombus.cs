using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW04.Task01.Forms
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
        int BC;
        int CA;
        public Rhombus(int AB,int BC,int CA)
        {
            this.AB = AB;
            this.BC= BC;
            this.CA= CA;
        }

        public override double PForm()
        {
            double perimeter = AB + BC + CA;
            return perimeter;           
        }

        public override double SForm()
        {
            //Формула Герона 
            //S = √ p * (p − a) * (p − b) * (p − c)​,
            //полупериметр p = (a + b + c) : 2
            double p = PForm() / 2;
            double square = Math.Sqrt(p * (p - AB) * p*(p - BC) * p*(p - CA));
            return square;
        }
    }
}

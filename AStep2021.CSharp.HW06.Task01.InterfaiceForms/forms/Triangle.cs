using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.Forms
{
    class Triangle : Form
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
        public Triangle(int AB,int BC,int CA)
        {
            if (AB < 0 || BC < 0 || CA < 0) throw new ApplicationException("Значения для сторон триугольника должны быть больше нуля!");
                     

            this.AB = AB;
            this.BC= BC;
            this.CA= CA;
            name = "Треугольник";
        }

        private void CheckingForExistence(int AB, int BC, int CA)
        {
            if (AB > BC && AB > CA) {
                if (AB > (BC + CA))
                    throw new ApplicationException("Сторона АВ в треугольнику больше сумму двух других сторон!");
            }
            else if (BC > AB && BC > CA)
            {
                if (BC > (AB + CA))
                    throw new ApplicationException("Сторона BC в треугольнику больше сумму двух других сторон!");
            }
            else if (CA > AB && CA > BC)
            {
                if (CA > (AB + BC))
                    throw new ApplicationException("Сторона CA в треугольнику больше сумму двух других сторон!");
            }
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

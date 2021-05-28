using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.Forms
{
    class Trapezoid : Form
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
        int CD;
        int DA;
        public Trapezoid()
        {
            Console.WriteLine("Укажите размеры строн триугольнка:");
            AB = ReadInt("Введите сторону АВ: ");
            BC = ReadInt("Введите сторону BC: ");
            CD = ReadInt("Введите сторону CD: ");
            DA = ReadInt("Введите сторону DA: ");
            if (AB < 0 || BC < 0 || CD < 0 || DA < 0) throw new ApplicationException("Значения для сторон трапеции должны быть больше нуля!");
            name = "Трапеция";
            ColorInit();
        }


        public Trapezoid(int AB,int BC,int CD, int DA)
        {
            if (AB < 0 || BC < 0 || CD < 0 || DA < 0) throw new ApplicationException("Значения для сторон трапеции должны быть больше нуля!");


            this.AB = AB;
            this.BC= BC;
            this.CD = CD;
            this.DA= DA;
            name = "Трапеция";
        }

        public override double PForm()
        {
            //P=a+b+c+d
            double perimeter = AB + BC + CD + DA;
            return perimeter;           
        }

        public override double SForm()
        {
            //S=½h(a+b)

            //Площадь трапеции по 4 сторонам 
            double square = ((AB+CD)/2) * 
                Math.Sqrt(DA*DA - 
                Math.Pow((Math.Pow((CD - AB),2) + BC* BC - DA*DA)/2* (CD - AB),2));
            return square;
        }
    }
}

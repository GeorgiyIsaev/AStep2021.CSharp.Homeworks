using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW05.Task02.EquationSystem
{
    public class LinearEquation
    {
        double A1;
        double B1;
        public override string ToString()
        {
            string str = A1 + "*X + " + B1 + "*Y = 0";
            return str;
        }

        public static bool Parse(string valStr, LinearEquation linear)
        {
            string[] separator = { " ", "," };
            string[] lineItem = valStr.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                linear.A1 = Convert.ToInt32(lineItem[0]);
                linear.B1 = Convert.ToInt32(lineItem[1]);           
            }
            catch
            {
                return false;
            }
            return true;
        }    
        static public void EquationSystem(LinearEquation linear1, LinearEquation linear2)
        {
            double delta = linear1.A1 * linear1.B1 - linear2.A1 * linear2.B1;
            if (delta != 0)
            {
                Console.WriteLine("Уравнение имеет одно решение:");
                Console.WriteLine("X = " + 0 + " Y = " + 0);
            }
            else
            {
                Console.WriteLine("Система уравнений имеет бесконечно множество решений");
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            LinearEquation linear1 = new LinearEquation();
            LinearEquation linear2 = new LinearEquation();
            ReadStr(linear1);
            Console.WriteLine("Уравнения 1: \t" + linear1);
            ReadStr(linear2);
            Console.WriteLine("Уравнения 2: \t" + linear2);

            Console.WriteLine("\nСистема Уравнений:");
            Console.WriteLine("Уравнения 1: \t" + linear1);
            Console.WriteLine("Уравнения 2: \t" + linear2);

            LinearEquation.EquationSystem(linear1, linear2);
            Console.ReadKey();    

        }
        static void ReadStr(LinearEquation linear)
        {
            Console.WriteLine("Введите два числа через пробел или через запяту:");
            string tempStr = Console.ReadLine();
            if (!LinearEquation.Parse(tempStr, linear))
            {
                Console.WriteLine("ERROR: Не вернный ввод!");
                ReadStr(linear);
            }            
        }       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW05.Task02.EquationSystem
{
    public static class LinearEquation
    {
        static double A1;
        static double B1;
        static double A2;
        static double B2;

        static double X;
        static double Y;

        public static bool Parse(string valStr)
        {
            string[] separator = { " ", "," };
            string[] lineItem = valStr.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                A1 = Convert.ToInt32(lineItem[0]);
                B1 = Convert.ToInt32(lineItem[1]);
                A2 = Convert.ToInt32(lineItem[2]);
                B2 = Convert.ToInt32(lineItem[3]);
            }
            catch
            {
                return false;
            }
            return true;
        }
        static public string Info()
        {
            string str = A1 + "*X + " + B1 + "*Y = 0";
            str += "\n";
            str += A2 + "*X + " + B2 + "*Y = 0";
            return str;
        }


        static public void Result()
        {
            double delta = A1 * B1 - A2 * B2;
            if(delta != 0)
            {
                X = 0; Y = 0;
                Console.WriteLine("X = "+ X + " Y = " + Y);

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
            ReadStr();
            Console.ReadKey();
      


        }
        static void ReadStr()
        {
            Console.WriteLine("Введите четыри числа через пробел или через запяту:");
            string tempStr = Console.ReadLine();
            if (!LinearEquation.Parse(tempStr))
            {
                Console.WriteLine("ERROR: Не вернный ввод!");
                ReadStr();
            }
            Console.WriteLine("Система уравнения:\n" + LinearEquation.Info());
        }
    }
}

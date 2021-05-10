using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW05.Task01.Parse
{
    public static class LinearEquation
    {
        static double A;
        static double B;

       
        public static bool Parse(string valStr)
        {
            string[] separator = { " ", "," };
            string[] lineItem = valStr.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            try{
                A = Convert.ToInt32(lineItem[0]);
                B = Convert.ToInt32(lineItem[1]);
            }
            catch
            {
                return false;
            }
            return true;
        }
        static public string Info()
        {
            string str = A + "*X + " + B + "*Y = 0";
            return str;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ReadStr();
            Console.WriteLine("Уравнения: "  + LinearEquation.Info());
            

        }
        static void ReadStr()
        {
            Console.WriteLine("Введите два числа через пробел или через запяту:");
            string tempStr = Console.ReadLine();
            if (!LinearEquation.Parse(tempStr))
            {
                Console.WriteLine("ERROR: Не вернный ввод!");
                ReadStr();
            }
        }
    }
}

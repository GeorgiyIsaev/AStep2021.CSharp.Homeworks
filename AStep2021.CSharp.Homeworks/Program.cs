using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW01
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem01();

        }
        static void Problem01()
        { 
           /*Задача 01*/
            int a, b, c;
            a = IntRead("A");
            b = IntRead("B");
            c = IntRead("C");

            if (c<a && c < b)
            {
                int sRect = b * a;
                int sSquare = c * c;
                //    int countSquare = sRect / sSquare;
                //    Console.WriteLine("Колличество квадратов со стронами С(" + c + ") в прямоугольнике АB(" + a + "," + b + ") равно:"+ countSquare);
                //    int sSurplus = sRect - countSquare * sSquare;
                //    Console.WriteLine("Площадь незанятой части прямоугольника: "+ sSurplus);

                int storonaA = a / c;
                int storonaB = b / c;
                int countSquareAB = storonaA * storonaB;
                Console.WriteLine("Колличество квадратов со стронами С(" + c + ") в прямоугольнике АB(" + a + "," + b + ") равно:" + countSquareAB);
                int sSurplus = sRect - countSquareAB * sSquare;
                Console.WriteLine("Площадь незанятой части прямоугольника: " + sSurplus);
            }
            else
            {
                Console.WriteLine("В прямоугольнике со стронами АB("+a+"," +b+"),");
                Console.WriteLine("нельзя разместить квадрат со строной С("+c+")");
            }
        }

        static int IntRead(string nameval = "")
        {
            int val;        
            try
            {
                Console.WriteLine("Введите число " + nameval);
                val = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("OШИБКА ввода. Требуется ввести число!");
                val = IntRead(nameval);
            }
            return val;
        }



    }
}

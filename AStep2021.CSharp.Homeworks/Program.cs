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
            /*1.	Даны целые положительные числа A, B, C. Значение
            этих чисел программа должна запрашивать у пользо-
            вателя. На прямоугольнике размера A*B размещено
            максимально возможное количество квадратов со
            стороной C. Квадраты не накладываются друг на
            друга. Найти количество квадратов, размещенных на
            прямоугольнике, а также площадь незанятой части
            прямоугольника.
            Необходимо предусмотреть служебные сообщения
            в случае, если в прямоугольнике нельзя разместить ни
            одного квадрата со стороной С (например, если зна-
            чение С превышает размер сторон прямоугольника).*/

            int a, b, c;
            a = IntRead("A");
            b = IntRead("B");
            c = IntRead("C");

            if (c<a && c < b)
            {
                int sRect = b * a;
                int sSquare = c * c;
                int countSquare = sRect / sSquare;
                Console.WriteLine("Колличество квадратов со стронами С(" + c + ") в прямоугольнике АB(" + a + "," + b + ") равно:"+ countSquare);

                int sSurplus = sRect - countSquare * sSquare;
                Console.WriteLine("Площадь незанятой части прямоугольника: "+ sSurplus);




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

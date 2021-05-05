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
            //Problem01();
            Problem02();

        }
        static void Problem01()
        {
            /*Задача 01*/
            uint a, b, c;
            a = UIntRead("A");
            b = UIntRead("B");
            c = UIntRead("C");

            if (c<a && c < b)
            {
                int sRect = b * a;
                int sSquare = c * c;
                //    int countSquare = sRect / sSquare;
                //    Console.WriteLine("Колличество квадратов со стронами С(" + c + ") в прямоугольнике АB(" + a + "," + b + ") равно:"+ countSquare);
                //    int sSurplus = sRect - countSquare * sSquare;
                //    Console.WriteLine("Площадь незанятой части прямоугольника: "+ sSurplus);

                uint storonaA = a / c;
                uint storonaB = b / c;
                uint countSquareAB = storonaA * storonaB;
                Console.WriteLine("Колличество квадратов со стронами С(" + c + ") в прямоугольнике АB(" + a + "," + b + ") равно:" + countSquareAB);
                double sSurplus = sRect - countSquareAB * sSquare;
                Console.WriteLine("Площадь незанятой части прямоугольника: " + Convert.ToInt32(sSurplus));
            }
            else
            {
                Console.WriteLine("В прямоугольнике со стронами АB("+a+"," +b+"),");
                Console.WriteLine("нельзя разместить квадрат со строной С("+c+")");
            }
        }
        static uint UIntRead(string nameval = "")
        {
            uint val;
            try
            {
                Console.WriteLine("Введите число " + nameval);
                val = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("OШИБКА ввода. Требуется ввести число!");
                val = UIntRead(nameval);
            }
            return val;
        }


        /*ЗАДАЧА 02*/
        static void Problem02()
        {
            double depositBank = 10000;
            double percent = percentRead();
            int countMonth = 0;
            do
            {
                countMonth++;
                depositBank += (depositBank * percent/100);
            }
            while (depositBank < 11000);
            Console.WriteLine("Через "+ countMonth +" месяцев на счету будит " + depositBank);


        }
        static double percentRead()
        {
            double val;
            try
            {
                Console.Write("Введите процент: ");
                val = Convert.ToDouble(Console.ReadLine());
                if(val<0 || val > 25)                
                     throw new Exception();                
            }
            catch
            {
                Console.WriteLine("OШИБКА ввода. Требуется ввести число от 0,0 до 25,0!");
                val = percentRead();
            }
            return val;
        }


        /*ЗАДАЧА 03*/
        static void Problem03()
        {

        }



    }
}

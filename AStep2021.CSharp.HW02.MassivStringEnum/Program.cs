using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW02.MassivStringEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task01();
           //Task02();
            Task03();
            //Task04();


            Console.ReadKey();
        }






        /*1.	Сжать массив, удалив из него все 0 и, заполнить ос-
               вободившиеся справа элементы значениями –1*/
        static void Task01()
        {

            int[] massiv = new int[10];

            Random rand = new Random();
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = rand.Next(0, 3);
                Console.Write(massiv[i] + "\t");
            }

            for (int i = 0; i < massiv.Length;)
            {
                if (massiv[i] == 0)
                {
                    for (int j = i; j < massiv.Length - 1; j++)
                    {
                        massiv[j] = massiv[j + 1];
                        massiv[massiv.Length - 1] = -1;
                    }
                }
                else { i++; }
            }
            Console.WriteLine();
            foreach (int i in massiv)
            {
                Console.Write(i + "\t");
            }
        }


        /*2.	Преобразовать массив так, чтобы сначала шли все
        отрицательные элементы, а потом положительные
        (0 считать положительным)*/
        static void Task02()
        {
            int[] massiv = new int[10];

            Random rand = new Random();
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = rand.Next(-2, 2);
                Console.Write(massiv[i] + "\t");
            }

            for (int i = 0; i < massiv.Length; i++)
            {
                for (int j = 0; j < massiv.Length - 1; j++)
                {
                    if (massiv[j] >= 0)
                    {

                        int temp = massiv[j + 1];
                        massiv[j + 1] = massiv[j];
                        massiv[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            foreach (int i in massiv)
            {
                Console.Write(i + "\t");
            }

        }

        /*2.	3.	Написать программу, которая предлагает пользова-
        телю ввести число и считает, сколько раз это число
        встречается в массиве.*/
        static void Task03()
        {
            int[] massiv = new int[20];

            Random rand = new Random();
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = rand.Next(1, 3);
                Console.Write(massiv[i] + "\t");
            }
            int val = IntRead("от 1 до 3");
            int count = 0;
            for (int i = 0; i < massiv.Length; i++)
            {
                if (val == massiv[i]) count++;
            }

            Console.WriteLine("В этом массиве число "+val+" встречается " +count+ " раз.");
           
        }
        static int IntRead(string nameval = "")
        {
            int val;
            try
            {
                Console.WriteLine("Введите число " + nameval);
                val = Convert.ToInt32(Console.ReadLine());
                if (val < 1 || val > 3) throw new Exception();
            }
            catch
            {
                Console.WriteLine("OШИБКА ввода. Требуется ввести от 1 до 3!");
                val = IntRead(nameval);
            }
            return val;
        }


    }
}

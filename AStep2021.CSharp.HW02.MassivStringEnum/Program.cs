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
            Task01();
            Console.ReadKey();
        }

        static void Task01()
        {
            /*1.	Сжать массив, удалив из него все 0 и, заполнить ос-
            вободившиеся справа элементы значениями –1*/
            int[] massiv = new int[10];

            Random rand = new Random();
            for(int i=0; i< massiv.Length; i++)
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
            foreach(int i in massiv)
            {
                Console.Write(i + "\t");
            }



        }


    }
}

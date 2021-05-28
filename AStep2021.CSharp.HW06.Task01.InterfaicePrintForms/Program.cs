using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.InterfaicePrintForms
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("--Меню--");
                Console.WriteLine("1 - Добавить фигуру");
                Console.WriteLine("2 - Удалить фигуру");
                Console.WriteLine("3 - Отобразить выбранные фигуры");
                Console.WriteLine("4 - Выход");
                int param = Convert.ToInt32(Console.ReadLine());
                switch (param)
                {
                    case 1: // Добавление новой фигуры
                        break;
                    case 2: // Удаление фигуры по номеру добавления
                       break;
                    case 3: //Вывод данных фигур                       
                        break;
                    case 4: 
                        Environment.Exit(0); 
                        break;
                }
            }

        }
    }
}

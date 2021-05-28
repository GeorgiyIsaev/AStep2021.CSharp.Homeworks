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
                Console.WriteLine("\n--Меню--");
                Console.WriteLine("1 - Добавить фигуру");
                Console.WriteLine("2 - Удалить фигуру");
                Console.WriteLine("3 - Отоброзить выбранные фигуры");
                Console.WriteLine("4 - Выход");
                ConsoleKeyInfo test = Console.ReadKey();
                Console.Clear();
                switch (test.KeyChar)
                {
                    case '1': // Добавление новой фигуры
                        Console.WriteLine("1 - Добавить фигуру");
                        break;
                    case '2': // Удаление фигуры по номеру добавления
                        Console.WriteLine("2 - Удалить фигуру");
                        break;
                    case '3': //Вывод данных фигур
                        Console.WriteLine("3 - Отоброзить выбранные фигуры");
                        break;
                    case '4':
                        Console.WriteLine("4 - Выход");
                        Environment.Exit(0); 
                        break;
                }
            }

        }
    }
}

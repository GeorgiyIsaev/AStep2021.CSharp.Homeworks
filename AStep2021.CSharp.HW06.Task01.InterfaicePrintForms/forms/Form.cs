using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.Forms
{
    abstract public class Form : ISimpleAngle
    {
        protected string name = "Фигура";
        public string Name => name;
        abstract public double SForm();
        abstract public double PForm();
        protected ConsoleColor foregroundColor;
        protected ConsoleColor backgroundColor;

        public virtual void Print()
        {
            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(Name +" P=" + Math.Round(PForm()) + " S=" + Math.Round(SForm()));
            Console.ResetColor();
        }
        protected void ColorInit()
        {
            Console.WriteLine("\n--Выберете цвет фигуры--");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("1 - Зеленый в желтом");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("2 - Красный в синем");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("3 - Темно синий в белом");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("4 - Темно магентовый в синем");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("5 - Белый в темно цианном");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("6 - Красный в темно зеленом");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("7 - Зеленый в красном");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("8 - Желтый в сером");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("9 - Серый в зеленом");
            ConsoleKeyInfo param = Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

            switch (param.KeyChar)
            {
                case '1':                  
                    foregroundColor = ConsoleColor.Green; 
                    backgroundColor = ConsoleColor.DarkYellow;
                    break;
                case '2':
                    foregroundColor = ConsoleColor.Red;
                    backgroundColor = ConsoleColor.Blue;
                    break;
                case '3':
                    foregroundColor = ConsoleColor.DarkBlue;
                    backgroundColor = ConsoleColor.White;
                    break;
                case '4':
                    foregroundColor = ConsoleColor.DarkMagenta;
                    backgroundColor = ConsoleColor.Blue;
                    break;
                case '5':
                    foregroundColor = ConsoleColor.White;
                    backgroundColor = ConsoleColor.DarkCyan;
                    break;
                case '6':       
                    foregroundColor = ConsoleColor.Red;
                    backgroundColor = ConsoleColor.DarkGray;
                    break;
                case '7':
                    foregroundColor = ConsoleColor.Green;
                    backgroundColor = ConsoleColor.Red;
                    break;
                case '8':
                    foregroundColor = ConsoleColor.Yellow;
                    backgroundColor = ConsoleColor.Gray;
                    break;
                case '9':
                    foregroundColor = ConsoleColor.Gray;
                    backgroundColor = ConsoleColor.DarkGreen;
                    break;
            }

        }

        protected int ReadInt(string nameval = "-> ")
        {
            int val;
            try
            {
                Console.Write(nameval);
                val = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERROR!! Требуется ввести число!");
                val = ReadInt(nameval);
            }
            return val;
        }
    }
}

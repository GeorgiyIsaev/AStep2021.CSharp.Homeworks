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
            Point();
            Console.ResetColor();
        }
        public virtual void Point()
        {      
            Console.Write("");          
        }

        public void ColorInit()
        {
            Console.WriteLine("\n--Выберете фон фигуры--");
                       
            for (int i=0; i < 15; i++)
            {
                Console.Write(i + ".\t- ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = (ConsoleColor)i;            
                if(i>9) Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(" ФОН ");
                Console.ResetColor();
            }
            int val = ReadInt();
            if (val > 0 && val <=15)
                backgroundColor = (ConsoleColor)val;

            Console.WriteLine("\n--Выберете шрифт фигуры--");
                       
            for (int i = 0; i < 15; i++)
            {
                Console.Write(i + ".\t- ");
                Console.BackgroundColor = backgroundColor;
                Console.ForegroundColor = (ConsoleColor)i;             
                Console.WriteLine(" ШРИФТ ");
                Console.ResetColor();
            }
            val = ReadInt();
            if (val > 0 && val <= 15)
               foregroundColor = (ConsoleColor)val;

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

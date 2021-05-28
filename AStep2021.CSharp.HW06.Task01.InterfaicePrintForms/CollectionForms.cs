using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.InterfaicePrintForms
{
    public static class CollectionForms
    {
        static List<Forms.Form> forms = new List<Forms.Form>();

        public static void Add(Forms.Form form)
        {         
            forms.Add(form);
        }
        public static void DelleteID(int val)
        {
            if (val >= 0 && val < forms.Count)
            {
                Console.Write("Удален: ");
                forms.ElementAt(val).Print();
                forms.RemoveAt(val);
            }
            else
                Console.WriteLine("Индекс вне диапазана списка!");
        }

        public static void PrintContents()
        {
            Console.WriteLine("Список выбранных фигур!");
            int count = 1;
            foreach (Forms.Form form in forms)
            {
                Console.WriteLine((count++) + ". " + form.Name +
                    " P=" + Math.Round(form.PForm()) + " S=" + Math.Round(form.SForm()));
            }
        }
        public static void CreateForm()
        {
            Console.WriteLine("\n--Меню создния фигуры--");
            Console.WriteLine("1 - Создать круг");
            Console.WriteLine("2 - Создать овал");
            Console.WriteLine("3 - Создать паралелограмм");
            Console.WriteLine("4 - Создать прямоугольник");
            Console.WriteLine("5 - Создать ромб");
            Console.WriteLine("6 - Создать квадрат");
            Console.WriteLine("7 - Создать трапецию");
            Console.WriteLine("8 - Создать триугольник");
            Console.WriteLine("9 - Создать композитную фигуру(наполнение случайное)");
            ConsoleKeyInfo param = Console.ReadKey();
            Console.Clear();

            try
            {
                switch (param.KeyChar)
                {
                    case '1':
                        forms.Add(new Forms.Circle());
                        break;
                    case '2':
                        forms.Add(new Forms.Ellipse());
                        break;
                    case '3':
                        forms.Add(new Forms.Parallelogram());
                        break;
                    case '4':
                        forms.Add(new Forms.Rectangle());
                        break;
                    case '5':
                        forms.Add(new Forms.Rhombus());
                        break;
                    case '6':
                        forms.Add(new Forms.Square());
                        break;
                    case '7':
                        forms.Add(new Forms.Trapezoid());
                        break;
                    case '8':
                        forms.Add(new Forms.Triangle());
                        break;
                    case '9':
                        int count = ReadInt("Колличество рандомных фигур в композитной фигуре: ");
                        forms.Add(new Forms.CompositeForm(count));
                        break;
                }
            }
            catch(Exception ex) {
                Console.WriteLine("ERROR!! Фигура не добавлена!");
                Console.WriteLine(ex.Message); 
            }
        }
        public static int ReadInt(string nameval = "-> ")
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

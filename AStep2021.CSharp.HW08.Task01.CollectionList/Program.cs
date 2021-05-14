using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW08.Task01.CollectionList
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Россия", "Russia");
            dictionary.Add("Британия", "Great Britain");
            dictionary.Add("США", "USA");
            dictionary.Add("Франция", "France");
            dictionary.Add("Китай", "China");

            while (true)
            {
                Console.WriteLine("1 - Запросить перевод слова.");
                Console.WriteLine("2 - Добавить слово.");
                Console.WriteLine("3 - Показать весь словарь.");
                Console.WriteLine("4 - ВЫХОД!.");

                int param = IntRead("Выберите пункт меню");
                switch (param)
                {
                    case 1: //Запросить перевод слова.
                        Console.Write("Введите слово для перевода: ");
                        string text = Console.ReadLine();
                        foreach (KeyValuePair<string, string> val in dictionary)
                        {
                            if(text == val.Key)                           
                                Console.WriteLine(val.Key + " - " + val.Value);
                            if (text == val.Value)
                                Console.WriteLine(val.Key + " - " + val.Value);
                        }
                        break;

                    case 2: // Добавить слово
                        Console.Write("Введите русское слово: ");
                        string rus = Console.ReadLine();
                        Console.Write("Введите англиское слово: ");
                        string eng = Console.ReadLine();
                        dictionary.Add(rus, eng);
                        break;

                    case 3: //Показать весь словарь
                        foreach (KeyValuePair<string, string> val in dictionary)
                        {
                            Console.WriteLine(val.Key + " - " + val.Value);
                        }
                        break;

                    case 4: Environment.Exit(0); break;
                }
            }

        }
        static int IntRead(string nameval = "")
        {
            int val;
            try
            {
                Console.Write(nameval + ": ");
                val = Convert.ToInt32(Console.ReadLine());
                if (val < 0) throw new Exception();
                Console.WriteLine("");
            }
            catch
            {
                Console.WriteLine("OШИБКА ВВОДА. Требуется ввести положительное число!");
                val = IntRead(nameval);
            }
            return val;
        }

    }
}

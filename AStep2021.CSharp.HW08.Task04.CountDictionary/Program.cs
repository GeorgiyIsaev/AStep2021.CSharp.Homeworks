using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AStep2021.CSharp.HW08.Task04.CountDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();     
           
            string text = ReadTXT();
            string[] separator = { " ","\n", "\r",".",",",":","-","<",">","(",")","[", "]" };
            string[] wordItems = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            foreach(string wordItem in wordItems)
            {                
                if (!dictionary.ContainsKey(wordItem))
                {
                    dictionary.Add(wordItem, 1);
                }
                else
                    dictionary[wordItem]++;
            }

            Console.WriteLine($"Колличество слов в тексте: {wordItems.Length}\n");
            //сортировка по значениям
            dictionary = dictionary.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            
            foreach (var val in dictionary)
            {
                Console.WriteLine(val.Key + " - " + val.Value);
            }
        }
        static string ReadTXT(string nameFile = "test.txt")
        {
            string text = "";
            try
            {                
                using (var file = new StreamReader(nameFile, Encoding.Unicode))
                {
                    text = file.ReadToEnd();
                }              
            }
            catch
            {
                Console.WriteLine("Файл не доступен!");
            }
            return text;
        }


    }
}

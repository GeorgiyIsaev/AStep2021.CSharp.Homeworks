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
            foreach (KeyValuePair<string, string> val in dictionary)
            {
                // keyValue.Value представляет класс Person
                Console.WriteLine(val.Key + " - " + val.Value);
            }
        }
    }
}

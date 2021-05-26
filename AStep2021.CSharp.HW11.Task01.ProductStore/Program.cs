using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW11.Task01.ProductStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Store> stores = new List<Store>();
            string[] food = new[] { "Яблоко", "Картошка", "Капуста", "Хлеб", "Колбаски" };
            Random rd = new Random();
            foreach (string txt in food)
            {
                stores.Add(new Store(txt, rd.Next(10,70), TypeProduct.Food));
            }



        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW11.Task01.ProductStore
{
    class Order
    {
        static Random rd = new Random();
        string name;
        List<Store> OrderStores = new List<Store>();
        public Order(string name)
        {
            this.name = name;
        }

       

        public void NewOrderRandom(List<Store> stores)
        {
           // System.Threading.Thread.Sleep(100);
            int count = rd.Next(1, 9);
            while (count-- >= 0)
            {             
                OrderStores.Add(stores[rd.Next(0, stores.Count - 1)]);
            }

        }

        public void PrintOrder()
        {
            Console.WriteLine(name);
            foreach (Store store in OrderStores)
                Console.WriteLine(store);
            Console.WriteLine();
        }
    }
}

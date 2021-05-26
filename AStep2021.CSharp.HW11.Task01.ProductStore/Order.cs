using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW11.Task01.ProductStore
{
    class Order
    {
        List<Store> OrderStores;

        public void NewOrderRandom(List<Store> stores)
        {
            Random rd = new Random();
            int count = rd.Next(1, 6);
            while (count-- >= 0)
            {
                OrderStores.Add(stores[rd.Next(0, stores.Count)]);
            }
        }

        public void PrintOrder()
        {
            foreach (Store store in OrderStores)
                Console.WriteLine(store);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        public void XmlTextWriterToFile()
        {

            foreach (Store store in OrderStores)
            {
                using (XmlTextWriter w = new XmlTextWriter(Console.Out))
                {
                    w.WriteStartElement(store.Name);
                    w.WriteEndElement();
                    w.WriteStartElement(store.Price.ToString());
                    w.WriteEndElement();
                    w.WriteStartElement(store.TypeProduct.ToString());
                    w.WriteEndElement();                   
                }
            }

        }

    }
}

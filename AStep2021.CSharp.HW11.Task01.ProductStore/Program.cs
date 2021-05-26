using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AStep2021.CSharp.HW11.Task01.ProductStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Store> stores = new List<Store>();
            CreateStores(stores);    


            Order order1 = new Order("Заказ Олега:");
            order1.NewOrderRandom(stores);
            order1.PrintOrder();
            order1.XmlTextWriterToFile("order1.xml");

            Order order2 = new Order("Заказ Никиты:");
            order2.NewOrderRandom(stores);
            order2.PrintOrder();
            order2.XmlTextWriterToFile("order2.xml");

            Order order3 = new Order("Заказ Димы:");
            order3.NewOrderRandom(stores);
            order3.PrintOrder();
            order3.XmlTextWriterToFile("order3.xml");

            /*Вычитывание*/
            Order order4 = new Order("Заказ из ХМL order3:");
            ReadFileXML(order4, "order3.xml" );
            order4.PrintOrder();

            Order order5 = new Order("Заказ из ХМL order2:");
            ReadFileXML(order5, "order2.xml");
            order5.PrintOrder();

            Order order6 = new Order("Заказ из ХМL order1:");
            ReadFileXML(order6, "order1.xml");
            order6.PrintOrder();
           
            Console.ReadKey();
        }

        static void AddStore(string[] masNameProduct, List<Store> stores, TypeProduct typeProduct)
        {
            Random rd = new Random();
            foreach (string txt in masNameProduct)
            {
                stores.Add(new Store(txt, rd.Next(10, 70), typeProduct));
            }
        }
        static void CreateStores(List<Store> stores)
        {
            string[] food = new[] { "Яблоко", "Картошка", "Капуста", "Хлеб", "Колбаски" };
            AddStore(food, stores, TypeProduct.Food);
            string[] alcohol = new[] { "Пиво", "Вино", "Водка" };
            AddStore(alcohol, stores, TypeProduct.Alcohol);
            string[] hygiene = new[] { "Мыло", "Шампунь", "Зубная паста", "Губка" };
            AddStore(hygiene, stores, TypeProduct.Hygiene);
            string[] jewelry = new[] { "Картина", "Открытка", "Ленточка" };
            AddStore(jewelry, stores, TypeProduct.Jewelry);
            string[] medicines = new[] { "Асперин", "Анальгин", "Витаминка", "Аскарбинка" };
            AddStore(medicines, stores, TypeProduct.Medicines);
        } 
                
        static void ReadFileXML(Order order, string namefile)
        {
            List<string> nodestr;        

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(namefile);
            XmlNode root_node = xmlDoc.DocumentElement;
            XmlNodeList nodes = root_node.ChildNodes;

            foreach (XmlNode n in nodes)
            {
                try
                {
                    if (n.Name == "store")
                    {
                        nodestr = new List<string>();
                        foreach (XmlNode tmp in n)
                        {
                            nodestr.Add(tmp.InnerText);
                        }

                        int tempPrice = Convert.ToInt32(nodestr[1]);
                        Enum.TryParse(nodestr[2], out TypeProduct tempTypeProduct);
                        order.AddEl(new Store(nodestr[0], tempPrice, tempTypeProduct));   
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Невозможно считать нод");
                    Console.WriteLine(ex.Message);
                }   
            }          
        }
    }
}

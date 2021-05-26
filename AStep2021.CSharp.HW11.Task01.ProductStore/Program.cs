﻿using System;
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
            CreateStores(stores);
            
            foreach (Store store in stores)            
                Console.WriteLine(store);

            Order order1 = new Order;


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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW11.Task01.ProductStore
{
    enum TypeProduct
    {
        Food,
        Hygiene, //Гигиена
        Jewelry, //Украшения
        Alcohol,
        Medicines
    }
    
    
    class Store
    {
        public Store(string name, int price, TypeProduct typeProduct)
        {
            Name = name;
            Price = price;
            TypeProduct = typeProduct;
        }

        public string Name { get; set; }
        public int Price { get; set; }
        internal TypeProduct TypeProduct { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW04.Task02.Products
{
    public abstract class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public Product(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public abstract override string ToString();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW04.Task02.Products
{
    public class Food : Product
    {
        public Food(string name, double price, int count) : base(name, price, count)
        {         
        }

        public override string ToString()
        {
            return string.Format(Name + ":\t Цена:\t"
                + Price + "\t Осталось: " + Count);
        }
    }
}

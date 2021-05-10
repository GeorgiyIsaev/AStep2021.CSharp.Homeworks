using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW04.Task02.Products
{
    enum Status
    {
        Stock, Ordered, Sold
    }

    class Stream
    {      
            public Product[] Lot { get; set; }
            public Status status { get; set; }

            public Stream(Product[] lot, Status status)
            {
                Lot = lot;
                this.status = status;
            }

            public override string ToString()
            {
                return string.Format("Статутс группы товаров:\t" + status);
            }

            public void Show()
            {
                foreach (var item in Lot)
                {
                    Console.WriteLine($"Статус:\t{status}");
                    Console.WriteLine(item);
                }
            }
        
    }
}

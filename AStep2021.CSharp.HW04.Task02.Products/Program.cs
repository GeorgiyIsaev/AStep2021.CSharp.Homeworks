using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW04.Task02.Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] lots =
            {
                new Food("Кортошка", 25.90, 10),
                new Food("Макорошки", 23.00, 15),
                new Food("Тушёнка", 45.50, 50),
                new Household("Моющее средство", 50.90, 20),
                new Household("Губка", 5.90, 100)           
            };

            Stream stram = new Stream(lots, Status.Stock);
            stram.Show();

            stram.status = Status.Sold;
            Console.WriteLine(stram.ToString());

            stram.Show();

            Console.ReadKey();



        }
    }
}

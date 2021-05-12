using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW07.Task01.TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Money money1 = new Money();
                Money money2 = new Money();
                Money money3 = new Money();

                money1.add(100);
                money2.add(100,50);
                money3.add(100,400);

                Console.WriteLine($"money1 = {money1} \nmoney2 = {money2} \nmoney3 = {money3}");

                Console.ReadKey();

            }
            catch
            {

            }
        }
    }
}

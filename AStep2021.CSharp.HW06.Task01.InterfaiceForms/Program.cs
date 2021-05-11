using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.Forms
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleAngle simpleAngle = new SimpleAngle(5, 20);

            simpleAngle.Print(); 
            Console.ReadKey();
        }
    }
}

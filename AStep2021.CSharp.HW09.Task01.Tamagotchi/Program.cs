using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW09.Task01.Tamagotchi
{
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi tamagotchi = new Tamagotchi("Покемон");


            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.ReadLine();
            tamagotchi.Stop();
            tamagotchi.Dispose();

            Console.WriteLine("Terminating the application...");
        }
    }

  
}

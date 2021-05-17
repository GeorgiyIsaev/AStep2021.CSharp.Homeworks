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

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Поиграть");
                Console.WriteLine("2 - Погульять");
                Console.WriteLine("3 - Покормить");
                Console.WriteLine("4 - Отправить спать");
                Console.WriteLine("5 - Лечить");

                Console.ReadLine();
            }


      
        }
    }

  
}

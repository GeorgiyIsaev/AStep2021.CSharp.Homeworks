using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW03.Task09.Wonder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Семь Чудес света:\n");
            Alexandria.Wonder.Show();
            TempleArtemis.Wonder.Show();
            Mausoleum.Wonder.Show();
            Giza.Wonder.Show();
            ColossusOfRhodes .Wonder.Show();
            Babylon.Wonder.Show();
            ZeusOlympia.Wonder.Show();

            Console.ReadKey();
        }
    }
}

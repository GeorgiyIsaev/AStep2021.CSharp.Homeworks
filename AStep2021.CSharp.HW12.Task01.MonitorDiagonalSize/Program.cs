using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //подключил в ссылках
using System.Windows.Forms; //подключил в ссылках

namespace AStep2021.CSharp.HW12.Task01.MonitorDiagonalSize
{
    class Program
    {
        static void Main(string[] args)
        {           
            /*Размеры экрана в пикселях */
            Console.Write($"Ширина экрана: {SystemInformation.PrimaryMonitorSize.Width}");
            Console.WriteLine($" Высота: {SystemInformation.PrimaryMonitorSize.Height}"); ;
        }
    }
}

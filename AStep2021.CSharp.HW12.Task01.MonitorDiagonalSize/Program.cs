using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //подключил в ссылках
using System.Windows.Forms; //подключил в ссылках
using Windows.Graphics.Display;


namespace AStep2021.CSharp.HW12.Task01.MonitorDiagonalSize
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Вариант1: Размеры экрана в пикселях */
            Console.Write($"Вер1: Ширина экрана: {SystemInformation.PrimaryMonitorSize.Width}");
            Console.WriteLine($" Высота: {SystemInformation.PrimaryMonitorSize.Height}");

            /*Вариант2: Размеры экрана в пикселяъ */
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            double intWidth = resolution.Width;
            double intHeight = resolution.Height;
            Console.WriteLine($"Вер2: Ширина монитора: {intWidth} px, Высота: {intHeight} px ");

            double dioganal = Math.Sqrt(Math.Pow(intWidth, 2) + Math.Pow(intHeight, 2));
            Console.WriteLine($"Диаганаль экрана: {Math.Round(dioganal, 2)} пикселей"); //Round обрезать число        

        }     
    }
}


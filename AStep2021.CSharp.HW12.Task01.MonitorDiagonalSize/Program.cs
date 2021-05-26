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

           // Console.WriteLine(SystemInformationU()); //это не то!


            //Get the diagonal size of the integrated display
            double actualSizeInInches = Double.MaxValue;
            if (DisplayInformation.GetForCurrentView().DiagonalSizeInInches.HasValue)
                actualSizeInInches = DisplayInformation.GetForCurrentView().DiagonalSizeInInches.Value;

            ////If the diagonal size is <7" use the OneHanded optimized view
            //if (actualSizeInInches > 0 && actualSizeInInches < 7)
            //    return true;
            //else
            //    return false;

        }
        static private string SystemInformationU()
        {
            StringBuilder StringBuilder1 = new StringBuilder(string.Empty); try
            {
                StringBuilder1.AppendFormat("Operation System: {0}\n", Environment.OSVersion);
                if (Environment.Is64BitOperatingSystem) StringBuilder1.AppendFormat("\t\t 64 Bit Operating System\n");
                else StringBuilder1.AppendFormat("\t\t 32 Bit Operating System\n");
                StringBuilder1.AppendFormat("SystemDirectory: {0}\n", Environment.SystemDirectory);
                StringBuilder1.AppendFormat("ProcessorCount: {0}\n", Environment.ProcessorCount);
                StringBuilder1.AppendFormat("UserDomainName: {0}\n", Environment.UserDomainName);
                StringBuilder1.AppendFormat("UserName: {0}\n", Environment.UserName);  //Drives  
                StringBuilder1.AppendFormat("LogicalDrives:\n");
                foreach (System.IO.DriveInfo DriveInfo1 in System.IO.DriveInfo.GetDrives())
                {
                    try
                    {
                        StringBuilder1.AppendFormat("\t Drive: {0}\n\t\t VolumeLabel: " +
                         "{1}\n\t\t DriveType: {2}\n\t\t DriveFormat: {3}\n\t\t " +
                         "TotalSize: {4}\n\t\t AvailableFreeSpace: {5}\n",
                         DriveInfo1.Name, DriveInfo1.VolumeLabel,
                         DriveInfo1.DriveType, DriveInfo1.DriveFormat,
                         DriveInfo1.TotalSize, DriveInfo1.AvailableFreeSpace);
                    }
                    catch { }
                }
                StringBuilder1.AppendFormat("SystemPageSize: {0}\n", Environment.SystemPageSize);
                StringBuilder1.AppendFormat("Version: {0}", Environment.Version);
            }
            catch { }
            return StringBuilder1.ToString();
        }

    }
}


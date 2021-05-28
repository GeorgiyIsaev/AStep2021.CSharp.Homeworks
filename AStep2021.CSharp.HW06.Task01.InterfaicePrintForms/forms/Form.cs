﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.Forms
{
    abstract public class Form : ISimpleAngle
    {
        protected string name = "Фигура";
        public string Name => name;
        abstract public double SForm();
        abstract public double PForm();

        public virtual void Print()
        {
            Console.WriteLine(Name +" P=" + Math.Round(PForm()) + " S=" + Math.Round(SForm()));
            
        }
        protected int ReadInt(string nameval = "-> ")
        {
            int val;
            try
            {
                Console.Write(nameval);
                val = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERROR!! Требуется ввести число!");
                val = ReadInt(nameval);
            }
            return val;
        }
    }
}

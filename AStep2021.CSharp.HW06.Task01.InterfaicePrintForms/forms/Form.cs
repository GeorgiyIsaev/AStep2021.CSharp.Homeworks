using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.Forms
{
    abstract class Form : ISimpleAngle
    {
        protected string name = "Фигура";
        public string Name => name;
        abstract public double SForm();
        abstract public double PForm();

        public virtual void Print()
        {
            Console.WriteLine(Name +" P=" + Math.Round(PForm()) + " S=" + Math.Round(SForm()));
            
        }
    }
}

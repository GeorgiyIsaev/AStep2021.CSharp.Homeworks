using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW04.Task01.Forms
{
    abstract class Form
    {
        protected string name = "Фигура";
        public string Name => name;
        abstract public double SForm();
        abstract public double PForm();
    }
}

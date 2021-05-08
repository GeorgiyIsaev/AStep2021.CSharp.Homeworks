using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW04.Task01.Forms
{
    class CompositeForm : Form
    {
        List<Form> compositeForm = new List<Form>();

        public CompositeForm() { name = "Композитная Фигура"; }

        public void addForm(Form form){
            compositeForm.Add(form);
        }
        void Print()
        {
            foreach(Form form in compositeForm)
            {
                //form
            }
        }

       public override double PForm()
       {
            return 1;
       }

        public override double SForm()
        {
            return 1;
        }
    }
}

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
        public void Print()
        {
            Console.WriteLine("Композитная фигура состоит из: ");
            int count = 1;

            foreach (Form form in compositeForm)
            {
                Console.WriteLine((count++) + ". " + form.Name +
                    " P="+ Math.Round(form.PForm()) +" S="+ Math.Round(form.SForm()));
            }
        }

       public override double PForm()
       {
            double perimeter = 0;
            foreach (Form form in compositeForm)
            {
                perimeter += form.PForm();
            }

            return perimeter;
       }

        public override double SForm()
        {
            double square = 0;
            foreach (Form form in compositeForm)
            {
                square += form.SForm();
            }
            return square;
        }
    }
}

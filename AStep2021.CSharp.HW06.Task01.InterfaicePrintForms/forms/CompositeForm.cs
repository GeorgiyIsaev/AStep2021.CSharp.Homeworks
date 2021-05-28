using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.Forms
{
    class CompositeForm : Form
    {
        List<Form> compositeForm = new List<Form>();

        public CompositeForm() {
            name = "Композитная Фигура";         
        }
        public CompositeForm(int countForm) { 
            name = "Композитная Фигура";
            if (countForm <= 2) throw new ApplicationException("Композитная фигура должна состоять хотябы из двух фигур!");
            RandomContent(countForm);
            ColorInit();
        }

        public void addForm(Form form){
            compositeForm.Add(form);
        }
        public void PrintContents()
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

        public void RandomContent(int count)
        {
            Random random = new Random();          
            while (count-- >= 0)
            {
                int val = random.Next(1, 8);
                switch (val)
                {
                    case 1:  addForm(new Forms.Circle(10));
                        break;
                    case 2:
                        addForm(new Forms.Ellipse(10, 10));
                        break;
                    case 3:
                        addForm(new Forms.Parallelogram(10, 10, 2));
                        break;
                    case 4:
                        addForm(new Forms.Rectangle(10, 10));
                        break;
                    case 5:
                        addForm(new Forms.Rhombus(10, 5));
                        break;
                    case 6:
                        addForm(new Forms.Square(10));
                        break;
                    case 7:
                        addForm(new Forms.Trapezoid(10, 10, 10, 10));
                        break;
                    case 8:
                        addForm(new Forms.Triangle(10, 10, 10));
                        break;
                }
            }
        }
    }
}

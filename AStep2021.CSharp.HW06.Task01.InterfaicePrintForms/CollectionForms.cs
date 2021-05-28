using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.InterfaicePrintForms
{
    class CollectionForms
    {
        List<Forms.Form> forms = new List<Forms.Form>();

        public void Add(Forms.Form form)
        {
            forms.Add(form);
        }
        public void DelleteID(int val)
        {
            if (val >= 0 && val < forms.Count)
            {
                Console.Write("Удален: ");
                forms.ElementAt(val).Print();
                forms.RemoveAt(val);
            }
            else
                Console.WriteLine("Индекс вне диапазана списка");
        }

        public void PrintContents()
        {
            Console.WriteLine("Список выбранных фигур!");
            int count = 1;
            foreach (Forms.Form form in forms)
            {
                Console.WriteLine((count++) + ". " + form.Name +
                    " P=" + Math.Round(form.PForm()) + " S=" + Math.Round(form.SForm()));
            }
        }

    }
}

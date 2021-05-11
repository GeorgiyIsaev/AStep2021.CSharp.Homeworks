using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW06.Task01.Forms
{
    //свойства: Высота, Основание, УголМеждуОснова-
        //        ниемИСмежнойСтороной, КоличествоСторон, Длины-
        //Сторон, Площадь, Периметр.
    class SimpleAngle : Form
    {
        //int h;
        int baseAB;
        int CountSide;

        public SimpleAngle(int baseAB,    int CountSide)
        {
            this.h= h;
            this.baseAB=baseAB;            
            this.CountSide=CountSide;

            name = "Простой N-угольник";
        }

        public override double PForm()
        {
            return CountSide * baseAB;
        }

        public override double SForm()
        {
            //Площадь правильного N угольника
            //S=Base * h;
            double S = (CountSide * baseAB * baseAB) / Math.Tan(180 / CountSide);
                
            return S;
        }
    }
}

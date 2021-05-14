using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW08.Task03.FlatGeneric
{
    // IComparable<T> - сортировка
    // struct - недопускает значение null

    class Line<T> where T : struct, IComparable<T>
    {
        private Point2D<T> p1; 
        private Point2D<T> p2;

        public Line(T x1, T y1, T x2, T y2)
        {
            p1 = new Point2D<T>(x1, y1);
            p2 = new Point2D<T>(x2, y2);
        }
        public Line(Point2D<T> p1, Point2D<T> p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public override string ToString()
        {
            return ($"Линия {p1} - {p2}");
        }
    }
}

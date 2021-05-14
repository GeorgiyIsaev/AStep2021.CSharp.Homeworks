using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW08.Task02.CollectionPoint
{
    class Point3D : Point2D<int>
    {
        int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return string.Format(" x = {0};  y = {1};  z = {2}", X, Y, Z);
        }
    }
}

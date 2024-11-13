using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointApp.Model
{
    internal class Point3D : Point2D
    {
        public int Z { get; set; }

        public Point3D() { }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override string? ToString()
        {
            return base.ToString() + " " + $"{{{Z}}}";
        }

        public override void Move10()
        {
            base.Move10();
            Z += 10;
        }
    }
}

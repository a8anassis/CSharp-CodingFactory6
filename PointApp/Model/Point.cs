using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointApp.Model
{
    internal class Point
    {
        public int X { get; set; }

        public Point() { }

        public Point(int x)
        {
            X = x;
        }

        public override string? ToString()
        {
            return $"{{{X}}}";
        }

        public static Point GetOnePoint()
        {
            return new Point(); 
        }

        public virtual void Move10()
        {
            X += 10;
        }
    }
}

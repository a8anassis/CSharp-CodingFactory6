using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Model
{
    internal class Point : AbstractPoint, IMoveable
    {

        public Point() 
        { 
        }

        public Point(int x) : base(x) 
        {
            
        }
    }
}

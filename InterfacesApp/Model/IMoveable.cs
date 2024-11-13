using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Model
{
    internal interface IMoveable
    {
        void Move10();

        void Move15()
        {
            Console.WriteLine("Move 15 units");
        }
    }
}

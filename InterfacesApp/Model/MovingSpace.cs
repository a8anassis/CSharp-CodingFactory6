using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Model
{
    internal class MovingSpace
    {
        private readonly IMoveable? _moveable;

        public MovingSpace(IMoveable? moveable)
        {
            _moveable = moveable;
        }

        public void MakeMove15()
        {
            _moveable!.Move15();
        }
    }
}

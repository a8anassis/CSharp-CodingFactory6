using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOApp.Model
{
    internal class Prefecture
    {
        private int _id;
        private string? _name;

        // Expressions
        public int Id { get => _id; set => _id = value; }
        public string? Name { get =>  _name; set => _name = value; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOApp.Model
{
    internal class City
    {
        private int _id;
        private string? _name;

        public int Id { get { return _id; } init { _id = value; } }
        public string? Name { get { return _name; } init { _name = value; } }

        public City() { }

        public City(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}

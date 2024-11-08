using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOApp.Model
{
    internal class Order
    {
        private int _id;
        private DateTime _date;

        public int Id { get { return _id; } private set { _id = value; } }
        public DateTime Name { get { return _date; } private set { _date = value; } }
    }
}

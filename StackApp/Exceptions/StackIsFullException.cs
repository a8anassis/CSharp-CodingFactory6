using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp.Exceptions
{
    internal class StackIsFullException : Exception
    {
        public StackIsFullException(string? message) : base(message)
        {
        }
    }
}

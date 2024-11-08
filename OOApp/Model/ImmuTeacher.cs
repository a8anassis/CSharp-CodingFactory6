using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOApp.Model
{
    /// <summary>
    /// POCO class - Plain Old CLR Object
    /// </summary>
    internal sealed class ImmuTeacher
    {
        public int Id { get; init; }
        public string? Firstname { get; init; }
        public string? Lastname { get; init; }

        public ImmuTeacher() { }

        public ImmuTeacher(int id, string? firstname, string? lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}

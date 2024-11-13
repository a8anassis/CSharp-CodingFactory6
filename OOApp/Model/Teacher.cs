using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOApp.Model
{
    /// <summary>
    /// POCO class
    /// </summary>
    internal class Teacher
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public SchoolType SchoolType { get; set; }

        public Teacher()
        {

        }

        public Teacher(int id, string? firstname, string? lastname, SchoolType schoolType)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            SchoolType = schoolType;
        }

        public override string? ToString() => $"{Id} {Firstname} {Lastname} {SchoolType}";

        public override bool Equals(object? obj)
        {
            return obj is Teacher teacher &&
                   Id == teacher.Id &&
                   Firstname == teacher.Firstname &&
                   Lastname == teacher.Lastname &&
                   SchoolType == teacher.SchoolType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Firstname, Lastname, SchoolType);
        }
    }
}

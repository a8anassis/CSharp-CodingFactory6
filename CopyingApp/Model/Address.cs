using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyingApp.Model
{
    /// <summary>
    /// POCO class.
    /// </summary>
    internal class Address
    {
        public string? StreetName { get; set; }
        public string? StreetNo { get; set; }
        public string? ZipCode { get; set; }

        public Address() { }

        public Address(string? streetName, string? streetNo, string? zipCode)
        {
            StreetName = streetName;
            StreetNo = streetNo;
            ZipCode = zipCode;
        }

        public override string ToString()
        {
            return $"{StreetName} {StreetNo} {ZipCode}";
        }
    }
}

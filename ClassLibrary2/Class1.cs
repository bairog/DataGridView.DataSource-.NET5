using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("WindowsFormsApp2")]
namespace ClassLibrary2
{
    internal class Address
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    }
}

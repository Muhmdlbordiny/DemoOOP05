using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP05.Casting_Operator_overloading
{
    //Model : Class that Representing  Table Existed at database
    internal class Employee
    {
        public int Id { get; set; }
        public string? FullName { get; set; }

        public string? Email { get; set; }
        public string? Password { get; set; }
        public Guid SecurityStamp { get; set; }

    }
}

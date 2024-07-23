using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP05.Partial
{
    internal partial class Employees
    {
        public void print()
        {
            Console.WriteLine("I am Employee");
        }
        public int Test { get; set; }
        public partial void MIdo()
        {
            Console.WriteLine("Done"); ;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP05.Sealed
{
    internal class Parent
    {
        private int salary ;

        public virtual int Salary
        {
            get { return salary ; }
            set { salary  = value +1000; }
        }

        public virtual void print()
        {
            Console.WriteLine("Hello from Parent");
        }
        
    }
    class Child : Parent
    {
        // sealed override
        //New 
        public sealed override void print()
        {
            Console.WriteLine("Hello from Child ");
        }
        public sealed override int Salary 
        { get => base.Salary;
            set => base.Salary = value<5000?5000:value; 
        }

    }
       sealed class GrandChild : Child
    {
        //public override void print()
        //{
        //    Console.WriteLine("Hello from GrandChild :");
        //}
        //public override int Salary { get => base.Salary; set => base.Salary = value; }

    }
    //class Test : GrandChild
    //{

    //}
}

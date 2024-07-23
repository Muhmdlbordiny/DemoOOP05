using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP05.Abstraction
{
    public abstract class Shape
    {
        public Shape(int dim01, int dim02)
        {
            Dim01 = dim01;
            Dim02 = dim02;
        }

        // abstract class :is partial Implementation to Another Class [Not Fully Implemented]
        // Can not create  an object from abstract class
        public int Dim01 { get; set; }
        public int Dim02 { get; set; }
        //Abstract Method
        //Must be Contained inside Abstract Class
        public abstract decimal CalcArea();
        // abstract property 
        public abstract decimal permiter  //Readonly parameter
        { get;}
    }
    //Class : Class  => inherit
    //Class : interface => Implements
    //Class : Abstract class => Inherit & implement
    // Recangle [Concreate Class] => Implement Abstract Method using override KeyWords
    //Shape : Abstract Class 
   /*Layer Case Duplication Method*/public abstract class RectBase :Shape
    {
        public RectBase(int dim01 ,int dim02):base(dim01,dim02)
        {
            
        }
        public override decimal CalcArea()
        {
            return Dim01* Dim02;
        }

    }
    public class Rectangle :RectBase /*Shape*/ // inherit & implement
    {
        public Rectangle(int dim01, int dim02) : base(dim01, dim02)
        {
        }

        public override decimal permiter
        {
            get { return (Dim01 + Dim02) * 2; }
        }

        // Abstract Method 
        //public override decimal CalcArea()
        //{
        //    return Dim01 * Dim02;
        //}
    }
    
    public class Square : RectBase /*Shape*/
    {
        public Square(int Dim):base(Dim,Dim) 

        {
            //Dim01 = Dim02 = Dim;
        }
        public override decimal permiter
        {
            get { return Dim01 * 4; }
        }

        //public override decimal CalcArea()
        //{
        //    return Dim01* Dim02;
        //}
    }
    public class Circle  : Shape
    {
        public Circle( int raduis): base (raduis, raduis)
        {
            //Dim01 = Dim02 = raduis;
        }

        public override decimal permiter =>2*3.14M*Dim01 ;

        public override decimal CalcArea()
        {
            return 3.14M* Dim01*Dim01 ;
        }
    }

}
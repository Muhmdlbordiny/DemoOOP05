using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP05.Static
{
    //Helper Class
    //static class : Container for static member [property - Method - Attribute -Constructor - Constant]
    //  can not create object from static class  
    // can not be inherit and can not be reference
    internal static class Utaility
    {
        // Object Member Constructor
        //Non - static Constructor  is not Right place to initaized static attribute
        //public  Utaility(int x, int y)
        //{
        //    X = x;
        //    Y = y;
        //    //pi = 3.14;
        //}
        // class member constructor 
        // static Constructor => special constructpr 
        //1.MaxMum only per Class 
        //2.Cant specify access Modifiers or parameters for static Constructor 
        //3.will be Excuted just only one time per Class Lifetime By ClR and Before its first usage
        //**1. call [static Method or static property]
        //**2. create object from this class
        //**3. create object from another class inherting from this class



        static Utaility()
        {
            // used for initialized  to static Attribute
            pi = 3.14;
        }



        //public int X { get; set; }
        //public int Y { get; set; }
        //public override string ToString()
        //{
        //    return $"X : {X} , Y : {Y}";
        //}
        //Cm to inch 
        //object member function [Non -static function]
        public static double CmtoInch(double cm)
        {
            return cm / 2.54;
        }
        //Object Member method [Non Static Method ] no 
        // class Member Method

       // object Member Attribute
       // class member Attribute
        private readonly static double pi =3.14; //Compiler will generate Always Initailize Static Attribute With Default value of Data type

        //object Member property => can not used inside static Method
        //class member attribute  => Must be {Get,Set}
        //1. static Attribute 
        //2. Constant 
        public static double PI
        {
            get { return pi; }
            //set { pi = value; } // usually attribute readonly can not work set but availble set in Constructor
        }
        //Const
        //private const double pi = 3.14;
        public static double ClacCircleArea(double R)
        {
            return PI * R*R;
        }
    }
}

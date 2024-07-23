using DemoOOP05.Casting_Operator_overloading;
using DemoOOP05.Operator_overLoading;
using System.Drawing;
using DemoOOP05.Abstraction;
using Rectangle = DemoOOP05.Abstraction.Rectangle;
using DemoOOP05.Static;
using System;
using DemoOOP05.Partial;

namespace DemoOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operator overLoading
            //Complex C1 = new Complex() { Real = 3, Imag = 5 };
            //Console.WriteLine(C1); // 3 + 5i
            //Complex C2 =/*default*/ new Complex() { Real = 2, Imag = 4 };
            //Console.WriteLine(C2); // 2 + 4i
            #region Binary Operator OverLoading
            //Complex C1 = new Complex() { Real = 3, Imag = 5};
            //Console.WriteLine(C1); // 3 + 5i
            //Complex C2 =/*default*/ new Complex() { Real = 2, Imag = 4 };
            //Console.WriteLine(C2); // 2 + 4i
            ////Complex C3 = C1 + C2; //Invaild
            //Console.WriteLine("===================");
            ////Console.WriteLine(C3); // 5 + 9i

            ////Complex C3 = C1 - C2;
            ////Console.WriteLine(C3);
            ////Complex C3 += C1; // C3 = C3 + C1 
            //Complex C3 = default;
            //C3 += C1; //C3 =  Null +C1
            //Console.WriteLine(C3);
            //C3 -= C1;// C3 = C3 -C1 
            #endregion
            //Complex C3 = default;
            #region Unary operator
            ////C3 = ++C1; // prefix 
            //C3 = C1++; //postfix
            //Console.WriteLine("===================");
            //Console.WriteLine($"C3 = {C3}");//C3 = 3 + 5i
            //Console.WriteLine($"C1 = {C1}");//C1 = 4 + 5i
            //C3 = --C1; // prefix 
            //C3 = C1--; //postfix
            //Console.WriteLine("===================");
            //Console.WriteLine($"C3 = {C3}");//C3 = 3 + 5i
            //Console.WriteLine($"C1 = {C1}");//C1 = 2 + 5i

            #endregion
            #region Relational Operator
            //if (C1 > C2)
            //{
            //    Console.WriteLine("C1 is greater than C2");
            //}
            //else if (C2 > C1)
            //{
            //    Console.WriteLine("C2 is greater than C1");

            //} 
            #endregion
            #endregion
            #region Casting Operator overloading
            #region Ex01
            //object obj = 2;//Boxing
            //int X =(int) obj;// Explicit Casting 
            // (int) Casting Operator
            //Complex C1 = new Complex() { Real = 2 , Imag = 4};
            //int Y = (int)C1;//Invaild
            //                //Explicit Casting
            //                //(int)>
            //Console.WriteLine($"C1 = {C1}");
            //Console.WriteLine($"Y = {Y}");
            //string s = (string)C1;
            // Recommended 
            //Console.WriteLine($"S = {s}"); 
            #endregion
            #region Ex02
            // view -> EmployeeViewModel => Employee [Model]  => Database
            //Database => Employee  => EmployeeViewModel => View  
            Employee employee = new Employee()
            {
                Id = 10,
                FullName = "Mohamed Ashraf",
                Email = "Mohamed42@gmail.com",
                Password = "password",
                SecurityStamp = Guid.NewGuid()
            };
            //EmployeeViewModel employeeViewModel = new EmployeeViewModel() ;
            //employeeViewModel =(EmployeeViewModel) employee; // invaild  [Reference type to Reference type]
            //Console.WriteLine(employeeViewModel.FirstName);
            //Console.WriteLine(employeeViewModel.LastName);
            //object obj = new EmployeeViewModel() { FirstName = "Aya", LastName = "Mohamed" , Email = "Ay@yahoo.com"};
            //EmployeeViewModel E = (EmployeeViewModel)obj;
            //Console.WriteLine(E.FirstName);
            #endregion
            #endregion
            #region Abstract
            //Rectangle rectangle = new Rectangle(10, 20); /*{ Dim01 = 10 , Dim02 = 20}*/
            //decimal RevArea = rectangle.CalcArea();
            //Console.WriteLine(RevArea);
            //Console.WriteLine($"parmeter of Rectangle = {rectangle.permiter}");
            //Console.WriteLine("[================================================================]");
            //Circle circle = new Circle(30);
            //decimal CircleArea = circle.CalcArea();
            //Console.WriteLine($"Arra of Circle = {CircleArea}");
            //Console.WriteLine($"Parameter of circle = {circle.permiter}");
            //Shape shape = new Rectangle(10, 30);
            //Console.WriteLine(shape.CalcArea());
            //Console.WriteLine(shape.permiter); 
            #endregion
            #region Static
            //Utaility U01 = new Utaility(10,20);
            //Utaility U02 = new Utaility(100, 200);
            //Console.WriteLine($"cm to inch {U01.CmtoInch(254)}"); //100
            //Console.WriteLine($"cm to inch {U01.CmtoInch(254)}"); //100
            //if result of calling Method Cmtoinch will not Differ
            //By Difference of the object state [Data[x,y]]
            //Non static method  -> static method
            //Console.WriteLine($"cm to inch {Utaility.CmtoInch(254)}");

            //Console.WriteLine($"{U01.ClacCircleArea(10)}");
            //Console.WriteLine($"{U02.ClacCircleArea(10)}");
            //if result of calling Method CalcCircileArea will not Differ
            //By Difference of the object state [Data[x,y]]
            //Non static method  -> static method
            //Console.WriteLine(Utaility.ClacCircleArea(5)); 
            #endregion
            #region Partial
            Employees employees = new Employees();
            employees.Id = 10;
            employees.Name = "Mohamed Ashraf";
            employees.Age = 25;
            employees.Salary = 6000;
            employees.Test = 10;
            employees.print();
            employees.MIdo();
            #endregion


        }
    }
}

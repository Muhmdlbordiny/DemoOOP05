using AssigmentOOP05.Calculator;
using AssigmentOOP05.FirstProject;
using AssigmentOOP05.Third;

namespace AssigmentOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*1.	Define 3D Point Class and the basic Constructors (use chaining in constructors).

                2.	Override the ToString Function to produce this output:
                Point3D P = new Point3D (10,10,10);
                Console. WriteLine (P. ToString( ));
                Output: “Point Coordinates: (10, 10, 10)”.
                3.	 Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).

                4.	Try to use ==
                If (P1 == P2)   Does it work properly? 
                5.	Define an array of points and sort this array based on X & Y coordinates.
                6.	Implement ICloneable interface to be able to clone the object.      
             */

            //Point3D p = new Point3D(10, 10, 10);
            //Console.WriteLine(p);
            //int p1, p2; bool flag;
            //Console.WriteLine("Enter your point1 :");
            //flag = int.TryParse(Console.ReadLine(), out p1);
            //Console.WriteLine("Enter your point1 :");
            //flag = int.TryParse(Console.ReadLine(), out p2);
            //Point3D point = new Point3D(p1, p2, 10);
            //Console.WriteLine(point);
            //Point3D[]points = new Point3D[6]
            //{
            //    new Point3D(){ X = 2 , Y = 3},
            //    new Point3D(){ X = 7 , Y = 5},
            //    new Point3D(){ X = 8 , Y = 1},
            //    new Point3D(){ X = 4 , Y = 10},
            //    new Point3D(){ X = 15 , Y = 9},
            //    new Point3D(){ X = 14 , Y = 12}
            //};
            //Array.Sort(points);
            //foreach (var pos in points)
            //{
            //    Console.WriteLine($"pos  is a  {pos}");
            //}
            //Point3D point3 = new Point3D() { X = 20 ,  Y =50 , Z = 70};
            //Point3D point4 = new Point3D() ;
            //point4 = (Point3D)point3.Clone() ;
            //Console.WriteLine($"P3 {point3}");
            //Console.WriteLine($"P4 {point4}");
            #endregion
            #region Q2
            /*
             Second Project:
            Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, 
         each of them takes two parameters. Call each method in Main ().
         Modify the program so that you do not have to
         create an instance of class to call the four methods.
            
             
             */
            ///Console.WriteLine("Enter Num1 please ");
            ///int X = Convert.ToInt32(Console.ReadLine());
            ///Console.WriteLine("Enter Num2 please :");
            ///int Y = Convert.ToInt32(Console.ReadLine());
            ///Console.WriteLine("Enter Num1 Sub :");
            ///int Q = Convert.ToInt32(Console.ReadLine());
            ///Console.WriteLine("Enter Num2 Sub :");
            ///int E = Convert.ToInt32(Console.ReadLine());
            ///Console.WriteLine("Enter Num 1 Mul");
            ///int T = Convert.ToInt32(Console.ReadLine());
            ///Console.WriteLine("Enter Num 2 Mul :");
            ///int T1 = Convert.ToInt32(Console.ReadLine());
            ///Console.WriteLine("Enter Num1 Dividing :");
            ///int N1 = Convert.ToInt32(Console.ReadLine());
            ///Console.WriteLine("Enter Num 2 Dividing :");
            ///int N2 = Convert.ToInt32(Console.ReadLine());
            ///IMaths maths = new Maths();
            ///try
            ///{

            ///    int Z = maths.Add(X, Y);
            ///    Console.WriteLine($"Adding 2 Numbers {Z}");
            ///    int S = maths.Sub(Q, E);
            ///    Console.WriteLine($"Sub is {S}");
            ///    int M = maths.Multiply(T, T1);
            ///    Console.WriteLine($"Multiply is a {M}");
            ///    int D = maths.Dividing(N1, N2);
            ///    Console.WriteLine($"Dividing is a = {D}");
            ///}catch(Exception ex)
            ///{
            ///    Console.WriteLine(ex.Message);
            ///}

            #endregion
            #region Q3
            /* project Third */
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString()); // Hours = 1 , Minutes = 10 , Second = 15
            Duration D1 = new Duration(3600);
            Console.WriteLine(D1.ToString()); // Hours = 1 , Minutes = 0 , Second = 0 
            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString());
            Duration D3 =  new Duration(666);
            Console.WriteLine($"{D3.ToString()}");
           // D3 = D1 + D2;
           // D1 = D1 - D2;
           // D3 = ++D1;
           // D3 = --D1;
           //if( D1 < D2)
           //     Console.WriteLine("Helloooooooooooooo");
           // if (D1 <= D2)
           //     Console.WriteLine("Helloooooooooooooo");
           // //D3 = D1 + 7800;
           // DateTime obj = (DateTime)D3;
           #endregion
        }
    }
}

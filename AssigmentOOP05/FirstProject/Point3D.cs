using AssigmentOOP05.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP05.FirstProject
{
    internal class Point3D:IComparable,ICloneable
    {
        public Point3D()
        {
            
        }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X {  get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public object Clone()
        {
            return new Point3D()
            {
                 X = X,
                 Y = Y,
                 Z = Z
            };
        }

        public int CompareTo(object? obj)
        {
            Point3D point3D= (Point3D) obj;
            if ((this.X & this.Y ) > (point3D.X & point3D.Y))
                return 1;
            else if ((this.X & this.Y) < (point3D.X & point3D.Y))
                return -1;
            else 
               return 0;
        }

        public override string ToString()
        {
            return $"X : {X} , Y : {Y} , Z : {Z}";
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP05.Operator_overLoading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
        #region OPerator overloading
        //+
        // Non - private , Class member method
        public static Complex operator +(Complex Left, Complex Right)
        {
            //2 +5i
            //5+4i
            //7+9i
            return new Complex()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0)
                //Left?.Real => Null => Null
                //Left?.Real => Left != Null =>Left.Real
            };
        }
        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0)
            };
        }
        public static Complex operator ++(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) + 1,
                Imag = c?.Imag ?? 0

            };
        }
        public static Complex operator --(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) - 1,
                Imag = c?.Imag ?? 0
            };
        }
        //>
        public static bool operator >(Complex Left, Complex Right)
        {
            //Left.REal == Right.Real => Left.Imag > Righ.Imag
            //Left.REal != Right.Real => Left.Real>Right.Real
            if (Left.Real == Right.Real)
                return Left.Imag > Right.Imag;
            else
                return (Left.Real > Right.Real);
        }
        public static bool operator <(Complex Left, Complex Right)
        {
            if (Left.Real == Right.Real)
                return Left.Imag < Right.Imag;
            else
                return (Left.Real < Right.Real);
        }
        #endregion
        #region Casting operator overloading
        //(int)
        public static /*int*/ explicit operator int(Complex C)
        {
            return C?.Real ?? 0;
        }
        public static /*string*/ implicit operator string(Complex C)
        {
            return C?.ToString() ?? string.Empty;
        }
        #endregion
    }
}

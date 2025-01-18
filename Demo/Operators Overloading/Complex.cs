using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operators_Overloading
{
    internal class Complex
    {

        #region Properties

        public int Real { get; set; }
        public int Imag { get; set; }

        #endregion

        #region Methods

        #region Operators Overloading
       
        #region Part03 Operator Overloading - Binary Operators (+)

        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = left.Real + right.Real,
                Imag = left.Imag + right.Imag
            };
        }

        #endregion

        #region Part 04 Operators Overloading - Unary Operators ++ --

        public static Complex operator ++(Complex c1)
        {
            return new Complex()
            {
                Real = (c1?.Real ?? 0) + 1,
                Imag = (c1?.Imag ?? 0) + 1
            };
        }
        public static Complex operator --(Complex c1)
        {
            return new Complex()
            {
                Real = (c1?.Real ?? 0) - 1,
                Imag = (c1?.Imag ?? 0) - 1
            };
        }

        #endregion

        #region Part 05 Operators Overloading - Relational Operators (> <) (>= <=) (== !=)

        public static bool operator >(Complex c1, Complex c2) // Comparison Operators are Matched Operators/Coupled operators, Mean That if you overload on ">" then you must overload "<", and if you overload ">=" then you must overload "<=" and also for "==" "!=".
        {

            #region Approach 1

            //if (c1?.Real > c2?.Real)
            //{
            //    return true;
            //}
            //else if(c1?.Real < c2?.Real)
            //{
            //    return false;
            //}
            //else
            //{
            //    if(c1?.Imag > c2?.Imag)
            //    {
            //        return true;
            //    }
            //    return false;
            //} 

            #endregion

            #region Approach 2 [Easy]

            if (c1?.Real == c2?.Real)
                return c1?.Imag > c2?.Imag;
            else
                return c1?.Real > c2?.Real;

            #endregion

        }

        public static bool operator <(Complex c1, Complex c2)
        {

            #region Approach 1

            //if (c1?.Real < c2?.Real)
            //{
            //    return true;
            //}
            //else if (c1?.Real > c2?.Real)
            //{
            //    return false;
            //}
            //else
            //{
            //    if (c1?.Imag < c2?.Imag)
            //    {
            //        return true;
            //    }
            //    return false;
            //} 

            #endregion

            #region Approach 2 [Easy]

            if (c1?.Real == c2?.Real)
                return c1?.Imag < c2?.Imag;
            else
                return c1?.Real < c2?.Real;

            #endregion

        }

        #endregion

        #endregion

        #region Casting Operators (type)

        #region Ex01 Explicit Casting of (int) casting operator
        public static /*int*/ explicit operator int(Complex c) // Compiler Tell You that you don't need to write the return type, that's because you need to overload on the casting operator "int",
                                                               // so it know that you need to convert from Complex to int [Return Type is int].
        {
            return c?.Real ?? 0;
        }
        #endregion

        #region Ex02 Implicit Casting of (string) casting operator

        public static /*string*/ implicit operator string(Complex c)
        {
            return c?.ToString() ?? string.Empty;
        }

        #endregion

        #endregion


        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        #endregion

    }
}

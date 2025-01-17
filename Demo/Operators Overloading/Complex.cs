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

        #region Operator Overloading (+)
        
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = left.Real + right.Real,
                Imag = left.Imag + right.Imag
            };
        } 

        #endregion

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        } 

        #endregion

    }
}

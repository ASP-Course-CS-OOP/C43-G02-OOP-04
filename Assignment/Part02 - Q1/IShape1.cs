using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal interface IShape1
    {

        #region Signature For Properties
        
        double Area { get; }

        #endregion

        #region Signature For Methods
        
        void DisplayShapeInfo(); 

        #endregion

    }
}

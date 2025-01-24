using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal interface IRectangle1:IShape1
    {

        #region Signature For Properties
        
        public int Height { get; set; }
        public int Width { get; set; } 

        #endregion

    }
}

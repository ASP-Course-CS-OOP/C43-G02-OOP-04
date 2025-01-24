using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part02___Q2
{
    internal interface IAuthenticationServicee
    {

        #region Signature For Methods
        
        public bool AuthenticateUser(string name, string password);
        public bool AuthorizeUser(string name, Role role); 

        #endregion

    }
}

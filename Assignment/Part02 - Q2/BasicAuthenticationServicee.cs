using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part02___Q2
{
    internal class BasicAuthenticationServicee : IAuthenticationServicee
    {

        #region Fields
        
        private string name = "Eslam";
        private string password = "123456";
        private Role role = Role.Admin;

        #endregion

        #region Methods
        
        public bool AuthenticateUser(string _name, string _password)
        {
            return _name == name && _password == password ? true : false;
        }

        public bool AuthorizeUser(string _name, Role _role)
        {
            return _name == name && _role == role ? true : false;
        } 

        #endregion

    }
}

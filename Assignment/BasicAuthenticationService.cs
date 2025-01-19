using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        string[] users = { "user1", "user2" };
        string[] passwords = { "password1", "password2" };
        string[] roles = { "Admin", "User" };

        public bool AuthenticateUser(string username, string password)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i] == username && passwords[i] == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i] == username && roles[i] == role)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

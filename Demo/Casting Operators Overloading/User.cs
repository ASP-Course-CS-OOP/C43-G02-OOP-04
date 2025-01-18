using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Casting_Operators_Overloading
{
    #region Part 07 Casting Operator Overloading - Need
    
    //This is Model => Represent a Data of table users in DataBase. [Called COCO class because it is alwaus in real life contain just property for each and every column in users table and not contain behaviours ]
    internal class User
    {

        #region Properties

        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Guid SecurityStmp { get; set; } 

        #endregion

    } 

    #endregion
}

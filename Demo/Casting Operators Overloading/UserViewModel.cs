using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Casting_Operators_Overloading
{
    #region Part 07 Casting Operator Overloading - Need

    //This is ViewModel => Represent The Form Of Data That Will Rendered In A View [HTML page].
    internal class UserViewModel
    {

        #region Properties

        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        #endregion

        #region Methods

        #region Casting Operator Overloading

        public static /*UserViewModel*/ explicit operator UserViewModel(User user)
        {
            string[]? Names = user?.FullName?.Split(" ");
            return new UserViewModel()
            {
                //Mapping [Manual] => Map every property in "UserViewModel" class with the value of matched property of "User" class.  
                Id = user?.Id ?? 0,
                FName = Names?.Length > 0 ? Names[0]:string.Empty,
                LName = Names?.Length > 1 ? Names[1]:string.Empty,
                Email = user?.Email ?? string.Empty,
                Password = user?.Password ?? string.Empty
            };
        }

        #endregion

        public override string ToString()
        {
            return $"ID: {Id}\nFName: {FName}\nLName: {LName}\nEmail: {Email}\nPassword: {Password}";
        }

        #endregion

    }

    #endregion
}

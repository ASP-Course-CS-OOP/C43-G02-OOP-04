using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part03___Q3
{
    internal class EmailNotificationServicee : INotificationServicee
    {

        #region Methods
        
        public void SendNotification(string name, string message)
        {
            Console.WriteLine($"Email sent to {name} : {message}");
        } 

        #endregion

    }
}

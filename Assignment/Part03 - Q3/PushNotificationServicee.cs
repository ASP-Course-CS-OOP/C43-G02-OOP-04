using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part03___Q3
{
    internal class PushNotificationServicee : INotificationServicee
    {

        #region Methods
        
        public void SendNotification(string name, string message)
        {
            Console.WriteLine($"Push Notification sent to {name} : {message}");
        } 

        #endregion

    }
}

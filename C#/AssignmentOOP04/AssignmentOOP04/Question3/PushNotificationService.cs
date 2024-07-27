using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Question3
{
    internal class PushNotificationService : INotificationService
    {
        /*The PushNotificationService class simulates sending 
         * a push notification by outputting a message to the console.*/
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"{recipient} has a message {message}");
        }
    }
}

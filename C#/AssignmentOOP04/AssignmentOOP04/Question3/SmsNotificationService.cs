using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Question3
{
    /*The SmsNotificationService class simulates sending an SMS by outputting a message to the console.*/
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending a SMS : {message} to {recipient} ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Question3
{
    /*The EmailNotificationService class simulates sending 
     * an email by outputting a message to the console.*/
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"sending an Email {message} to {recipient}");
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Question3
{
    /*we define the INotificationService interface with a method SendNotification 
     * that takes a recipient and a message as parameters.*/
    internal interface INotificationService
    {
        public void SendNotification(string recipient, string message);
    
    }
}

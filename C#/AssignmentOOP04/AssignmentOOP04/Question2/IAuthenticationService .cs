using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Question2
{
    /*In this example, we start by defining the IAuthenticationService interface with
     * two methods: AuthenticateUser and AuthorizeUser. The BasicAuthenticationService class implements 
     * this interface and provides the specific implementation for these methods.*/
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(string userName, string password);

        public bool AuthorizeUser(string username, string role);

    }
}

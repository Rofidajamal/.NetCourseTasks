using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Question2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        /*, the AuthenticateUser method compares the provided username and password with the stored credentials. 
         * It returns true if the user is authenticated and false otherwise. */
        string? username = "Rofida";
        string? role = "admin";
        string? password = "122@";
        public bool AuthenticateUser(string userName, string password)
        {
            return userName.Equals(username) && password.Equals(password);
            
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username.Equals(this.username) && role.Equals(this.role);
            
        }
    }
}

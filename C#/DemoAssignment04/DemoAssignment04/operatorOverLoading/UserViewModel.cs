using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment04.operatorOverLoading
{
    internal class UserViewModel
    {
        //Represent the data that will be render in the view ( HTML)

        string? FName { get; set; }

        string? LName { get; set; }

        string? Email { get; set; }

        string? Password { get; set; }

        public static implicit operator UserViewModel(User user)
        {
            string?[] names = user.Name.Split(' ');
            return new UserViewModel()
            {
                FName = names.Length > 0 ? names[0] : String.Empty,
                LName = names.Length > 1 ? names[1] : String.Empty,
                Email = user?.Email ?? string.Empty,
                Password = user?.password ?? string.Empty,
            };
        }

        public override string ToString()
        {
            return $"First Name : {FName}   Last Name: {LName}  Email: {Email}  Password: {Password}";
        }
    }
}

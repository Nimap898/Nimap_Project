using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5.Models;

namespace WebApplication5.Service
{
    public class UserService:IUserService
    {
       
        public  User Authenticate(string Username, string Password)
        {
            // Simulated user authentication
            if (Username == "user" && Password == "password")
            {
                return new User { U = Username }; // Example user object
            }

            return null;
        }
    }
}
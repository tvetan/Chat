using Chat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Services.Models
{
    public class UserModel
    {
        public string Password { get; set; }

        public string Username { get; set; }

        public static UserModel Convert(User user)
        {
            UserModel model = new UserModel
            {
                Username = user.Username,
                Password = user.Password
            };

            return model;
        }
    }
}
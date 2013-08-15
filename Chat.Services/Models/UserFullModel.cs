using Chat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Services.Models
{
    public class UserFullModel : UserModel
    {
        public int UserId { get; set; }

        public string Picture { get; set; }

        public bool IsOnline { get; set; }

        public int PostCount { get; set; }

        public int ChatRoomCount { get; set; }

        public static UserFullModel Convert(User user)
        {
            UserFullModel model = new UserFullModel
            {
                UserId = user.Id,
                Picture = user.Picture,
                Username = user.Username,
                IsOnline =user.IsOnline,
                PostCount = user.Posts.Count,
                ChatRoomCount = user.ChatRooms.Count
            };

            return model;
        }
    }
}
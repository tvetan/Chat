using Chat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Services.Models
{
    public class ChatRoomModel
    {
        public int ChatRoomId { get; set; }

        public string Name { get; set; }

        public int PostCount { get; set; }

        public int UserCount { get; set; }

        public static ChatRoomModel Convert(ChatRoom chatRoom)
        {
            ChatRoomModel model = new ChatRoomModel
            {
                ChatRoomId = chatRoom.Id,
                Name = chatRoom.Name,
                PostCount = chatRoom.Posts.Count,
                UserCount = chatRoom.Users.Count
            };

            return model;
        }
    }
}
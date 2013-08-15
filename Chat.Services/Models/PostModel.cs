using Chat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Services.Models
{
    public class PostModel
    {
        public int PostId { get; set; }

        public DateTime Date { get; set; }

        public string Content { get; set; }

        public bool IsFile { get; set; }

        public int UserId { get; set; }

        public int ChatRoomId { get; set; }

        public static PostModel Convert(Post post)
        {
            PostModel model = new PostModel
            {
                PostId = post.Id,
                Date = post.Date,
                Content = post.Content,
                IsFile = post.IsFile,
                UserId = post.UserId,
                ChatRoomId = post.ChatRoomId
            };

            return model;
        }
    }
}
using Chat.Core.Commons;
using Chat.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core.Domain.Messages
{
    public class UserMessage:BaseRelation
    {
        public int UserId { get; set; }
        public int MessageId { get; set; }
        //Navigations
        public User User { get; set; }
        public Message Message { get; set; }
    }
}

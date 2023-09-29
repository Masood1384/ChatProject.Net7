using Chat.Core.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core.Domain.Messages
{
    public class Message:BaseEntity
    {
        public string Text { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime UpdateOn { get; set; }
        //Navigations
        public virtual ICollection<Files> Files { get; set; }
        public virtual ICollection<UserMessage> UserMessages { get; set; }
    }
}

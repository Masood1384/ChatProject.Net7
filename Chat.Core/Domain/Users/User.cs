using Chat.Core.Commons;
using Chat.Core.Domain.Groups;
using Chat.Core.Domain.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core.Domain.Users
{
    public class User:BaseEntity
    {
        public string UserName { get; set; }
        public bool Online { get; set; }
        public string Password { get; set; }
        public bool EmailConiform { get; set; }
        public DateTime CreateOn { get; set; }
        public bool Deleted { get; set; }

        // Navigation
        public virtual Profile Profile { get; set; }
        public virtual UserAuth UserAuth { get; set; }
        public virtual ICollection<Story> Stories { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }
        public virtual ICollection<UserMessage> UserMessages { get; set; }

    }
}

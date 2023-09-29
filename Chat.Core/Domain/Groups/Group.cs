using Chat.Core.Commons;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core.Domain.Groups
{
    public class Group:BaseEntity
    {
        public string Name { get; set; }
        public string InviteLink { get; set; }

        [AllowNull]
        public string Pinmessage { get; set; }

        //Navigation 
        public virtual ICollection<UserGroup> UserGroups { get; set; }
    }
}

using Chat.Core.Commons;
using Chat.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core.Domain.Groups
{
    public class UserGroup:BaseRelation
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
        //Navigation
        public virtual Group Group { get; set; }
        public virtual User User { get; set; }

    }


}

using Chat.Core.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core.Domain.Users
{
    public class Story:BaseEntity
    {
        public string File { get; set; }
        public string MimeType { get; set; }
        public int UserId { get; set; }
        //Navigations
        public virtual User User { get; set; }
    }
}

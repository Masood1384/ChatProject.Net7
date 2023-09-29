using Chat.Core.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core.Domain.Users
{
    public class Profile:BaseEntity
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Bio { get; set; }
        public int UserId { get; set; }
        //Navigations
        public virtual User User { get; set; }
    }
}

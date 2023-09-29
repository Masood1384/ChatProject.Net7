using Chat.Core.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core.Domain.Users
{
    public class UserAuth:BaseEntity
    {
        public string Token { get; set; }
        public DateTime ExpiresToken { get; set; }
        public DateTime CreateToken { get; set; }
        public int UserId { get; set; }
        //Navigations
        public virtual User User { get; set; }
    }
}

using Chat.Core.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core.Domain.Users
{
    public class ViewStory:BaseEntity
    {
        public string UserName { get; set; }
        public string UserImage { get; set; }
        public int StoryId { get; set; }
    }
}

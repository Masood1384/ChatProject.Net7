using Chat.Core.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core.Domain.Messages
{
    public class Files:BaseEntity
    {
        public string File { get; set; }
        public string MimeType { get; set; }
        public int MessageId { get; set; }

        //Navigations
        public virtual Message Message { get; set; }
    }
}

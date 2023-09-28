﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Service.Tools.Emailsender
{
    public interface IEmailSenderService
    {
        Task SendEmail(string To, string Subject, string Body);
    }
}

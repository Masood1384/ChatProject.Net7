﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Service.Middleware
{
    public interface IErrorHandler
    {
        string ErrorMessage { get; set; }
        int StatusCode { get; set; }

        void GetError(Exception ex);
    }
}

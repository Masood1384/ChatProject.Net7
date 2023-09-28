using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Chat.Service.Tools.Emailsender;
using Chat.Core.Infrastructure;

namespace Chat.Service.Infrastructure
{
    public class CommonStratup : IApplicationStartup
    {
        public MiddleWarePriority Priority => MiddleWarePriority.Normal;
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            //Rigester services
            services.AddTransient<IEmailSenderService, EmailSenderService>();
        }

        public void Configure(IApplicationBuilder app)
        {

        }


    }
}

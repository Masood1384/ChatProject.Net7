﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Chat.Core.Infrastructure;
using Chat.Data.Repository;
using Chat.Data.Context;

namespace Chat.Data.Infrastructure
{
    public class DataBaseStartUp : IApplicationStartup
    {
        public MiddleWarePriority Priority => MiddleWarePriority.AboveNormal;

        public void Configure(IApplicationBuilder app)
        {

        }

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            //Install Services
            services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));

            services.AddDbContextPool<IApplicationContext, SqlServerApplicationContext>((options) =>
            {
                options.UseSqlServer("Data Source=.;Initial Catalog=Chat;Integrated Security = true;Encrypt=False;").UseLazyLoadingProxies();
            }, poolSize: 16);
        }
    }
}

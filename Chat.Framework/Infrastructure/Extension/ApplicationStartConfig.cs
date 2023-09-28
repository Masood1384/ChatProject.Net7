using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.Core.Extension;
using Chat.Core.Infrastructure;

namespace Chat.Framework.Infrastructure.Extension
{
    public static class ApplicationStartConfig
    {
        public static void ConfigureRequestPipeline(this IApplicationBuilder application)
        {
            var list = typeof(IApplicationStartup).GetAllClassTypes();
            List<IApplicationStartup> listObject = new List<IApplicationStartup>();

            foreach (var TypeItem in list)
            {
                var ob = Activator.CreateInstance(TypeItem) as IApplicationStartup;
                listObject.Add(ob);
            }

            foreach (var item in listObject)
            {
                item.Configure(application);
            }
        }

    }
}

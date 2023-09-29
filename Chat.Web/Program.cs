using Chat.Framework.Infrastructure.Extension;
using Serilog;
using Serilog.Formatting.Compact;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureApplicationServices(builder.Configuration);
////// *SeriLog
builder.Host.UseSerilog(((context, provider, logger) =>
{
    logger.MinimumLevel.Information().WriteTo.File("log.txt",
        rollingInterval: RollingInterval.Day,
        rollOnFileSizeLimit: true, restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Error
    ).WriteTo.File(new RenderedCompactJsonFormatter(), "log.ndjson", restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Warning);
}));
var app = builder.Build();
//app.UseCors(x => x
//                    .AllowAnyMethod()
//                    .AllowAnyHeader()
//                    .SetIsOriginAllowed(origin => true) // allow any origin
//                    .AllowCredentials());

app.UseStaticFiles();
app.ConfigureRequestPipeline();

app.Run();

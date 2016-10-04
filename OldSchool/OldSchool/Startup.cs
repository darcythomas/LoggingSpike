using Microsoft.Extensions.Logging;
using Microsoft.Owin;
using Owin;
using Serilog;

[assembly: OwinStartupAttribute(typeof(OldSchool.Startup))]
namespace OldSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app, ILoggerFactory loggerFactory)
        {
            ConfigureAuth(app);

            Log.Logger = new LoggerConfiguration()
     .Enrich.FromLogContext()
     .WriteTo.LiterateConsole()
     .CreateLogger();



            loggerFactory.AddSerilog();
        }
    }
}

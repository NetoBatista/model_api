using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ModelAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
           .AddJsonFile("Config/appsettings.json", optional: false)
           .Build();

           var port = config.GetSection("AppInfo").GetValue<int>("Port");

           CreateWebHostBuilder(args, port).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args, int port){
            var webHost = WebHost.CreateDefaultBuilder(args);
            webHost.ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddConsole();
            });
            webHost.ConfigureAppConfiguration(webBuilder => {
                webBuilder.AddJsonFile("Config/appsettings.json", optional: false, reloadOnChange: true);
            })
            .UseUrls("http://*:" + port.ToString())
            .UseKestrel(options =>
            {
                options.Limits.MaxRequestBodySize = int.MaxValue;
            })
            .UseStartup<Startup>();

            return webHost;
        }
    }
}

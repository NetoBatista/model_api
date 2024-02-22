using Microsoft.AspNetCore;

namespace Model.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var webHost = WebHost.CreateDefaultBuilder(args);
            webHost.UseStartup<Startup>();
            webHost.ConfigureAppConfiguration(webBuilder =>
            {
                webBuilder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            });

            var port = Environment.GetEnvironmentVariable("PORT");

            if (!string.IsNullOrEmpty(port))
            {
                webHost.UseUrls("http://*:" + port.ToString());
            }

            webHost.UseKestrel(options =>
            {
                options.Limits.MaxRequestBodySize = long.MaxValue;
                options.Limits.MaxRequestBufferSize = long.MaxValue;
            });

            webHost.ConfigureKestrel(options =>
            {
                options.Limits.MaxRequestBodySize = long.MaxValue;
                options.Limits.MaxRequestBufferSize = long.MaxValue;
            });
            return webHost;
        }
    }
}

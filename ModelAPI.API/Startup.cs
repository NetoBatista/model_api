using System.Text.Json.Serialization;
using ModelAPI.Domain.Interfaces;
using ModelAPI.Infra.Data;
using ModelAPI.Infra.Data.Repository;
using ModelAPI.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ModelAPI.API.Extension;
using ModelAPI.API.Extension.WhatsAppAPI;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace ModelAPI
{

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddCors(options =>
            {
                options.AddPolicy(name: "*",
                                builder =>
                                {
                                    builder.AllowAnyHeader();
                                    builder.AllowAnyMethod();
                                    builder.AllowAnyOrigin();
                                });
            });

            services.InjectionServices();
                        
            BearerExtension.Configure(services,Configuration);
            services.AddResponseCompression();
            services.AddHttpContextAccessor();
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddControllers()
                .AddNewtonsoftJson()
                .AddJsonOptions(options => 
                {
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                })
                .SetCompatibilityVersion(CompatibilityVersion.Latest);

            services.Swagger();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseGlobalExceptionHandler();

            app.UseCors("*");

            app.UseRouting();
            
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("v1/swagger.json", "Model API V1");
                options.DocExpansion(DocExpansion.None);
            });

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute().RequireAuthorization();
                endpoints.MapControllers();
            });
        }

    }
}

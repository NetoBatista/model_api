using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelAPI.API.Extension
{
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.OpenApi.Models;

    namespace WhatsAppAPI
    {
        public static class SwaggerExtension
        {
            public static void Swagger(this IServiceCollection services)
            {
                services.AddSwaggerGen(sw =>
                {
                    sw.EnableAnnotations();

                    sw.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Model API",
                        Version = "v1"
                    });

                    var currentAssembly = Assembly.GetExecutingAssembly();
                    var xmlDocs = currentAssembly.GetReferencedAssemblies()
                        .Union(new AssemblyName[] { currentAssembly.GetName() })
                        .Select(referencedAssembly => Path.Combine(Path.GetDirectoryName(currentAssembly.Location), $"{referencedAssembly.Name}.xml"))
                        .Where(f => File.Exists(f)).ToArray();

                    foreach (var xml in xmlDocs)
                    {
                        sw.IncludeXmlComments(xml);
                    }
                });
            }

        }
    }
}

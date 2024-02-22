using Microsoft.OpenApi.Models;
using System.Reflection;

namespace Model.API.Extension
{
    public static class SwaggerExtension
    {
        public static void ConfigureSwagger(this IServiceCollection services)
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

                // JWT
                //var securityScheme = new OpenApiSecurityScheme
                //{
                //    Name = "JWT Authentication",
                //    Description = "Entre com sua chave para poder testar os recursos",
                //    In = ParameterLocation.Header,
                //    Type = SecuritySchemeType.Http,
                //    Scheme = "bearer",
                //    BearerFormat = "JWT",
                //    Reference = new OpenApiReference
                //    {
                //        Id = JwtBearerDefaults.AuthenticationScheme,
                //        Type = ReferenceType.SecurityScheme
                //    }
                //};

                //sw.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme);
                //sw.AddSecurityRequirement(new OpenApiSecurityRequirement
                //    {
                //        {securityScheme, new string[] { }}
                //    });

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

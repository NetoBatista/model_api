using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;
using ModelAPI.Domain.DTO;
using System.Threading.Tasks;
using System.Net;

namespace ModelAPI
{
    public static class ExceptionMiddleware
    {
        public static void UseGlobalExceptionHandler(this IApplicationBuilder app)
        {

            app.UseExceptionHandler(builder =>
            {
                builder.Run(async context =>
                {
                    var exceptionHandler = context.Features.Get<IExceptionHandlerPathFeature>();

                    if(exceptionHandler.Error != null)
                    {
                        await Log(context, exceptionHandler);
                    }
                    await context.Response.WriteAsync(JsonConvert.SerializeObject(GenericError()));
                });
            });
        }


        private static async Task Log(HttpContext context, IExceptionHandlerPathFeature exceptionHandler)
        {
            //log
        }

        private static ResponseAPI GenericError()
        {
            return new ResponseAPI { Message = "An error has occurred on the server. Please contact the administrator."};
        }

    }
}

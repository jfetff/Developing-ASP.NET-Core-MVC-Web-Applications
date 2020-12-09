using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigureMiddlewareExample
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.


        /*
        public void Configure(IApplicationBuilder app)
        {
            // el context.Request.Path.Value recoge todo lo que agreguemos despues del puerto y el path y lo pinta en la página
            app.Use(async (context, next) =>
            {
                if (context.Request.Query.ContainsKey("id")) { 
                    await context.Response.WriteAsync($"Este texto ha sido generado por la app.use del Middleware. El camnio del Request es: " + context.Request.Path.Value + "\n");
                    await next.Invoke();
                }
            });
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Este texto ha sido generado por la app.Run del Middleware. El camnio del Request es: " + context.Request.Path.Value + "\n");
            });
        }
        */
        // Esto estaba antes

        public void Configure(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Este texto fue generado por la aplicación. Use middleware. La ruta de la solicitud es: " + context.Request.Path.Value + "\n");
                await next.Invoke();
            });
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Este texto ha sido generado por el middleware app.Run.");
            });
        }
    }
}

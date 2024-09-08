using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVC_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Home", async context =>
                {
                    await context.Response.WriteAsync("You are at the home page!");
                });
                endpoints.MapGet("/Products/{ID:int?}", async context =>
                {

                    var idData = context.Request.RouteValues["ID"];
                    if (idData is not null)
                    {
                        int data = Convert.ToInt32(idData);
                        await context.Response.WriteAsync($"You are at the page of prod {data}!");
                    }
                    else
                    {
                      await context.Response.WriteAsync("You are at Products Page!");
                    }
                });
                endpoints.MapGet("/Books/{ID}/{Author:alpha:minlength(5):maxlength(10)}", async context =>
                {
                    int id = Convert.ToInt32(context.Request.RouteValues["ID"]);
                    string author = context.Request.RouteValues["Author"].ToString();
                    await context.Response.WriteAsync($"You are at the books page with id {id} and author {author}!");
                });
            });
            //app.MapGet("/Home", () => "Hello World!");
            app.Run(async (HttpContext) => { await HttpContext.Response.WriteAsync("Page not found"); });

            app.Run();
        }
    }
}

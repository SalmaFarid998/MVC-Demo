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
                endpoints.MapGet("/Products", async context =>
                {
                    await context.Response.WriteAsync("You are at the products page!");
                });
            });
            //app.MapGet("/Home", () => "Hello World!");
            app.Run(async (HttpContext) => { await HttpContext.Response.WriteAsync("Page not found"); });

            app.Run();
        }
    }
}

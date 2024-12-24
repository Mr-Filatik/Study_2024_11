using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Applications.Web.BlazorApp.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddScoped(e =>
                new HttpClient()
                {
                    BaseAddress = new Uri("https://localhost:7193/api/")
                });

            await builder.Build().RunAsync();
        }
    }
}

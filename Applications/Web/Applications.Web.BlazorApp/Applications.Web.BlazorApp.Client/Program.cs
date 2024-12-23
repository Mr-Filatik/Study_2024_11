using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Applications.Web.BlazorApp.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            await builder.Build().RunAsync();
        }
    }
}

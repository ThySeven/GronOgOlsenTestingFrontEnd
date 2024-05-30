using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using GronOgOlsenFrontEnd;
using GronOgOlsenFrontEnd.Services;

namespace GronOgOlsenFrontEnd
{
    public class Program
    {
        private static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<UserState>();
            builder.Services.AddSingleton<LotState>();
            builder.Services.AddSingleton<InvoiceState>();



            await builder.Build().RunAsync();
        }
    }
}
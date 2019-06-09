using Function.DependencyInjection.Services;
using Function.DependencyInjection.Services.Contracts;
using Function.DependencyInjection.Timer;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]
namespace Function.DependencyInjection.Timer
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<IHelloService, HelloService>();
        }
    }
}

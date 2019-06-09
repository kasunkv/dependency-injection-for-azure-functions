using Function.DependencyInjection.Services.Contracts;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Function.DependencyInjection.Timer
{
    public class TimeFunction
    {
        private readonly IHelloService _helloService;

        public TimeFunction(IHelloService helloService)
        {
            _helloService = helloService;
        }

        [FunctionName("TimeFunction")]
        public void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"OUTPUT: {_helloService.SayHello("Kasun Kodagoda")}");
        }
    }
}

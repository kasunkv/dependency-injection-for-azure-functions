using Function.DependencyInjection.Services.Contracts;

namespace Function.DependencyInjection.Services
{
    public class HelloService : IHelloService
    {
        public string SayHello(string name)
        {
            return $"Hello, {name}";
        }
    }
}

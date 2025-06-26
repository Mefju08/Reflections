using Reflections.Terminal.App.Interfaces;

namespace Reflections.Terminal.App.Models
{
    internal class ServiceB : IRunnable
    {
        public void Run() => Console.WriteLine("ServiceB running...");
    }
}

using Reflections.Terminal.App.Interfaces;

namespace Reflections.Terminal.App.Models
{
    internal class ServiceA : IRunnable
    {
        public void Run() => Console.WriteLine("ServiceA running...");
    }
}

using Reflections.Terminal.App.Interfaces;

namespace Reflections.Terminal.App.Tasks
{
    internal class Task9_InterfaceExecutor
    {
        public void Run()
        {
            var assembly = GetType().Assembly;
            var searchingTypes = assembly
                .GetTypes()
                .Where(x => typeof(IRunnable).IsAssignableFrom(x) && x != typeof(IRunnable))
                .ToList();

            foreach (var type in searchingTypes)
            {
                var instance = (IRunnable)Activator.CreateInstance(type);
                instance.Run();
            }
        }
    }
}

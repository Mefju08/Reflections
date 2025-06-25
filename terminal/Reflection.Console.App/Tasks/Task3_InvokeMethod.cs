using System.Reflection;

namespace Reflections.Terminal.App.Tasks
{
    internal sealed class Task3_InvokeMethod
    {
        private const string _nameOfMethodToInvoke = "Greet";
        public void Run(object obj)
        {
            var objType = obj.GetType();
            var methods = objType.GetMethods(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Where(x => !x.IsSpecialName);

            var methodToInvoke = methods.SingleOrDefault(x => x.Name == _nameOfMethodToInvoke);
            if (methodToInvoke is null)
                return;

            methodToInvoke.Invoke(obj, null);
        }
    }
}

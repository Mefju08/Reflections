using System.Reflection;

namespace Reflections.Terminal.App.Tasks
{
    internal sealed class Task6_InvokeMethodWithArgs
    {
        public object Run(object obj, string methodName, object[] args)
        {
            var objType = obj.GetType();

            var method = objType.GetMethods().SingleOrDefault(x => x.Name == methodName);
            if (method is null)
                return null;

            var parameters = method.GetParameters();

            bool hasMatchingParameters = HasMatchingParameters(parameters, args);
            if (!hasMatchingParameters)
                return null;

            return method.Invoke(obj, args);
        }

        private bool HasMatchingParameters(ParameterInfo[] parameters, object[] args)
        {
            if (parameters.Length != args.Length)
                return false;

            for (var i = 0; i < parameters.Length; i++)
            {
                var arg = args[i];
                var parameter = parameters[i];

                if (parameter.ParameterType != arg.GetType())
                    return false;
            }

            return true;
        }
    }
}

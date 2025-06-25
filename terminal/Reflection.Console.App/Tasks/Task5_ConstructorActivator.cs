using System.Reflection;

namespace Reflections.Terminal.App.Tasks
{
    internal sealed class Task5_ConstructorActivator
    {
        public object Run(object obj, object[] args)
        {
            var objType = obj.GetType();
            var contructors = objType.GetConstructors();
            foreach (var constructor in contructors)
            {
                var parameters = constructor.GetParameters();
                if (parameters.Length != args.Length)
                    continue;

                bool hasMatchingParam = HasMatchingParameters(parameters, args);
                if (!hasMatchingParam)
                    continue;

                var newObj = constructor.Invoke(args);
                return newObj;
            }
            return null;
        }

        private bool HasMatchingParameters(ParameterInfo[] parameters, object[] args)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                if (args.Length < i)
                    return false;

                var arg = args[i];
                var param = parameters[i];

                if (param.ParameterType != arg.GetType())
                    return false;
            }

            return true;
        }
    }
}

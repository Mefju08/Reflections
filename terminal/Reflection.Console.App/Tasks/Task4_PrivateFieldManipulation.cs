using System.Reflection;

namespace Reflections.Terminal.App.Tasks
{
    internal sealed class Task4_CreateInstance
    {
        private const string _fieldToUpdateName = "_pesel";
        private object _newValue = "432432";

        public void Run(object obj)
        {
            var objType = obj.GetType();
            var privateFileds = objType.GetFields(
                BindingFlags.NonPublic | BindingFlags.DeclaredOnly | BindingFlags.Instance)
                .Where(x => !x.Name.Contains("k__BackingField"));

            var fileToUpdate = privateFileds.SingleOrDefault(x => x.Name == _fieldToUpdateName);
            if (fileToUpdate is null)
                return;

            fileToUpdate.SetValue(obj, _newValue);
        }
    }
}

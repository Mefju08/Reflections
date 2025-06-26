using System.Reflection;

namespace Reflections.Terminal.App.Tasks
{
    internal sealed class Task8_AttributeReader
    {
        public void Run(object obj)
        {
            var objType = obj.GetType();

            List<string> results = new List<string>();

            var properties = objType.GetProperties(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Where(x => x.CustomAttributes.Any())
                .ToList();
            foreach (var property in properties)
            {
                foreach (var attribute in property.CustomAttributes)
                {
                    results.Add($"[Property] {property.Name} - {attribute.AttributeType.Name}");
                }

            }

            var fields = objType.GetFields(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Where(x => x.CustomAttributes.Any())
                .ToList();
            foreach (var field in fields)
            {
                foreach (var attribute in field.CustomAttributes)
                {
                    results.Add($"[Field] {field.Name} - {attribute.AttributeType.Name}");
                }

            }

            results
                .Where(x => !x.Contains("k__BackingField"))
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}

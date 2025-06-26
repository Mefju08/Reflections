using System.Reflection;

namespace Reflections.Terminal.App.Tasks
{
    internal sealed class Task7_MemberAccessor
    {
        public object GetValue(object obj, string memberName)
        {
            var objType = obj.GetType();

            var field = objType.GetFields(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .SingleOrDefault(x => x.Name == memberName);

            if (field is not null)
            {
                return field.GetValue(obj);
            }


            var property = objType.GetProperties(
               BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
               .SingleOrDefault(x => x.Name == memberName);

            if (property is not null)
            {
                return property.GetValue(obj);
            }

            return null;
        }

        public void SetValue(object obj, string memberName, object value)
        {
            var objType = obj.GetType();

            var field = objType.GetFields(
                 BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                 .SingleOrDefault(x => x.Name == memberName);

            if (field is not null && field.FieldType == value.GetType())
            {
                field.SetValue(obj, value);
                return;
            }


            var property = objType.GetProperties(
               BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
               .SingleOrDefault(x => x.Name == memberName);

            if (property is not null && property.PropertyType == value.GetType())
            {
                property.SetValue(obj, value);
                return;
            }
        }
    }
}

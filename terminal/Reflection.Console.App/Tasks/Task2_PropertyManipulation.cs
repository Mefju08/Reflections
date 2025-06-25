using Reflections.Terminal.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections.Terminal.App.Tasks
{
    internal sealed class Task2_PropertyManipulation
    {
        private readonly Dictionary<string, object> _newValues;
        public Task2_PropertyManipulation()
        {
            _newValues = new Dictionary<string, object>
            {
                { "Name", "David" },
                { "Age", 22 }
            };
        }
        public object Run(object obj)
        {
            var objType = obj.GetType();
            var newObj = Activator.CreateInstance(objType);

            foreach (var newValue in _newValues)
            {
                var property = objType.GetProperty(newValue.Key);
                if (property is null || !property.CanWrite)
                    continue;

                property.SetValue(newObj, newValue.Value);
            }

            return newObj;
        }
    }
}

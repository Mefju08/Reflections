using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Reflections.Terminal.App.Tasks
{
    internal sealed class Task1_TypeInspection
    {
        public void Run(object obj)
        {
            Console.WriteLine("Task 1 - type inspection");
            Console.WriteLine();

            var objType = obj.GetType();

            ShowObjectName(objType);

            ShowProperties(objType);

            ShowMethods(objType);

            ShowFields(objType);
        }

        private void ShowObjectName(Type objType)
        {
            Console.WriteLine($"Object name: {objType.Name}");
            Console.WriteLine();
        }
        private void ShowProperties(Type objType)
        {
            Console.WriteLine("Properties:");
            foreach (var property in objType.GetProperties())
            {
                Console.WriteLine($"-{property.PropertyType} {property.Name}");
            }
            Console.WriteLine();
        }
        private void ShowMethods(Type objType)
        {
            Console.WriteLine("Methods:");

            var methods = objType.GetMethods(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Where(x => !x.IsSpecialName);
            foreach (var method in methods)
            {
                var methodParamteres = method.GetParameters().Select(x => x.Name).ToList();

                Console.WriteLine($"-{method.Name}({string.Join(',', methodParamteres)})");
            }

            Console.WriteLine();
        }
        private void ShowFields(Type objType)
        {
            Console.WriteLine("Fields:");
            var fields = objType.GetFields(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                             
            foreach (var field in fields)
            {
                Console.WriteLine($"-{field.Name}");
            }

            Console.WriteLine();
        }
    }
}

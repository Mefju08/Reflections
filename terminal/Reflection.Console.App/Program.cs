using Reflections.Terminal.App.Models;
using Reflections.Terminal.App.Tasks;

namespace Reflections.Terminal.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User()
            {
                Name = "Philip",
                Age = 42
            };

            //new Task1_TypeInspection().Run(user);
            //var obj = new Task2_PropertyManipulation().Run(user);
            //new Task3_InvokeMethod().Run(user);
            new Task4_CreateInstance().Run(user);

        }
    }
}

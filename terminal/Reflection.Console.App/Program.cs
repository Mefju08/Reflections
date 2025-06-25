using Reflections.Terminal.App.Models;
using Reflections.Terminal.App.Tasks;

namespace Reflections.Terminal.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            //new Task1_TypeInspection().Run(user);
            var obj = new Task2_PropertyManipulation().Run(user);

        }
    }
}

using Reflections.Terminal.App.Attributes;

namespace Reflections.Terminal.App.Models
{
    internal sealed class User
    {
        [InfoAttribute("Name property")]
        public string Name { get; set; }

        [InfoAttribute("Age property")]
        public int Age { get; set; }

        [InfoAttribute("Pesel private field")]
        private string _pesel = "123456789";

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Greet() => Console.WriteLine($"Hi, {Name}!");
        public void SetAge(int newAge) => Age = newAge;
    }
}

namespace Reflections.Terminal.App.Models
{
    internal sealed class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private string _pesel = "123456789";

        public void Greet() => Console.WriteLine($"Hi, {Name}!");
        public void SetAge(int newAge) => Age = newAge;
    }
}

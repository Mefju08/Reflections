namespace Reflections.Terminal.App.Attributes
{
    internal class InfoAttribute : Attribute
    {
        public string Label { get; }
        public InfoAttribute(string label)
        {
            Label = label;
        }
    }
}

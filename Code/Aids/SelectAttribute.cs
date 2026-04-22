namespace Abc.Aids
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class SelectAttribute(Type t, string displayProperty = null) : Attribute
    {
        public Type EntityType { get; } = t;
        public string displayProperty { get; } = string.IsNullOrEmpty(displayProperty) ? "Name" : displayProperty;
    }
}
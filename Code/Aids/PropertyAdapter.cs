using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Abc.Aids
{
    public interface IPropertyAdapter
    {
        public Type ItemType { get; }
        public object Item { get; }
        PropertyInfo PropInfo { get; }
        public Type PropType { get; }
        public Type UnderLyingType { get; }
        object PropValue { get; }
        void SetValue(object value);
    }
    public sealed class PropertyAdapter(object item, string propName) : IPropertyAdapter
    {
        public PropertyAdapter() : this(null, null) { }
        public Type ItemType => item?.GetType();
        public object Item => item;
        public PropertyInfo PropInfo => ItemType?.GetProperty(propName);
        public Type PropType => PropInfo?.PropertyType;
        public Type UnderLyingType => Nullable.GetUnderlyingType(PropType) ?? PropType;
        public object PropValue => PropInfo?.GetValue(item);
        public void SetValue(object value) => PropInfo?.SetValue(item, value);
    }
}

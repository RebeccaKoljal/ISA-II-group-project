using System.Reflection;

namespace Abc.Aids;

public static class Clone
{
    public static TClass Object<TClass>(TClass obj) where TClass : class, new() => (TClass)clone(obj);
    private const BindingFlags publicInstance = BindingFlags.Public | BindingFlags.Instance;
    private static object clone(object obj)
    {
        if (obj == null) return null;
        var t = obj.GetType();
        var o = Activator.CreateInstance(t);
        var props = t.GetProperties(publicInstance);
        copy(obj, o, props);
        return o;
    }
    private static void copy(object from, object to, PropertyInfo[] props)
    {
        foreach (var p in props)
        {
            if (!p.CanRead || !p.CanWrite) continue; // property must be getter and setter
            var v = p.GetValue(from);
            if (v != null && isClass(p)) // if it is a class, we need to clone it as well
                v = clone(v);
            p.SetValue(to, v);
        }
    }
    private static bool isClass(PropertyInfo p) => p.PropertyType.IsClass && p.PropertyType != typeof(string); // is class but not string
}

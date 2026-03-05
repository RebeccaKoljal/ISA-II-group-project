using System.Reflection;

namespace Abc.Tests.Aids
{
    public abstract class TestAids<TClass> where TClass : class, new() // provides helper methods for the tests
    {
        protected TClass obj;
        protected const BindingFlags publicDeclared = BindingFlags.Public
            | BindingFlags.Instance
            | BindingFlags.DeclaredOnly
            | BindingFlags.Static;

        protected static IEnumerable<string> GetProperties()
            => Abc.Aids.GetType.PropertyNames<TClass>(publicDeclared);
        protected static IEnumerable<string> GetMethods()
            => Abc.Aids.GetType.MethodNames<TClass>(publicDeclared, false);
    }
}

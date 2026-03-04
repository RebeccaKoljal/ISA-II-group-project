using System.Reflection;

namespace Abc.Tests.Data
{
    public abstract class BaseTests<TClass> where TClass : class, new()
    {
        private TClass obj;
        private const BindingFlags publicDeclared = BindingFlags.Public 
            | BindingFlags.Instance 
            | BindingFlags.DeclaredOnly
            | BindingFlags.Static;
        [TestInitialize] public void Initialize() => obj = new TClass();
        [TestMethod] public void CanCreateTest() => Assert.IsNotNull(obj);
        [TestMethod] public void IsCorrectClassTest() // checks if the test class is named correctly according to the convention
        {
            var className = typeof(TClass).Name;
            var testClassName = GetType().Name;
            Assert.AreEqual(testClassName.Replace("Tests", ""), className); 
        }
        [TestMethod] public void IsClassTestedTest() 
        {
            var testMethods = GetType().GetMethods().Select(x => x.Name);
            var membersToTest = getProperties().Concat(getMethods());
            foreach (var m in membersToTest)
            {
                if (!testMethods.Contains(m + "Test"))
                    Assert.Inconclusive($"{m} is not tested");
            }
        }

        private static IEnumerable<string> getProperties() => typeof(TClass)
            .GetProperties(publicDeclared)
            .Select(i => i.Name); // i as in info
        private static IEnumerable<string> getMethods() => Array.FindAll(
            typeof(TClass).GetMethods(publicDeclared),
            i => !i.IsSpecialName)
            .Select(i => i.Name);
    }
}

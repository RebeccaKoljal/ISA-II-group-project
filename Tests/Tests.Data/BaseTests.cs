using Abc.Aids;
using System.Formats.Asn1;

namespace Abc.Tests.Data
{
    public abstract class BaseTests<TClass> : TestAids<TClass> where TClass : class, new() // deals with tests
    {
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
            var membersToTest = GetProperties().Concat(GetMethods());
            foreach (var m in membersToTest)
            {
                if (!testMethods.Contains(m + "Test"))
                    Assert.Inconclusive($"{m} is not tested");
            }
        }
    }
}

namespace Abc.Tests.Data
{
    public abstract class BaseTests<TClass> where TClass : class, new()
    {
        private TClass obj;
        [TestInitialize] public void Initialize() => obj = new TClass();
        [TestMethod] public void CanCreateTest() => Assert.IsNotNull(obj);
    }
}

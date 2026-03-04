using Abc.Data;

namespace Abc.Tests.Data
{
    [TestClass]
    public sealed class MovieTests
    {
        private Movie movie;
        [TestInitialize] public void Initialize() => movie = new Movie();
        [TestMethod] public void CanCreateTest() => Assert.IsNotNull(movie);
    }

    [TestClass]
    public sealed class CountryTests
    {
        private Country movie;
        [TestInitialize] public void Initialize() => movie = new Country();
        [TestMethod] public void CanCreateTest() => Assert.IsNotNull(movie);
    }

    [TestClass]
    public sealed class CurrencyTests
    {
        private Currency movie;
        [TestInitialize] public void Initialize() => movie = new Currency();
        [TestMethod] public void CanCreateTest() => Assert.IsNotNull(movie);
    }
}

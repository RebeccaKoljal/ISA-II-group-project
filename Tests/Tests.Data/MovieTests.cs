using Abc.Data;
using Abc.Tests.Aids;
namespace Abc.Tests.Data;

[TestClass]
public sealed class MovieTests : BaseTests<Movie>
{
    [TestMethod] public void IdTest() => IsProperty<int>(nameof(Movie.Id));
    [TestMethod] public void TitleTest() => IsProperty<string>(nameof(Movie.Title));
    [TestMethod] public void ReleaseDateTest() => IsProperty<DateOnly>(nameof(Movie.ReleaseDate));
    [TestMethod] public void GenreTest() => IsProperty<string>(nameof(Movie.Genre));
    [TestMethod] public void PriceTest() => IsProperty<decimal>(nameof(Movie.Price));

}

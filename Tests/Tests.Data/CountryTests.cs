using Abc.Data;
using Abc.Tests.Aids;
namespace Abc.Tests.Data
{
    [TestClass] public sealed class CountryTests : BaseTests<Country> 
    {
        [TestMethod] public void OfficialNameTest() => IsProperty<string>(nameof(Country.OfficialName));
        [TestMethod] public void NativeNameTest() => IsProperty<string>(nameof(Country.NativeName));
        [TestMethod] public void NumericCodeTest() => IsProperty<string>(nameof(Country.NumericCode));
        // can i somehow test them or do i even need to test them 
        // [TestMethod] public void IsIsoCountryTest() => IsProperty<bool>(nameof(Country.IsIsoCountry));
        // [TestMethod] public void IsLoyaltyProgramTest() => IsProperty<bool>(nameof(Country.IsLoyaltyProgram));
        [TestMethod] public void IsoCodeTest() => IsProperty<string>(nameof(Country.IsoCode));
    }
}

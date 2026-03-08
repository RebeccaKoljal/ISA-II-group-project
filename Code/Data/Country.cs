namespace Abc.Data
{
    public class Country : NamedEntity
    {
        public int Id { get; set; }
        public string OfficialName { get; set; } = "";
        public string NativeName { get; set; } = "";
        public string NumericCOde { get; set; } = "";
        bool IsIsoCountry { get; set; }
        bool IsLoyaltyProgram { get; set; }
        public string IsoCode { get; set; } = "";
    }
}

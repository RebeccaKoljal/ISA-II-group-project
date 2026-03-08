using Abc.Data.Common;

namespace Abc.Data
{
    public class Currency : NamedEntity
    {
        public string NumericCode { get; set; } = "";
        public string MajorUnitSymbol { get; set; } = "";
        public string MinorUnitSymbol { get; set; } = "";
        public string RatioOfMinorUnit { get; set; }
        public bool IsIsoCurrency { get; set; }
    }
}
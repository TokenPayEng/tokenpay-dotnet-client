using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TokenPay.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Currency
    {
        [EnumMember(Value = "TRY")] Try,
        [EnumMember(Value = "USD")] Usd,
        [EnumMember(Value = "EUR")] Eur
    }
}
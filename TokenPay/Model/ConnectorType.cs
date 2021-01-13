using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum ConnectorType
    {
        [EnumMember(Value = "TOKENPOS")] TOKENPOS,

        [EnumMember(Value = "TOKENGATE")] TOKENGATE
    }
}
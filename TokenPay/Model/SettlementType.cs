using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum SettlementType
    {
        [EnumMember(Value = "SETTLEMENT")] Settlement,

        [EnumMember(Value = "BOUNCED_SETTLEMENT")]
        BouncedSettlement
    }
}
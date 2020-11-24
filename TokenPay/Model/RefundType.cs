using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum RefundType
    {
        [EnumMember(Value = "CANCEL")] Cancel,

        [EnumMember(Value = "REFUND")] Refund
    }
}
using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum RefundStatus
    {
        [EnumMember(Value = "FAILURE")] Failure,

        [EnumMember(Value = "SUCCESS")] Success
    }
}
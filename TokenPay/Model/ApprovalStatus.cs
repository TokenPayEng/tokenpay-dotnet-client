using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum ApprovalStatus
    {
        [EnumMember(Value = "FAILURE")] Failure,

        [EnumMember(Value = "SUCCESS")] Success
    }
}
using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum SubscriptionStatus
    {
        [EnumMember(Value = "ACTIVE")] Active,

        [EnumMember(Value = "PASSIVE")] Passive,

        [EnumMember(Value = "PENDING")] Pending
    }
}
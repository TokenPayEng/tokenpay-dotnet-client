using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum SubscriptionStatus
    {
        [EnumMember(Value = "ACTIVE")] Active,

        [EnumMember(Value = "PASSIVE")] Passive,

        [EnumMember(Value = "PENDING")] Pending,
        [EnumMember(Value = "DELETED")] Deleted,
        [EnumMember(Value = "PROCESSING")] Processing,
        [EnumMember(Value = "ANOMALY")] Anomaly,
        [EnumMember(Value = "WAITING")] Waiting,

    }
}
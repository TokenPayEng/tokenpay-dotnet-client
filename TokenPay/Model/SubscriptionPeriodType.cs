using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum SubscriptionPeriodType
    {
        [EnumMember(Value = "WEEK")] Week,

        [EnumMember(Value = "MONTH")] Month,

        [EnumMember(Value = "YEAR")]
        Year
    }
}
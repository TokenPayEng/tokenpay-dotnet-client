using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum Status
    {
        [EnumMember(Value = "DELETED")] Deleted,
        [EnumMember(Value = "PASSIVE")] Passive,
        [EnumMember(Value = "ACTIVE")] Active
    }
}
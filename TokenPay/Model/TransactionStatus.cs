using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum TransactionStatus
    {
        [EnumMember(Value = "WAITING_FOR_APPROVAL")]
        WaitingForApproval,
        [EnumMember(Value = "APPROVED")] Approved,
        [EnumMember(Value = "PAYOUT_STARTED")] PayoutStarted
    }
}
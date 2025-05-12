using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum PayoutStatus
    {
        [EnumMember(Value = "NO_PAYOUT")] NoPayout,

        [EnumMember(Value = "WAITING_FOR_PAYOUT")] WaitingForPayout,

        [EnumMember(Value = "PAYOUT_STARTED")] PayoutStarted,

        [EnumMember(Value = "PAYOUT_COMPLETED")] PayoutCompleted
    }
}
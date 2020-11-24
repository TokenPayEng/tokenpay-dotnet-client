using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum CrossBookingTransactionStatus
    {
        [EnumMember(Value = "WAITING_FOR_PAYOUT")] WaitingForPayout,

        [EnumMember(Value = "PAYOUT_STARTED")] PayoutStarted,

        [EnumMember(Value = "PAYOUT_COMPLETED")] PayoutCompleted,

        [EnumMember(Value = "NOT_FOUND_IN_SETTLEMENT")] NotFoundInSettlement,
        
        [EnumMember(Value = "CANCELLED")] Cancelled
    }
}
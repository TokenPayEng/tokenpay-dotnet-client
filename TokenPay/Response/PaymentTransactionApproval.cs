using TokenPay.Model;

namespace TokenPay.Response
{
    public class PaymentTransactionApproval
    {
        public long? PaymentTransactionId { get; set; }
        public ApprovalStatus? ApprovalStatus { get; set; }
        public string FailedReason { get; set; }
    }
}
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class SearchPaymentTransactionRefundsRequest : IRequest
    {
        public long? PaymentId { get; set; }
        public string ConversationId { get; set; }
        public long? PaymentTransactionId { get; set; }
    }
}
using TokenPay.Model;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class RefundPaymentTransactionRequest : IRequest
    {
        public long? PaymentTransactionId { get; set; }

        public string ConversationId { get; set; }

        public decimal? RefundPrice { get; set; }

        public RefundDestinationType RefundDestinationType { get; set; } = RefundDestinationType.Card;
    }
}
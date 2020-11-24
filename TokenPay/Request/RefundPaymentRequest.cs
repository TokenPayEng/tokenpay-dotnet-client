using TokenPay.Model;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class RefundPaymentRequest : IRequest
    {
        public long? PaymentId { get; set; }

        public string ConversationId { get; set; }

        public RefundDestinationType RefundDestinationType { get; set; } = RefundDestinationType.Card;
    }
}
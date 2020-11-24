using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class CompleteThreeDSPaymentRequest : IRequest
    {
        public long? PaymentId { get; set; }
    }
}
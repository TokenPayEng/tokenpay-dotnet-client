using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class SubscriptionRenewRequest : IRequest
    {
        public long SubscriptionId { get; set; }
    }
}
using TokenPay.Model;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class SubscriptionSearchRequest : IRequest
    {
        public long SubscriptionId { get; set; }
        public SubscriptionStatus? Status { get; set; }
        public SubscriptionPeriodType? PeriodType { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}
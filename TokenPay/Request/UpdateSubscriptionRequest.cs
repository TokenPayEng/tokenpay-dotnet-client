using TokenPay.Model;
using TokenPay.Request.Common;
using TokenPay.Request.Dto;

namespace TokenPay.Request
{
    public class UpdateSubscriptionRequest : IRequest
    {
        public long SubscriptionId { get; set; }
        public SubscriptionStatus? Status { get; set; }
        public SubscriptionPeriodType? PeriodType { get; set; }
        public decimal? Price { get; set; }
        public int NochargeDayCount { get; set; }
        public SubscriptionCard Card { get; set; }
    }
}
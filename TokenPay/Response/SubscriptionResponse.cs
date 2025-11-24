using TokenPay.Model;
using System;

namespace TokenPay.Response
{
    public class SubscriptionResponse
    {
        public long? Id { get; set; }

        public long? MerchantId { get; set; }

        public long? BuyerId { get; set; }

        public string CardUserKey { get; set; }

        public string CardToken { get; set; }

        public string Description { get; set; }

        public decimal? Price { get; set; }

        public int? NoChargeDayCount { get; set; }
        public SubscriptionStatus? Status { get; set; }

        public SubscriptionPeriodType? PeriodType { get; set; }
        
        public DateTime? NextPaymentDate { get; set; }

    }
}
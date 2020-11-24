using TokenPay.Model;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class CrossBookingRequest : IRequest
    {
        public string Reason { get; set; }

        public decimal? Price { get; set; }

        public Currency Currency { get; set; }

        public long? SubMerchantId { get; set; }
    }
}
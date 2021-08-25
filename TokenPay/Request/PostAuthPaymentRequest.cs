using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class PostAuthPaymentRequest : IRequest
    {
        public decimal? PaidPrice { get; set; }
    }
}
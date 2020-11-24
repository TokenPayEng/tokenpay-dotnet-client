using TokenPay.Model;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class SearchInstallmentsRequest : IRequest
    {
        public string BinNumber { get; set; }
        public decimal? Price { get; set; }
        public Currency? Currency { get; set; }
    }
}
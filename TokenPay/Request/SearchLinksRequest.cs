using TokenPay.Model;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class SearchLinksRequest : IRequest
    {
        public string Name { get; set; }
        public string Token { get; set; }
        public Status Status { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}
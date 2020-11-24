using System.Collections.Generic;
using TokenPay.Model;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class SearchSubMerchantsRequest : IRequest
    {
        public string Name { get; set; }
        public ISet<long> SubMerchantIds { get; set; }
        public string SubMerchantExternalId { get; set; }
        public SubMerchantType? SubMerchantType { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}
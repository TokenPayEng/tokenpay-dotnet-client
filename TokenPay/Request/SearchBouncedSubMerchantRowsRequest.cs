using System;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class SearchBouncedSubMerchantRowsRequest : IRequest
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
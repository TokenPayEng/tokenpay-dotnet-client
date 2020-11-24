using System.Collections.Generic;
using TokenPay.Response.Dto;

namespace TokenPay.Response
{
    public class BouncedSubMerchantRowListResponse
    {
        public long? Size { get; set; }
        public IList<BouncedSubMerchantRow> Items { get; set; }
    }
}
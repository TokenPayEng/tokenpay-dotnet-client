using System.Collections.Generic;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class UpdatePaymentTransactionsRequest : IRequest
    {
        public long SubMerchantId { get; set; }

        public decimal SubMerchantPrice { get; set; }
    }
}
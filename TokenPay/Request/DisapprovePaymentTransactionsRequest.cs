using System.Collections.Generic;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class DisapprovePaymentTransactionsRequest : IRequest
    {
        public ISet<long> PaymentTransactionIds { get; set; }

        public bool IsTransactional { get; set; } = false;
    }
}
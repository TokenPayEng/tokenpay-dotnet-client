using System.Collections.Generic;

namespace TokenPay.Response
{
    public class PayoutCompletedTransactionListResponse
    {
        public long? Size { get; set; }
        public IList<PayoutCompletedTransaction> Items { get; set; }
    }
}
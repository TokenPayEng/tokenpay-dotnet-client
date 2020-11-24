using System.Collections.Generic;

namespace TokenPay.Response
{
    public class PaymentTransactionApprovalListResponse
    {
        public long? Size { get; set; }
        public IList<PaymentTransactionApproval> Items { get; set; }
    }
}
using System;
using TokenPay.Model;

namespace TokenPay.Response
{
    public class CrossBookingTransactionResponse
    {
        public long? Id { get; set; }
        public decimal? Price { get; set; }
        public DateTime? CreatedDate { get; set; }
        public CrossBookingTransactionStatus? TransactionStatus { get; set; }
    }
}
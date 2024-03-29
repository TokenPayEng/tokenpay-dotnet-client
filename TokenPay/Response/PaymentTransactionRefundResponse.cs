using System;
using TokenPay.Model;

namespace TokenPay.Response
{
    public class PaymentTransactionRefundResponse
    {
        public long? Id { get; set; }
        public string ConversationId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public RefundStatus? Status { get; set; }
        public bool? IsAfterSettlement { get; set; }
        public decimal? RefundPrice { get; set; }
        public decimal? RefundBankPrice { get; set; }
        public decimal? RefundWalletPrice { get; set; }
        public Currency Currency { get; set; }
        public long? PaymentTransactionId { get; set; }
        public long? PaymentId { get; set; }
        public RefundDestinationType RefundDestinationType { get; set; }
    }
}
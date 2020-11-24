using TokenPay.Model;

namespace TokenPay.Response
{
    public class PayoutCompletedTransaction
    {
        public long? TransactionId { get; set; }
        public string TransactionType { get; set; }
        public decimal? PayoutAmount { get; set; }
        public Currency Currency { get; set; }
        public long? MerchantId { get; set; }
        public MerchantType? MerchantType { get; set; }
    }
}
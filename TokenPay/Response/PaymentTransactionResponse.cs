using TokenPay.Model;

namespace TokenPay.Response.Dto
{
    public class PaymentTransactionResponse
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        public TransactionStatus? TransactionStatus { get; set; }
        public decimal? Price { get; set; }
        public decimal? PaidPrice { get; set; }
        public decimal? WalletPrice { get; set; }
        public decimal? MerchantPayoutAmount { get; set; }
        public long? SubMerchantId { get; set; }
        public decimal? SubMerchantPrice { get; set; }
        public decimal? SubMerchantPayoutRate { get; set; }
        public decimal? SubMerchantPayoutAmount { get; set; }
        public Payout Payout { get; set; }
    }
}
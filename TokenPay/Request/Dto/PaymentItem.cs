namespace TokenPay.Request.Dto
{
    public class PaymentItem
    {
        public string Name { get; set; }
        public decimal? Price { set; get; }
        public string ExternalId { get; set; }
        public long? SubMerchantId { get; set; }
        public decimal? SubMerchantPrice { get; set; }
    }
}
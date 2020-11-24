using TokenPay.Model;

namespace TokenPay.Response.Dto
{
    public class Payout
    {
        public decimal? PaidPrice { get; set; }
        public Currency Currency { get; set; }
        public decimal? MerchantPayoutAmount { get; set; }
        public decimal? SubMerchantPayoutAmount { get; set; }
        public decimal? PfCommissionRateAmount { get; set; }
        public decimal? PfConversionRate { get; set; }
        public decimal? PfConversionRateAmount { get; set; }
    }
}
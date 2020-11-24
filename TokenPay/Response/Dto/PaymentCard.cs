using TokenPay.Model;

namespace TokenPay.Response.Dto
{
    public class PaymentCard
    {
        public CardType? CardType { get; set; }
        public CardAssociation? CardAssociation { get; set; }
        public string CardBrand { get; set; }
        public string CardHolderName { get; set; }
        public string BinNumber { get; set; }
        public string LastFourDigits { get; set; }
        public int? Installment { get; set; }
        public bool? IsThreeDS { get; set; }
        public int? MdStatus { get; set; }
        public decimal? PfCommissionRateAmount { get; set; }
        public decimal? MerchantCommissionRate { get; set; }
        public decimal? MerchantCommissionRateAmount { get; set; }
        public Error Error { get; set; }
    }
}
using TokenPay.Model;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class SearchStoredCardsRequest : IRequest
    {
        public string CardAlias { get; set; }
        public string CardBrand { get; set; }
        public CardType? CardType { get; set; }
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
        public string CardBankName { get; set; }
        public CardAssociation? CardAssociation { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}
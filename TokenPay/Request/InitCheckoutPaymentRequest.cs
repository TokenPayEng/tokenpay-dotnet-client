using System.Collections.Generic;
using TokenPay.Model;
using TokenPay.Request.Common;
using TokenPay.Request.Dto;

namespace TokenPay.Request
{
    public class InitCheckoutPaymentRequest : IRequest
    {
        public decimal? Price { get; set; }

        public decimal? PaidPrice { get; set; }

        public decimal? WalletPrice { get; set; } = decimal.Zero;

        public int? Installment { get; set; }

        public Currency? Currency { get; set; }

        public PaymentGroup? PaymentGroup { get; set; }

        public string ConversationId { get; set; }
        
        public string CallbackUrl { get; set; }

        public PaymentPhase PaymentPhase { get; set; } = PaymentPhase.Auth;
        
        public string CardUserKey { get; set; }

        public long? BuyerId { get; set; }

        public Card Card { get; set; }

        public IList<PaymentItem> Items { get; set; }

        public bool? threedsVerifyOnly{get;set;}

        public bool?  saveMerchantDefaultCard{get;set;}
    }
}
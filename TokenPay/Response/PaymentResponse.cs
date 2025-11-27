using System;
using System.Collections.Generic;
using TokenPay.Model;
using TokenPay.Response.Dto;

namespace TokenPay.Response
{
    public class PaymentResponse
    {
        public long? Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal? Price { get; set; }
        public decimal? PaidPrice { get; set; }
        public decimal? WalletPrice { get; set; }
        public Currency Currency { get; set; }
        public long? BuyerId { get; set; }
        public int? Installment { get; set; }
        public string ConversationId { get; set; }
        public PaymentType? PaymentType { get; set; }
        public PaymentGroup? PaymentGroup { get; set; }
        public PaymentStatus? PaymentStatus { get; set; }
        public ConnectorType ConnectorType { get; set; }
        public PaymentPhase? PaymentPhase { get; set; }
        public bool? IsThreeDS { get; set; }
        public decimal? MerchantCommissionRate { get; set; }
        public decimal? MerchantCommissionRateAmount { get; set; }
        public decimal? PfCommissionRateAmount { get; set; }
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
        public bool? PaidWithStoredCard { get; set; }
        public string BinNumber { get; set; }
        public string LastFourDigits { get; set; }
        public CardType? CardType { get; set; }
        public CardAssociation? CardAssociation { get; set; }
        public string CardBrand { get; set; }
        public IList<PaymentTransaction> PaymentTransactions;
        public long? subscriptionId { get; set; }
    }
}
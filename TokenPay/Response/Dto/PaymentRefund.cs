using System;
using TokenPay.Model;

namespace TokenPay.Response.Dto
{
    public class PaymentRefund
    {
        public long? Id{get;set;}
        public DateTime? CreatedDate{get;set;}
        public RefundStatus? RefundStatus{get;set;}
        public RefundDestinationType? RefundDestinationType{get;set;}
        public decimal? Price{get;set;}
        public decimal? RefundBankPrice{get;set;}
        public decimal? RefundWalletPrice{get;set;}
        public string ConversationId{get;set;}
        public PaymentType? PaymentType{get;set;}
        public Error Error{get;set;}
    }
}
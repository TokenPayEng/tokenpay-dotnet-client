using System;
using System.Collections.Generic;
using TokenPay.Model;
using TokenPay.Response.Dto;

namespace TokenPay.Response
{
    public class PaymentDetailResponse
    {
        public long? Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string OrderId { get; set; }
        public decimal? Price { get; set; }
        public decimal? PaidPrice { get; set; }
        public decimal? WalletPrice { get; set; }
        public PaymentType? PaymentType { get; set; }
        public ConnectorType ConnectorType { get; set; }
        public Currency? Currency { get; set; }
        public PaymentStatus? PaymentStatus { get; set; }
        public string ConversationId { get; set; }
        public PaymentCard PaymentCard { get; set; }
        public List<PaymentRefund> PaymentRefunds { get; set; }
        public List<PaymentTransactionDetail> PaymentTransactions { get; set; }
    }
}
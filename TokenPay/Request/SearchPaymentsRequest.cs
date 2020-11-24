using System;
using System.Collections.Generic;
using TokenPay.Model;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class SearchPaymentsRequest : IRequest
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;

        public ISet<long> PaymentIds { get; set; }
        public ISet<long> PaymentTransactionIds { get; set; }
        public ISet<long> SubMerchantIds { get; set; }
        public ISet<string> ItemExternalIds { get; set; }
        public PaymentStatus? PaymentStatus { get; set; }

        public Currency? Currency { get; set; }
        public string BinNumber { get; set; }
        public string LastFourDigits { get; set; }

        public decimal? MinPrice { get; set; }
        public decimal? MinPaidPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public decimal? MaxPaidPrice { get; set; }

        public int? Installment { get; set; }
        public string ConversationId { get; set; }
        public bool? IsThreeDS { get; set; }

        public DateTime? MinCreatedDate { get; set; }
        public DateTime? MaxCreatedDate { get; set; }
    }
}
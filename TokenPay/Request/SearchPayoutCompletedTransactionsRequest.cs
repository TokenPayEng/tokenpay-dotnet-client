using System;
using TokenPay.Model;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class SearchPayoutCompletedTransactionsRequest : IRequest
    {
        public long? SettlementFileId { get; set; }
        public SettlementType? SettlementType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
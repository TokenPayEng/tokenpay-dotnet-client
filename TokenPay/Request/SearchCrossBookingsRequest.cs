using TokenPay.Model;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class SearchCrossBookingsRequest : IRequest
    {
        public long? SourceMerchantId { get; set; }
        public MerchantType? SourceMerchantType { get; set; }
        public long? DestinationMerchantId { get; set; }
        public MerchantType? DestinationMerchantType { get; set; }

        public CrossBookingTransactionStatus? TransactionStatus { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}
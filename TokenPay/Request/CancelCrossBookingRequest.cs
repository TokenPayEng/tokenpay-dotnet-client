using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class CancelCrossBookingRequest : IRequest
    {
        public long? CrossBookingId { get; set; }
    }
}
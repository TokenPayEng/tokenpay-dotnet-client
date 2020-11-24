using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class DeleteStoredCardRequest : IRequest
    {
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
    }
}
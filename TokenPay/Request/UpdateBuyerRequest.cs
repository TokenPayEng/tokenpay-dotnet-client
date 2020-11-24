using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class UpdateBuyerRequest : IRequest
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GsmNumber { get; set; }
        public string IdentityNumber { get; set; }
    }
}
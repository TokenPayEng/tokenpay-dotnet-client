using TokenPay.Model;

namespace TokenPay.Response
{
    public class BuyerResponse
    {
        public long? Id { get; set; }
        public Status? Status { get; set; }
        public string Email { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GsmNumber { get; set; }
        public string BuyerExternalId { get; set; }
    }
}
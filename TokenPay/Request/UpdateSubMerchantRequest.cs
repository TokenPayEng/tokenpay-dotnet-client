using TokenPay.Request.Common;
using TokenPay.Model;


namespace TokenPay.Request
{
    public class UpdateSubMerchantRequest : IRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Iban { get; set; }
        public string GsmNumber { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public string IdentityNumber { get; set; }
        public string LegalCompanyTitle { get; set; }
        public SubMerchantType? SubMerchantType { get; set; }
    }
}
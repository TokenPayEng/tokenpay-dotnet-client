using TokenPay.Model;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class CreateSubMerchantRequest : IRequest
    {
        public SubMerchantType? SubMerchantType { get; set; }
        public string SubMerchantExternalId { get; set; }
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
        public bool? OnTheFlyOnboarding { get; set; }
    }
}
namespace TokenPay.Response.Dto
{
    public class BouncedSubMerchantRow
    {
        public long? Id { get; set; }
        public string Iban { get; set; }
        public string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public string LegalCompanyTitle { get; set; }
    }
}
using System;
using TokenPay.Model;

namespace TokenPay.Response
{
    public class LinkResponse
    {
        public long Id { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Token { get; set; }
        public string Url { get; set; }
        public string EnabledInstallments { get; set; }
        public string QrCodeUrl { get; set; }
        public Status Status { get; set; }
        public decimal? Price { get; set; }
        public int? Stock { get; set; }
        public int SoldCount { get; set; }
    }
}
using System;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class CreateLinkRequest : IRequest
    {
        public int? Stock { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string Name { get; set; }
        public string EnabledInstallments { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
    }
}
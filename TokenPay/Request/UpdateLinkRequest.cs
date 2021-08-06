using System;
using TokenPay.Model;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class UpdateLinkRequest : IRequest
    {
        public Status? Status { get; set; }
        public int? Stock { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string Name { get; set; }
        public string EnabledInstallments { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
    }
}
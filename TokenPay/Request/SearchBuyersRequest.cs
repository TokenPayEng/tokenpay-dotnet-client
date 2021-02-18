using System;
using System.Collections.Generic;
using TokenPay.Model;
using TokenPay.Request.Common;

namespace TokenPay.Request
{
    public class SearchBuyersRequest : IRequest
    {
        public Status Status { get; set; }
        public string Email { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GsmNumber { get; set; }
        public string BuyerExternalId { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}
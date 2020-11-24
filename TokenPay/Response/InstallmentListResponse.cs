using System.Collections.Generic;
using TokenPay.Response.Dto;

namespace TokenPay.Response
{
    public class InstallmentListResponse
    {
        public IList<Installment> Items { get; set; }
    }
}
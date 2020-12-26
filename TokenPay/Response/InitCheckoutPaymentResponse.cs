using System;
using System.Text;

namespace TokenPay.Response
{
    public class InitCheckoutPaymentResponse
    {
        public string Token { get; set; }
        
        public string PageUrl { get; set; }
    }
}
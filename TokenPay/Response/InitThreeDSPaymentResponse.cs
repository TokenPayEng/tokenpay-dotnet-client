using System;
using System.Text;

namespace TokenPay.Response
{
    public class InitThreeDSPaymentResponse
    {
        public string HtmlContent { get; set; }

        public string GetDecodedHtmlContent()
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(HtmlContent));
        }
    }
}
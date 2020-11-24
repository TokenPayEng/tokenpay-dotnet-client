namespace TokenPay.Request
{
    public class InitThreeDSPaymentRequest : CreatePaymentRequest
    {
        public string CallbackUrl;
    }
}
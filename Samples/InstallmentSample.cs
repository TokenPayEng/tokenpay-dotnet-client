using NUnit.Framework;
using TokenPay;
using TokenPay.Model;
using TokenPay.Request;

namespace Samples
{
    public class InstallmentSample
    {
        private readonly TokenPay.TokenPay _tokenPay =
            new TokenPay.TokenPay("api-key", "secret-key", "https://api-gateway.tokenpay.com.tr");

        [Test]
        public void Retrieve_Bin()
        {
            var binNumber = "525864";

            var response = _tokenPay.Installment().RetrieveBinNumber(binNumber);
            Assert.NotNull(response);
            Assert.AreEqual(response.BinNumber, binNumber);
            Assert.AreEqual(response.CardType, CardType.CreditCard);
            Assert.AreEqual(response.CardAssociation, CardAssociation.MasterCard);
            Assert.AreEqual(response.CardBrand, "World");
            Assert.AreEqual(response.BankName, "YAPI VE KREDİ BANKASI A.Ş.");
            Assert.AreEqual(response.BankCode, 67L);
            Assert.AreEqual(response.Commercial, false);
        }

        [Test]
        public void Search_Installments()
        {
            var request = new SearchInstallmentsRequest
            {
                BinNumber = "525864",
                Price = 100,
                Currency = Currency.Try
            };

            var response = _tokenPay.Installment().SearchInstallments(request);
            Assert.True(response.Items.Count > 0);
        }
    }
}